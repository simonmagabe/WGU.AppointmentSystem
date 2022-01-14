using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using DataModel;
using WGU.AppointmentSystem.ViewModel;
using WGU.AppointmentSystem.Model;

namespace WGU.AppointmentSystem
{
    public partial class FormCustomerRecords : Form
    {
        private readonly FormLogin LoginForm = new FormLogin();
        readonly Database database = new Database();

        public FormCustomerRecords()
        {
            InitializeComponent();
            dataGridViewCustomers.DataSource = Utility.customers;
        }

        // Helper Methods
        private void FormCustomerRecords_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCustomerName;
            //string sqlCommandText = "SELECT cu.customerName, addr.phone, addr.address, ci.city, addr.postalCode, co.country " +
            //    "FROM client_schedule.customer cu " +
            //    "JOIN address addr USING(addressId) " +
            //    "JOIN city ci USING(cityId) " +
            //    "JOIN country co USING(countryId)";
            
            //database.LoadData(sqlCommandText);
            //dataGridViewCustomers.DataSource = database.SqlDataTable;
        }

        private bool UserInfoComplete()
        {
            return txtCustomerName.Text == "" &&
            txtPhone.Text == "" &&
            txtStreet.Text == "" &&
            txtCity.Text == "" &&
            txtZip.Text == "" &&
            txtCountry.Text == "";
        }

        public void ClearFields()
        {
            try
            {
                foreach (Control item in splitContainerUserRecords.Panel1.Controls)
                {
                    if (item is TextBox box)
                    {
                        box.Clear();
                    }
                }

                txtCustomerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event Handler Methods
        private void BtnExit_Click(object sender, EventArgs e)
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnBackToHome_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            try
            {
                iExit = MessageBox.Show("Do you want to go back to Login Page?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    new FormHomePage(FormHomePage.LOGGGED_IN_USER).Show();
                    ClearFields();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
