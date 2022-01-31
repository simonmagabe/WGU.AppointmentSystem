using DataModel;
using System;
using System.Drawing;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;

namespace WGU.AppointmentSystem.ViewModel
{
    public partial class FormReportsDashboard : Form
    {
        private Form HomePage;
        Database database = new Database();

        bool isNumsOfApptsByMonth = true;
        bool isApptsScheduledForEachConsultant = false;
        bool isNumOfApptsForEachCustomer = false;

        public FormReportsDashboard(Form homePage)
        {
            InitializeComponent();
            HomePage = homePage;
        }

        private void FormReportsDashboard_Load(object sender, EventArgs e)
        {
            DisplayApproprieteReport();
            HighlightButton(BtnNumberOfAppointmentByMonth);
            database.LoadConsultantReport(AppointmentsForEachConsultantQueryString(), dataGridViewConsultantsReport);
            database.LoadAllCustomersAppointmentsReport(AllAppointmentsQueryString(), dataGridViewAllScheduledApptsReport);
            database.LoadAppointmentsByMonthReport(AppointmentsByMonthQueryString(), dataGridViewApptsByMonth);
        }

        //Event Handler Methods
        private void BtnAllAppointments_MouseDown(object sender, MouseEventArgs e)
        {
            isNumsOfApptsByMonth = false;
            isApptsScheduledForEachConsultant = false;
            isNumOfApptsForEachCustomer = true;

            DisplayApproprieteReport();

            dataGridViewAllScheduledApptsReport.ClearSelection();

            HighlightButton(BtnAllAppointments);
            UnHighlightButton(BtnAppointmentsForEachConsultant);
            UnHighlightButton(BtnNumberOfAppointmentByMonth);
        }

        private void BtnNumberOfAppointmentByMonth_MouseClick(object sender, MouseEventArgs e)
        {
            isNumsOfApptsByMonth = true;
            isApptsScheduledForEachConsultant = false;
            isNumOfApptsForEachCustomer = false;

            DisplayApproprieteReport();
            dataGridViewApptsByMonth.ClearSelection();

            HighlightButton(BtnNumberOfAppointmentByMonth);
            UnHighlightButton(BtnAppointmentsForEachConsultant);
            UnHighlightButton(BtnAllAppointments);
        }

        private void BtnAppointmentsForEachConsultant_MouseClick(object sender, MouseEventArgs e)
        {
            isNumsOfApptsByMonth = false;
            isApptsScheduledForEachConsultant = true;
            isNumOfApptsForEachCustomer = false;

            DisplayApproprieteReport();
            dataGridViewConsultantsReport.ClearSelection();

            HighlightButton(BtnAppointmentsForEachConsultant);
            UnHighlightButton(BtnNumberOfAppointmentByMonth);
            UnHighlightButton(BtnAllAppointments);
        }

        private void BtnBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage.Show();
        }

        //Helper Methods
        private void HighlightButton(Button button)
        {
            button.Font.Bold.Equals(true);
            button.BackColor = Color.Teal;
        }

        private void UnHighlightButton(Button button)
        {
            button.Font.Bold.Equals(false);
            button.BackColor = Color.LightCyan;
        }

        private void DisplayApproprieteReport()
        {
            if (isNumsOfApptsByMonth)
            {
                dataGridViewApptsByMonth.Show();
                dataGridViewConsultantsReport.Hide();
                dataGridViewAllScheduledApptsReport.Hide();
            }

            if (isApptsScheduledForEachConsultant)
            {
                dataGridViewConsultantsReport.Show();
                dataGridViewApptsByMonth.Hide();
                dataGridViewAllScheduledApptsReport.Hide();
            }

            if (isNumOfApptsForEachCustomer)
            {
                dataGridViewConsultantsReport.Hide();
                dataGridViewApptsByMonth.Hide();
                dataGridViewAllScheduledApptsReport.Show();
            }
        }

        private string AllAppointmentsQueryString()
        {
            string queryString = $"SELECT count(cu.customerId) as 'No. Appointments', cu.customerName, addr.address, ci.city, addr.phone, co.country " +
                                 $"FROM client_schedule.address as addr " +
                                        $"join client_schedule.customer cu " +
                                        $"using(addressId) " +
                                        $"join client_schedule.appointment appt " +
                                        $"using(customerId) " +
                                        $"join client_schedule.city as ci " +
                                        $"using(cityId) " +
                                        $"join client_schedule.country co " +
                                        $"using(countryId) " +
                                 $"group by cu.customerName " +
                                 $"order by 'No. Appointments' desc;";

            return queryString;
        }

        private string AppointmentsForEachConsultantQueryString()
        {
            string queryString = "SELECT appt.createdBy as Consultant, " +
                                        "cu.customerName AS 'Customer Name', " +
                                        "appt.type AS 'Appt. Type', " +
                                        "appt.start AS Start, " +
                                        "appt.end AS End " +
                                 "FROM client_schedule.appointment appt " +
                                 "JOIN client_schedule.customer cu " +
                                 "USING(customerId) " +
                                 "ORDER BY appt.createdBy, appt.end";
            return queryString;
        }

        private string AppointmentsByMonthQueryString()
        {
            string fromDate = "2000-12-31";
            string toDate = "2030-12-31";
            string queryString = $"SELECT MONTHNAME(end) AS Month, " +
                                        $"YEAR(end) AS Year, " +
                                        $"type AS 'Appt. Type', " +
                                        $"COUNT(customerId) 'Total Appointments' " +
                                 $"FROM client_schedule.appointment " +
                                 $"WHERE end >= '{ fromDate }' AND end <= '{ toDate }' " +
                                 $"GROUP BY MONTH(end);";
            return queryString;
        }
    }
}
