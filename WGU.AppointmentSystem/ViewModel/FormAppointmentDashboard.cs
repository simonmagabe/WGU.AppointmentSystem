using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;
using WGU.AppointmentSystem.ViewModel;

namespace WGU.AppointmentSystem
{
    public partial class FormAppointmentDashboard : Form
    {
        public FormAppointmentDashboard()
        {
            InitializeComponent();
            lblLoggedUser.Text = $"{lblLoggedUser.Text} {FormHomePage.LOGGGED_IN_USER.USERNAME}";
        }

        private void FormAppointmentDashboard_Load(object sender, EventArgs e)
        {
            ToggleRadioButtons(true);
            SetDefaultAppointmentSearchDates();
            PopulateAppoinmentsDataGrid();
            RadioBtnDates.Checked = true;
        }

        // Event Listeners
        #region Event Listeners
        private void BtnBackToHome_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            try
            {
                iExit = MessageBox.Show("Do you want to go back to Home Page?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            try
            {
                iExit = MessageBox.Show("Do you want to exit this Page?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadioBtnCustomerId_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRadioButtons(true);
        }

        private void RadioBtnAppointmentType_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRadioButtons(true);
        }

        private void RadioBtnDates_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRadioButtons(true);
        }

        private void DateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            SetAppointmentsGridTitleLabelText();
        }

        private void DateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            SetAppointmentsGridTitleLabelText();
        }

