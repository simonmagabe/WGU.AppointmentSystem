using System;
using System.Data;
using System.Windows.Forms;
using WGU.AppointmentSystem.ViewModel;
using WGU.AppointmentSystem.Model;
using System.Linq;
using System.Collections.Generic;

namespace WGU.AppointmentSystem
{
    public partial class FormCustomerRecords : Form
    {
        public FormCustomerRecords()
        {
            InitializeComponent();
            dataGridViewCustomers.DataSource = Utility.customers;
            ToggleSaveBtnStatus();
        }

        // Helper Methods
        private void ToggleSaveBtnStatus()
        {
            _ = CustomerInfoComplete() ? btnSave.Enabled = true : btnSave.Enabled = false;
        }

        private void FormCustomerRecords_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCustomerName;
            dataGridViewCustomers.ClearSelection();
            btnSave.Visible = true;
            btnDeleteUser.Visible = true;
            btnCancel.Visible = false;

            Dictionary<int, string> cityNamesKeyValues = Utility.cities.ToDictionary(city => city.Key, city => city.Value.CITYNAME);
            comboBoxCity.DataSource = new BindingSource(cityNamesKeyValues, null);
            comboBoxCity.DisplayMember = "Value";
            comboBoxCity.ValueMember = "Key";
            comboBoxCity.SelectedItem = null;

            Dictionary<int, string> countryNameKeyValues = Utility.countries.ToDictionary(country => country.Key, country => country.Value.COUNTRYNAME);
            comboBoxCountry.DataSource = new BindingSource(countryNameKeyValues, null);
            comboBoxCountry.DisplayMember = "Value";
            comboBoxCountry.ValueMember = "Key";
            comboBoxCountry.SelectedItem = null;
        }

        private bool CustomerInfoComplete()
        {
            bool infoComplete =  txtCustomerName.Text != "" && 
            txtCustomerId.Text != "" &&
            txtPhone.Text != "" &&
            txtStreet.Text != "" &&
            txtZipCode.Text != "" &&
            comboBoxCity.Text != "" &&
            comboBoxCountry.Text != "";

            return infoComplete;
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

                    if (item is ComboBox comboBox)
                    {
                        comboBox.SelectedItem = null;
                    }
                }

                txtCustomerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NoRowSelectectedWarning(string action)
        {
            int rowCount = dataGridViewCustomers.SelectedRows.Count;

            if (rowCount < 1)
            {
                MessageBox.Show($"Please, select a record below to {action}!", "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event Handler Methods
        private void BtnSave_Click(object sender, EventArgs e)
        {
            dataGridViewCustomers.ClearSelection();
            ClearFields();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            btnSave.Visible = true;
            btnCancel.Visible = false;
            dataGridViewCustomers.ClearSelection();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            NoRowSelectectedWarning("edit");
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            NoRowSelectectedWarning("delete");
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }

        private void DataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Visible = false;
                btnCancel.Visible = true;

                var selectedRow = dataGridViewCustomers.SelectedRows[0];
                int selectedCustomerId = int.Parse(selectedRow.Cells[0].Value.ToString().Trim());
                Customer selectedCustomer = Utility.customers.Where(customer => customer.CUSTOMERID == selectedCustomerId).Single();
                int selectedCustomerAddressId = int.Parse(selectedCustomer.ADDRESSID.ToString().Trim());
                int selectedCustomerCityId = Utility.addresses[selectedCustomerAddressId].CITYID;
                int selectedCustomerCountryId = Utility.cities[selectedCustomerCityId].COUNTRYID;

                txtCustomerId.Text = selectedCustomer.CUSTOMERID.ToString().Trim();
                txtCustomerName.Text = selectedCustomer.CUSTOMERNAME.ToString().Trim();
                txtPhone.Text = Utility.addresses[selectedCustomerAddressId].PHONE;
                txtStreet.Text = Utility.addresses[selectedCustomerAddressId].STREET1;
                txtStreet2.Text = Utility.addresses[selectedCustomerAddressId].STREET2;
                comboBoxCity.Text = Utility.cities[selectedCustomerCityId].CITYNAME;
                txtZipCode.Text = Utility.addresses[selectedCustomerAddressId].ZIPCODE;
                comboBoxCountry.Text = Utility.countries[selectedCustomerCountryId].COUNTRYNAME;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception error occured: - {ex.Message}");
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            ToggleSaveBtnStatus();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            ToggleSaveBtnStatus();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            ToggleSaveBtnStatus();
        }

        private void txtStreet_TextChanged(object sender, EventArgs e)
        {
            ToggleSaveBtnStatus();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleSaveBtnStatus();
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            ToggleSaveBtnStatus();
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleSaveBtnStatus();
        }
    }
}
