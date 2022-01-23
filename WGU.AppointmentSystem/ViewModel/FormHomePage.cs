using System;
using System.Linq;
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
            Utility.GetAddresses();
            Utility.GetCities();
            Utility.GetCountries();
            Utility.GetAppointments();
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

        private void FormHomePage_Shown(object sender, System.EventArgs e)
        {
            var appointmentDueInFifteenMinutes = Utility.appointments.Where(appointment =>
            {
                DateTime currentDateTime = DateTime.Now;
                TimeSpan minutesToAppointmentTime = new TimeSpan(0, 15, 0);
                TimeSpan timeDue = appointment.STARTDATE - currentDateTime;
                if (timeDue <= minutesToAppointmentTime && timeDue > new TimeSpan(0, 0, 0))
                {
                    return true;
                }
                return false;
            });

            if (appointmentDueInFifteenMinutes.Count() > 0)
            {
                Appointment appointmentDue = appointmentDueInFifteenMinutes.First();
                string dueAppointmentMsgBoxTitle = "Upcoming Appointment";
                MessageBox.Show($"Upcoming Appointment: {Utility.customers.Where(customer => customer.CUSTOMERID == appointmentDue.CUSTOMERID).Single().CUSTOMERNAME} at " +
                    $"{appointmentDue.STARTDATE.ToString("hh:mm tt")}.", dueAppointmentMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