        private void BtnSearchAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioBtnDates.Checked)
                {
                    PopulateAppoinmentsDataGrid();
                }
                else if (RadioBtnAppointmentType.Checked)
                {
                    if (comboBoxApptType.Text == "")
                    {
                        string message = "An Appointment Type is Required to Search for Appointments!";
                        MessageBox.Show(message, "Appointment Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    PopulateAppoinmentsDataGrid();
                }
                else if (RadioBtnCustomerId.Checked)
                {
                    if (txtboxCustomerId.Text == "")
                    {
                        string message = "A CustomerID is Required to Search for Appointments!";
                        MessageBox.Show(message, "Appointment Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    PopulateAppoinmentsDataGrid();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion

        // Helper Methods
        #region Helper Methods
        private void ToggleRadioButtons(bool enabled)
        {
            if (RadioBtnDates.Checked == true)
            {
                txtboxCustomerId.Enabled = !enabled;
                comboBoxApptType.Enabled = !enabled;
                DateTimePickerStartDate.Enabled = enabled;
                DateTimePickerEndDate.Enabled = enabled;
                SetAppointmentsGridTitleLabelText();
            }
            else if (RadioBtnCustomerId.Checked == true)
            {
                txtboxCustomerId.Enabled = enabled;
                comboBoxApptType.Enabled = !enabled;
                DateTimePickerStartDate.Enabled = !enabled;
                DateTimePickerEndDate.Enabled = !enabled;
                SetAppointmentsGridTitleLabelText();
            }
            else if (RadioBtnAppointmentType.Checked == true)
            {
                txtboxCustomerId.Enabled = !enabled;
                comboBoxApptType.Enabled = enabled;
                DateTimePickerStartDate.Enabled = !enabled;
                DateTimePickerEndDate.Enabled = !enabled;
                SetAppointmentsGridTitleLabelText();
            }
        }

        private DateTime GetStartOfCurrentMonth()
        {
            return DateTime.Today.AddDays(1 - DateTime.Today.Day);
        }

        private DateTime GetEndOfCurrentMonth()
        {
            DateTime today = DateTime.Now;
            int DaysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
            return new DateTime(today.Year, today.Month, DaysInMonth);
        }

        private void SetDefaultAppointmentSearchDates()
        {
            DateTimePickerStartDate.Value = GetStartOfCurrentMonth();
            DateTimePickerEndDate.Value = GetEndOfCurrentMonth();
            SetAppointmentsGridTitleLabelText();
        }

        private void SetAppointmentsGridTitleLabelText()
        {
            if (RadioBtnAppointmentType.Checked == true)
            {
                lblAppointmentTableTitle.Text = "List of Appointments By Appointment Type: ";
            }
            else if (RadioBtnCustomerId.Checked == true)
            {
                lblAppointmentTableTitle.Text = "List of Appointments by CustomerID: ";
            }
            else if (RadioBtnDates.Checked == true)
            {
                lblAppointmentTableTitle.Text = $"List of Appointments Between ({DateTimePickerStartDate.Value} - {DateTimePickerEndDate.Value})";
            }
        }

        private BindingList<Appointment> GetAppointmentsByDates(DateTime startDate, DateTime endDate)
        {
            return new BindingList<Appointment>(Utility.appointments.Where(appointment => 
            appointment.STARTDATE >= startDate && appointment.ENDDATE <= endDate).ToList());
        }

        private static BindingList<Appointment> GetAppointmentsByCustomerId(int customerId)
        {
            return new BindingList<Appointment>(Utility.appointments.Where(appointment => appointment.CUSTOMERID == customerId).ToList());
        }

        private static BindingList<Appointment> GetAppointmentsByAppointmentTypes(string type)
        {
            return new BindingList<Appointment>(Utility.appointments.Where(appointment => appointment.TYPE == type).ToList());
        }

        private void PopulateAppoinmentsDataGrid()
        {
            string searchMsgBoxErrorTitle = "Customer Search";
            if (RadioBtnDates.Checked)
            {
                DateTime startDate = DateTimePickerStartDate.Value;
                DateTime endDate = DateTimePickerEndDate.Value;

                ValidateAppoinmentsSearchDates(startDate, endDate);

                BindingList<Appointment> appointmentsByDates = GetAppointmentsByDates(startDate, endDate);

                if (appointmentsByDates.Count == 0)
                {
                    string message = $"Ooh No! No appointments were founds for time period [{startDate} - {endDate}]";
                    MessageBox.Show(message, "Appointments Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridViewAppointments.DataSource = appointmentsByDates;
            }
            else if (RadioBtnAppointmentType.Checked)
            {
                string appointmentType = comboBoxApptType.Text;
                lblAppointmentTableTitle.Text = "List of Appointments By Appointment Type: ";
                lblAppointmentTableTitle.Text = $"{lblAppointmentTableTitle.Text} {appointmentType}";

                BindingList<Appointment> appointmentsByType = GetAppointmentsByAppointmentTypes(appointmentType);

                if (appointmentsByType.Count == 0)
                {
                    MessageBox.Show($"No appoinments for Type: {appointmentType} Found!");
                }
                 dataGridViewAppointments.DataSource = appointmentsByType;
            }
            else if (RadioBtnCustomerId.Checked)
            {
                int customerId = int.Parse(txtboxCustomerId.Text);
                lblAppointmentTableTitle.Text = "List of Appointments By CustomerID: ";
                lblAppointmentTableTitle.Text = $"{lblAppointmentTableTitle.Text} {customerId}";

                if (customerId <= 0)
                {
                    string errorMessage = "Customer ID Must be greater than 0.";
                    MessageBox.Show(errorMessage, searchMsgBoxErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BindingList<Appointment> customerAppointments = GetAppointmentsByCustomerId(customerId);

                if (customerAppointments.Count < 1)
                {
                    string message = $"No appoinments for CustomerID: {customerId} were found!";
                    MessageBox.Show(message, searchMsgBoxErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewAppointments.DataSource = customerAppointments;
                    return;
                }

                dataGridViewAppointments.DataSource = customerAppointments;
            }
        }

        private void ValidateAppoinmentsSearchDates(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                string errorMessage = $"End Date [{endDate}] Selected MUST be greater than Start Date [{startDate}] Selected.";
                MessageBox.Show(errorMessage, "Appointment Search", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }
        #endregion
    }
}
