using DataModel;
using System;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;

namespace WGU.AppointmentSystem.ViewModel
{
    public partial class FormReportsDashboard : Form
    {
        private Form HomePage;
        public FormReportsDashboard(Form homePage)
        {
            InitializeComponent();
            HomePage = homePage;
        }

        //Event Handler Methods
        private void BtnBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage.Show();
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

            string queryString = "SELECT count(cu.customerId) as 'No. Appointments', cu.customerName, addr.address, ci.city, addr.postalCode, addr.phone, co.country " +
                                 "FROM client_schedule.address as addr " +
                                 "join client_schedule.customer cu " +
                                 "using(addressId) " +
                                 "join client_schedule.appointment appt " +
                                 "using(customerId) " +
                                 "join client_schedule.city as ci " +
                                 "using(cityId) " +
                                 "join client_schedule.country co " +
                                 "using(countryId) " +
                                 "group by cu.customerName;";
            Database database = new Database();
            database.LoadData(queryString, dataGridViewReports);
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
