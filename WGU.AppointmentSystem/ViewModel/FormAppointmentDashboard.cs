using System;
using System.Windows.Forms;
using WGU.AppointmentSystem.ViewModel;

namespace WGU.AppointmentSystem
{
    public partial class FormAppointmentDashboard : Form
    {
        public FormAppointmentDashboard()
        {
            InitializeComponent();
        }

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
    }
}
