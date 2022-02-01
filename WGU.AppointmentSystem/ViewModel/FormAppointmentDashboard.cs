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
        private Form HomePage;
        public FormAppointmentDashboard(Form homePage)
        {
            InitializeComponent();
            lblLoggedUser.Text = $"{lblLoggedUser.Text} {FormHomePage.LOGGGED_IN_USER.USERNAME}";
            HomePage = homePage;
            RadioBtnDates.Checked = true;
        }

        private void FormAppointmentDashboard_Load(object sender, EventArgs e)
        {
            SetDefaultAppointmentSearchDates();
            dataGridViewAppointments.ClearSelection();
        }

        // Event Listeners
        #region Event Listeners
        private void BtnBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage.Show();
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
            SetDefaultAppointmentSearchDates();
            comboBoxApptType.SelectedItem = null;
        }

        private void RadioBtnAppointmentType_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRadioButtons(true);
            txtboxCustomerId.Text = "";
            SetDefaultAppointmentSearchDates();
        }

        private void RadioBtnDates_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRadioButtons(true);
            txtboxCustomerId.Text = "";
            comboBoxApptType.SelectedItem = null;
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
                    dataGridViewAppointments.ClearSelection();
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
                    dataGridViewAppointments.ClearSelection();
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
                    dataGridViewAppointments.ClearSelection();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void TxtboxCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region NEW; EDIT; DELETE BUTTONS CLICK EVENTS
        private void BtnNewAppointment_Click(object sender, EventArgs e)
        {
            new FormAddEditAppointment(this).Show();
            this.Hide();
        }

        private void BtnEditAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dataGridViewAppointments.SelectedRows;

                if (selectedRows.Count < 1)
                {
                    AppointmentEditOrDeleteBtnWarning("Edit");
                    return;
                }

                int selectedAppointmentId = int.Parse(selectedRows[0].Cells[0].Value.ToString().Trim());

                new FormAddEditAppointment(this, selectedAppointmentId).Show();
                this.Hide();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Appointments Dashboard Page Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedAppointmentRows = dataGridViewAppointments.SelectedRows;

                if (selectedAppointmentRows.Count <= 0)
                {
                    AppointmentEditOrDeleteBtnWarning("Delete");
                    return;
                }

                string warningMessage = "You are about to delete the selected appointment. Are you sure?";
                string messageBoxTitle = "Appointment Delete Warning";
                DialogResult deleteConfirmation = MessageBox.Show(warningMessage, messageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (deleteConfirmation == DialogResult.Yes)
                {
                    int selectedAppointmentId = int.Parse(selectedAppointmentRows[0].Cells[0].Value.ToString().Trim());

                    Appointment selectedAppoinment = Utility.AppointmentsList.Single(appointment => appointment.APPOINTMENTID == selectedAppointmentId);

                    Utility.DeleteAppointment(selectedAppoinment);
                    PopulateAppoinmentsDataGrid();
                }
                
                dataGridViewAppointments.ClearSelection();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Appointments Dashboard Page Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

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

        internal void SetDefaultAppointmentSearchDates()
        {
            DateTimePickerStartDate.Value = GetStartOfCurrentMonth();
            DateTimePickerEndDate.Value = GetEndOfCurrentMonth();
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

        private BindingList<Appointment> GetAppointmentsByDates(DateTime startDate, DateTime endDate, int userId)
        {
            return new BindingList<Appointment>(Utility.AppointmentsList.Where(appointment => 
            appointment.STARTDATE >= startDate && appointment.ENDDATE <= endDate && appointment.USERID == userId).ToList());
        }

        private static BindingList<Appointment> GetAppointmentsByCustomerId(int customerId, int userId)
        {
            return new BindingList<Appointment>(Utility.AppointmentsList.Where(appointment => appointment.CUSTOMERID == customerId && appointment.USERID == userId).ToList());
        }

        private static BindingList<Appointment> GetAppointmentsByAppointmentTypes(string type, int userId)
        {
            return new BindingList<Appointment>(Utility.AppointmentsList.Where(appointment => appointment.TYPE == type && appointment.USERID == userId).ToList());
        }

        internal void PopulateAppoinmentsDataGrid()
        {
            int userId = FormHomePage.LOGGGED_IN_USER.USERID;
            string searchMsgBoxErrorTitle = "Customer Search";

            if (RadioBtnDates.Checked)
            {
                SetDefaultAppointmentSearchDates();

                DateTime startDate = DateTimePickerStartDate.Value;
                DateTime endDate = DateTimePickerEndDate.Value;

                ValidateAppoinmentSearchDates(startDate, endDate);

                BindingList<Appointment> appointmentsByDates = GetAppointmentsByDates(startDate, endDate, userId);

                if (appointmentsByDates.Count == 0)
                {
                    string message = $"No Appointments were found for time period [{startDate} - {endDate}]";
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

                BindingList<Appointment> appointmentsByType = GetAppointmentsByAppointmentTypes(appointmentType, userId);

                if (appointmentsByType.Count == 0)
                {
                    MessageBox.Show($"No appoinments for Type: [{appointmentType}'] Found!");
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

                BindingList<Appointment> customerAppointments = GetAppointmentsByCustomerId(customerId, userId);

                if (customerAppointments.Count < 1)
                {
                    string message = $"No appointments for CustomerID: [{customerId}] were found!";
                    MessageBox.Show(message, searchMsgBoxErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewAppointments.DataSource = customerAppointments;
                    return;
                }

                dataGridViewAppointments.DataSource = customerAppointments;
            }

            dataGridViewAppointments.ClearSelection();
        }

        public static void ValidateAppoinmentSearchDates(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                string errorMessage = $"End Date [{endDate}] Selected MUST be GREATER than Start Date [{startDate}] Selected.";
                MessageBox.Show(errorMessage, "Appointment Search", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void AppointmentEditOrDeleteBtnWarning(string action)
        {
            string message = $"An Appointment Record MUST be selected in order to {action}!";
            string warningBoxTitle = "Appointment Edit Warning";
            MessageBox.Show(message, warningBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion
    }
}
