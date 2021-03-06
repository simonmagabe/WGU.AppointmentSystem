using System;
using System.Linq;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;
using WGU.AppointmentSystem.ViewModel;

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
            new FormCustomerRecords(this).Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            new FormLogin().Show();

            Utility.CustomersList.Clear();
            Utility.AddressesList.Clear();
            Utility.AppointmentsList.Clear();
            Utility.CitiesList.Clear();
            Utility.CountriesList.Clear();

            this.Close();
        }

        private void BtnAppointments_Click(object sender, System.EventArgs e)
        {
            FormAppointmentDashboard formAppointmentDashboard = new FormAppointmentDashboard(this);
            formAppointmentDashboard.Show();
            this.Hide();
            formAppointmentDashboard.PopulateAppoinmentsDataGrid();
        }

        private void BtnReports_Click(object sender, System.EventArgs e)
        {
            new FormReportsDashboard(this).Show();
            this.Hide();
        }

        private void FormHomePage_Shown(object sender, System.EventArgs e)
        {
            // This lambda expression makes code concise, more readable, less code to do simple things
            var appointmentDueInFifteenMinutes = Utility.AppointmentsList.Where(appointment =>
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
                string dueAppointmentMsgBoxTitle = "Upcoming Appointment Notification";

                // This lambda expression makes code concise, more readable, less code to do simple things
                MessageBox.Show($"Upcoming Appointment: {Utility.CustomersList.Single(customer => customer.CUSTOMERID == appointmentDue.CUSTOMERID).CUSTOMERNAME} at " +
                    $"{appointmentDue.STARTDATE:hh:mm tt}.", dueAppointmentMsgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
