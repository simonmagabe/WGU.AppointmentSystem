using System;
using System.Windows.Forms;

namespace WGU.AppointmentSystem.ViewModel
{
    public partial class FormAddEditAppointment : Form
    {
        public FormAddEditAppointment()
        {
            InitializeComponent();
        }

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
            dateTimePickerStartDate.Value = DateTime.UtcNow;
            dateTimePickerEndDate.Value = DateTime.UtcNow.AddMinutes(30);
        }
    }
}
