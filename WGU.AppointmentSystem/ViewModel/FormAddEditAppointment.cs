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
            UpdateAddEditAppointmentFormTitle();
            PopulateCustomerDropDownList();
            PopulateEditAppointmentForm();
        }

        private void PopulateEditAppointmentForm()
        {
            if (SelectedAppointmentId >= 0)
            {
                Appointment selectedAppointment = Utility.AppointmentsList.Single(appointment => appointment.APPOINTMENTID == SelectedAppointmentId);
                txtBoxCustomerId.Text = selectedAppointment.APPOINTMENTID.ToString();
                ComboBoxAppointmentType.Text = selectedAppointment.TYPE;
                dateTimePickerStartDate.Value = selectedAppointment.STARTDATE;
                dateTimePickerEndDate.Value = selectedAppointment.ENDDATE;
            }
            else
            {
                SetAppointmentDefaultBusinessHours();
            }
        }

        private void SetAppointmentDefaultBusinessHours()
        {
            DateTime currentTime = DateTime.Now;
            dateTimePickerStartDate.Value = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
            dateTimePickerEndDate.Value = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 17, 0, 0);
        }

        private void UpdateAddEditAppointmentFormTitle()
        {
            string addAppointmentTitle = "Create New Appointment";
            string editAppointmentTitle = "Edit Appointment";
            _ = SelectedAppointmentId >= 0 ? lblNewEditAppointmentTitle.Text = editAppointmentTitle : lblNewEditAppointmentTitle.Text = addAppointmentTitle;
        }

        private void PopulateCustomerDropDownList()
        {
            Appointment selectedAppointment = Utility.AppointmentsList.Single(appointment => appointment.APPOINTMENTID == SelectedAppointmentId);

            Dictionary<int, string> customerDictionary = Utility.CustomersList.ToDictionary(customer => customer.CUSTOMERID, customer => customer.CUSTOMERNAME);
            ComboBoxCustomer.DataSource = new BindingSource(customerDictionary, null);
            ComboBoxCustomer.DisplayMember = "Value";
            ComboBoxCustomer.ValueMember = "Key";
            ComboBoxCustomer.SelectedItem = null;

            if (SelectedAppointmentId >= 0)
            {
                ComboBoxCustomer.Text = customerDictionary[selectedAppointment.CUSTOMERID];
            }
        }
        #endregion
    }
}
