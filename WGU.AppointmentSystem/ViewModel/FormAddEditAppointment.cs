using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;

namespace WGU.AppointmentSystem.ViewModel
{
    public partial class FormAddEditAppointment : Form
    {
        private int SelectedAppointmentId = -1;
        

        public FormAddEditAppointment()
        {
            InitializeComponent();
        }

        public FormAddEditAppointment(int appoinmentId)
        {
            InitializeComponent();
            SelectedAppointmentId = appoinmentId;
        }

        #region Event Listeners
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCustomerId = int.Parse(ComboBoxCustomer.SelectedValue.ToString().Trim());
                string selectedAppointmentType = ComboBoxAppointmentType.SelectedValue.ToString();
                bool appointmentIsOverlapping = false;

                DateTime currentDateTime = DateTime.Now;
                TimeSpan openingBusinessHour = new DateTime(currentDateTime.Year, currentDateTime.Month, currentDateTime.Day, 8, 0, 0).TimeOfDay;
                TimeSpan closingBusinessHour = new DateTime(currentDateTime.Hour, currentDateTime.Month, currentDateTime.Day, 19, 0, 0).TimeOfDay;

                DateTime selectedStartDateTime = dateTimePickerStartDate.Value;
                DateTime selectedEndDateTime = dateTimePickerEndDate.Value;

                foreach (Appointment appointment in Utility.AppointmentsList)
                {
                    _ = (selectedStartDateTime >= appointment.STARTDATE && selectedStartDateTime < appointment.ENDDATE) ? 
                        appointmentIsOverlapping = true : appointmentIsOverlapping = false;

                    _ = (selectedEndDateTime > appointment.STARTDATE && selectedEndDateTime <= appointment.ENDDATE) ?
                        appointmentIsOverlapping = true : appointmentIsOverlapping = false;
                }

                if (selectedCustomerId < 1)
                {
                    string warningBoxMessage = "A Customer ID is REQUIRED to save.";
                    MessageBox.Show(warningBoxMessage, "Add Appointment Page", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                FormAppointmentDashboard.ValidateAppoinmentSearchDates(selectedStartDateTime, selectedEndDateTime);

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
                    string errorMessage = "An Appointment CANNOT overlap and Existing Appointment";
                    MessageBox.Show(errorMessage, "Add Appointment Page", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (selectedCustomerId > -1)
                {
                    Appointment selectedAppointment = Utility.AppointmentsList.Single(appointment => appointment.APPOINTMENTID == SelectedAppointmentId);
                    Utility.UpdateAppointment(selectedAppointment, selectedCustomerId, selectedAppointmentType, selectedStartDateTime, selectedEndDateTime);

                    new FormAppointmentDashboard().Show();
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iCancel;

            try
            {
                iCancel = MessageBox.Show("Are you sure you want to cancel?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iCancel == DialogResult.Yes)
                {
                    new FormAppointmentDashboard().Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearAppointmentForm();
        }

        private void ClearAppointmentForm()
        {
            txtBoxCustomerId.Text = "";
            ComboBoxCustomer.SelectedItem = null;
            ComboBoxAppointmentType.SelectedItem = null;
            SetAppointmentDefaultBusinessHours();
        }

        #endregion

        #region Helper Methods
        private void FormAddEditAppointment_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

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
                SetAppointmentDefaultBusinessHours();
            }
        }

        private void SetAppointmentTypesDataSource()
        {
            string[] appointmentTypes = { "Scrum", "Presentation", "Lunch", "Interview", "Consultation" };
            ComboBoxAppointmentType.DataSource = appointmentTypes;
            ComboBoxAppointmentType.SelectedItem = null;
        }

        private void SetAppointmentDefaultBusinessHours()
        {
            try
            {
                DateTime currentTime = DateTime.Now;
                DateTime openingBusinessHour = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
                DateTime closingBusinessHour = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 17, 0, 0);

                dateTimePickerStartDate.Value = openingBusinessHour;
                dateTimePickerEndDate.Value = closingBusinessHour;
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
