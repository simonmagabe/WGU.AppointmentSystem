using System;
using System.Windows.Forms;

namespace WGU.AppointmentSystem.ViewModel
{
    public partial class FormReportsDashboard : Form
    {
        public FormReportsDashboard()
        {
            InitializeComponent();
        }

        //Event Handler Methods
        private void BtnBackToHome_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            try
            {
                iExit = MessageBox.Show("Do you want to go back to Home Page?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    new FormHomePage(FormHomePage.LOGGGED_IN_USER).Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnNumberOfAppointmentByMonth_Click(object sender, EventArgs e)
        {
            EnableReportButton(BtnNumberOfAppointmentByMonth);
            DisableReportButton(BtnAppointmentsForEachConsultant);
            DisableReportButton(BtnAllAppointments);
        }

        private void BtnAppointmentsForEachConsultant_Click(object sender, EventArgs e)
        {
            EnableReportButton(BtnAppointmentsForEachConsultant);
            DisableReportButton(BtnNumberOfAppointmentByMonth);
            DisableReportButton(BtnAllAppointments);
        }

        private void BtnAllAppointments_Click(object sender, EventArgs e)
        {
            EnableReportButton(BtnAllAppointments);
            DisableReportButton(BtnAppointmentsForEachConsultant);
            DisableReportButton(BtnNumberOfAppointmentByMonth);
        }



        //Helper Methods
        private void EnableReportButton(Button button)
        {
            button.Font.Bold.Equals(true);
            button.BackColor.Equals(System.Drawing.Color.SkyBlue);
        }

        private void DisableReportButton(Button button)
        {
            button.Font.Bold.Equals(false);
            button.BackColor.Equals(System.Drawing.Color.LightCyan);
        }

    }
}
