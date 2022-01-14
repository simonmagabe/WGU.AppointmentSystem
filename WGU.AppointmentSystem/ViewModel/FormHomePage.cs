using System.Windows.Forms;
using WGU.AppointmentSystem.Model;

namespace WGU.AppointmentSystem.ViewModel
{
    public partial class FormHomePage : Form
    {
        public static User LOGGGED_IN_USER;

        public FormHomePage(User user)
        {
            InitializeComponent();
            LOGGGED_IN_USER = user;
        }

        private void FormHomePage_Load(object sender, System.EventArgs e)
        {
            Utility.GetCustomers();
            Utility.GetAppointments();
            Utility.GetAddresses();
            Utility.GetCities();
            Utility.GetCountries();
        }

        private void BtnCustomers_Click(object sender, System.EventArgs e)
        {
            new FormCustomerRecords().Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void BtnAppointments_Click(object sender, System.EventArgs e)
        {
            new FormAppointmentDashboard().Show();
            this.Hide();
        }

        private void BtnReports_Click(object sender, System.EventArgs e)
        {
            new FormReportsDashboard().Show();
            this.Hide();
        }
    }
}
