using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;

namespace WGU.AppointmentSystem.ViewModel
{
    public partial class FormAddEditAppointment : Form
    {
        private int SelectedAppointmentId = -1;
        private FormAppointmentDashboard AppointmentDashboard;

        public FormAddEditAppointment(FormAppointmentDashboard appointmentDashboard)
        {
            InitializeComponent();
            AppointmentDashboard = appointmentDashboard;
        }

        public FormAddEditAppointment(FormAppointmentDashboard appointmentDashboard, int appoinmentId)
        {
            InitializeComponent();
            SelectedAppointmentId = appoinmentId;
            AppointmentDashboard = appointmentDashboard;
        }

        #region Event Listeners
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCustomerId;
                string selectedAppointmentType;

                if (ComboBoxCustomer.SelectedValue == null)
                {
                    string warningBoxMessage = "A Customer ID is REQUIRED! Please select a type to continue.";
                    MessageBox.Show(warningBoxMessage, "Add Appointment Page", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    selectedCustomerId = int.Parse(ComboBoxCustomer.SelectedValue.ToString().Trim());
                }

                if (ComboBoxAppointmentType.SelectedValue == null)
                {
                    string errorMessage = "An Appointment Type is REQUIRED! Please select a type to continue.";
                    MessageBox.Show(errorMessage, "Add An Appointment", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    selectedAppointmentType = ComboBoxAppointmentType.SelectedValue.ToString();
                }

                bool appointmentIsOverlapping = false;

                DateTime currentDateTime = DateTime.Now;
                TimeSpan openingBusinessHour = new DateTime(currentDateTime.Year, currentDateTime.Month, currentDateTime.Day, 8, 0, 0).TimeOfDay;
                TimeSpan closingBusinessHour = new DateTime(currentDateTime.Hour, currentDateTime.Month, currentDateTime.Day, 17, 0, 0).TimeOfDay;

                DateTime selectedStartDateTime = dateTimePickerStartDate.Value;
                DateTime selectedEndDateTime = dateTimePickerEndDate.Value;

                int userId = FormHomePage.LOGGGED_IN_USER.USERID;

                BindingList<Appointment> appointmentByUserId = GetAppointmentsByUserId(userId);

                foreach (Appointment appointment in appointmentByUserId)
                {
                    if (selectedStartDateTime >= appointment.STARTDATE && selectedStartDateTime < appointment.ENDDATE)
                    {
                        appointmentIsOverlapping = true;
                    }

                    if (selectedEndDateTime > appointment.STARTDATE && selectedEndDateTime <= appointment.ENDDATE)
                    {
                        appointmentIsOverlapping = true;
                    }
                }

                if (selectedEndDateTime < selectedStartDateTime)
                {
                    string errorMessage = $"End Date [{selectedEndDateTime}] Selected MUST be greater than Start Date [{selectedStartDateTime}] Selected.";
                    MessageBox.Show(errorMessage, "Appointment Search", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                bool isStartLessThanOpeningHour = selectedStartDateTime.TimeOfDay < openingBusinessHour;
                bool isStartGreaterThanClosingHour = selectedStartDateTime.TimeOfDay > closingBusinessHour;
                bool isEndLessThanOpeningHour = selectedEndDateTime.TimeOfDay < openingBusinessHour;
                bool isEndGreaterThanClosingHour = selectedEndDateTime.TimeOfDay > closingBusinessHour;

                if ((isStartLessThanOpeningHour || isStartGreaterThanClosingHour) || (isEndLessThanOpeningHour || isEndGreaterThanClosingHour))
                {
                    string errorMessage = "Error! Check the Start Date and End Date \nAppointment Business Hours are Between 08:00 AM - 05:00 PM.";

                    MessageBox.Show(errorMessage, "Add Appointment Page", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (appointmentIsOverlapping)
                {
                    string errorMessage = "An Appointment CANNOT overlap an Existing Appointment";
                    MessageBox.Show(errorMessage, "Add Appointment Page", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (SelectedAppointmentId >= 0)
                {
                    Appointment selectedAppointment = Utility.AppointmentsList.Single(appointment => appointment.APPOINTMENTID == SelectedAppointmentId);
                    Utility.UpdateAppointment(selectedAppointment, selectedCustomerId, selectedAppointmentType, selectedStartDateTime, selectedEndDateTime);
                }
                else
                {
                    Utility.AddAppointment(selectedCustomerId, selectedAppointmentType, selectedStartDateTime, selectedEndDateTime);
                }

                AppointmentDashboard.Show();
                this.Close();
                AppointmentDashboard.PopulateAppoinmentsDataGrid();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private BindingList<Appointment> GetAppointmentsByUserId(int userId)
        {
            return new BindingList<Appointment>(Utility.AppointmentsList.Where(appt => appt.USERID == userId).ToList());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iCancel;

            try
            {
                string boxTitle = "Add/Edit Appointment";
                iCancel = MessageBox.Show("Are you sure you want to cancel?", boxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iCancel == DialogResult.Yes)
                {
                    AppointmentDashboard.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Helper Methods
        private void FormAddEditAppointment_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            dateTimePickerStartDate.Format = DateTimePickerFormat.Time;
            dateTimePickerEndDate.Format = DateTimePickerFormat.Time;

            UpdateAddEditAppointmentFormTitle();

            Dictionary<int, string> customerDictionary = Utility.CustomersList.ToDictionary(customer => customer.CUSTOMERID, customer => customer.CUSTOMERNAME);
            ComboBoxCustomer.DataSource = new BindingSource(customerDictionary, null);
            ComboBoxCustomer.DisplayMember = "Value";
            ComboBoxCustomer.ValueMember = "Key";
            ComboBoxCustomer.SelectedItem = null;

            SetAppointmentTypesDataSource();

            if (SelectedAppointmentId >= 0)
            {
                Appointment selectedAppointment = Utility.AppointmentsList.Single(appointment => appointment.APPOINTMENTID == SelectedAppointmentId);
                txtBoxCustomerId.Text = selectedAppointment.APPOINTMENTID.ToString();
                ComboBoxCustomer.Text = customerDictionary[selectedAppointment.CUSTOMERID];
                ComboBoxAppointmentType.Text = selectedAppointment.TYPE;
                dateTimePickerStartDate.Value = selectedAppointment.STARTDATE;
                dateTimePickerEndDate.Value = selectedAppointment.ENDDATE;
            }
            else
            {
                SetAppointmentDefaultDateTime();
            }
        }

        private void SetAppointmentTypesDataSource()
        {
            string[] appointmentTypes = { "Scrum", "Presentation", "Lunch", "Interview", "Consultation" };
            ComboBoxAppointmentType.DataSource = appointmentTypes;
            ComboBoxAppointmentType.SelectedItem = null;
        }

        private void SetAppointmentDefaultDateTime()
        {
            try
            {
                DateTime currentTime = DateTime.Now;
                DateTime openingBusinessHour = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
                DateTime closingBusinessHour = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 17, 0, 0);
                dateTimePickerStartDate.Format = DateTimePickerFormat.Time;
                dateTimePickerEndDate.Format = DateTimePickerFormat.Time;

                if ((currentTime > openingBusinessHour) && (currentTime.Hour < closingBusinessHour.Hour))
                {
                    if (closingBusinessHour > currentTime)
                    {
                        if ((closingBusinessHour.Hour - currentTime.Hour) > 1)
                        {
                            dateTimePickerStartDate.Value = currentTime;
                            dateTimePickerEndDate.Value = currentTime.AddMinutes(30);
                        }
                        else
                        {
                            if ((closingBusinessHour.AddMilliseconds(-1).Minute - currentTime.Minute) > 30)
                            {
                                dateTimePickerEndDate.Value = closingBusinessHour;
                                dateTimePickerStartDate.Value = closingBusinessHour.AddMinutes(-30);
                            }
                            else
                            {
                                dateTimePickerStartDate.Value = openingBusinessHour.AddDays(1);
                                dateTimePickerEndDate.Value = openingBusinessHour.AddDays(1).AddMinutes(30);
                            }
                        }
                    }
                }
                else
                {
                    if (currentTime.Hour >= closingBusinessHour.Hour)
                    {
                        dateTimePickerStartDate.Value = openingBusinessHour.AddDays(1);
                        dateTimePickerEndDate.Value = openingBusinessHour.AddDays(1).AddMinutes(30);
                    }

                    if (currentTime.Hour < openingBusinessHour.Hour)
                    {
                        dateTimePickerStartDate.Value = openingBusinessHour;
                        dateTimePickerEndDate.Value = openingBusinessHour.AddMinutes(30);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UpdateAddEditAppointmentFormTitle()
        {
            string addAppointmentTitle = "Create New Appointment";
            string editAppointmentTitle = "Edit Appointment";
            _ = SelectedAppointmentId >= 0 ? lblNewEditAppointmentTitle.Text = editAppointmentTitle : lblNewEditAppointmentTitle.Text = addAppointmentTitle;
        }
        #endregion
    }
}
