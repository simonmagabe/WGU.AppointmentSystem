using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;
using WGU.AppointmentSystem.ViewModel;

namespace WGU.AppointmentSystem
{
    public partial class FormCustomerRecords : Form
    {
        public FormCustomerRecords()
        {
            InitializeComponent();
            dataGridViewCustomers.DataSource = Utility.customers;
            ToggleSaveAndClearBtnStatus(false);
        }

        #region OnLoad Method
        private void FormCustomerRecords_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCustomerName;
            dataGridViewCustomers.ClearSelection();
            ToggleCustomerInputsAbility(false);
            btnSave.Visible = true;
            BtnDeleteCustomer.Visible = true;
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
        #endregion


        #region Helper Methods
        private void ToggleSaveAndClearBtnStatus(bool status)
        {
            btnSave.Enabled = status;
            btnClear.Enabled = status;
        }

        private void ToggleCustomerInputsAbility(bool isEnabled)
        {
            txtCustomerName.Enabled = isEnabled;
            txtPhone.Enabled = isEnabled;
            txtStreet.Enabled = isEnabled;
            txtStreet2.Enabled = isEnabled;
            comboBoxCity.Enabled = isEnabled;
            txtZipCode.Enabled = isEnabled;
            comboBoxCountry.Enabled = isEnabled;
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

        private void ValidateRequiredTextBoxtField(TextBox textBox, string fieldName)
        {
            try
            {
                string errorMessage = $"A customer's {fieldName} is required!";

                foreach (Control item in splitContainerUserRecords.Panel1.Controls)
                {
                    
                    if (item is TextBox box && textBox.Name  == box.Name && box.Text == "")
                    {
                        MessageBox.Show(errorMessage, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        private void ValidateRequiredComboBoxField(ComboBox comboBox, string comboBoxFieldName)
        {
            try
            {
                string errorMessage = $"A customer's {comboBoxFieldName} is required!";

                foreach (Control item in splitContainerUserRecords.Panel1.Controls)
                {
                    if (item is ComboBox box && comboBox.Name == box.Name && box.SelectedItem == null)
                    {
                        MessageBox.Show(errorMessage, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                MessageBox.Show(exc.Message, "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion


        #region Event Click Handler Methods
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateRequiredTextBoxtField(txtCustomerName, "name");
                ValidateRequiredTextBoxtField(txtStreet, "street address");
                ValidateRequiredTextBoxtField(txtPhone, "phone");
                ValidateRequiredComboBoxField(comboBoxCity, "city");
                ValidateRequiredTextBoxtField(txtZipCode, "postal code");
                ValidateRequiredComboBoxField(comboBoxCountry, "country");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            dataGridViewCustomers.ClearSelection();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ToggleCustomerInputsAbility(false);
            ToggleSaveAndClearBtnStatus(false);
            ClearFields();
            btnSave.Visible = true;
            btnCancel.Visible = false;
            BtnUpdateCustomer.Visible = true;
            BtnDeleteCustomer.Visible = true;
            BtnAddNewCustomer.Visible = true;
            dataGridViewCustomers.ClearSelection();
            dataGridViewCustomers.Enabled = true;
        }

        private void DataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Visible = false;
                btnCancel.Visible = true;
                BtnAddNewCustomer.Visible = false;
                ToggleCustomerInputsAbility(true);
                ActiveControl = txtCustomerName;
                ToggleSaveAndClearBtnStatus(true);

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

        private void BtnAddNewCustomer_Click(object sender, EventArgs e)
        {
            ToggleCustomerInputsAbility(true);
            ToggleSaveAndClearBtnStatus(true);
            ActiveControl = txtCustomerName;
            dataGridViewCustomers.Enabled = false;
            BtnUpdateCustomer.Visible = false;
            BtnDeleteCustomer.Visible = false;
            btnCancel.Visible = true;
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            NoRowSelectectedWarning("update");
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                NoRowSelectectedWarning("delete");

                bool cutomerHasScheduledAppointments = false;
                DataGridViewRow selectedDataGridRow = dataGridViewCustomers.SelectedRows[0];
                int selectedCustomerId = int.Parse(selectedDataGridRow.Cells[0].Value.ToString().Trim());
                string dialogErrorMessage = "Are you sure you want to delete selected record?";
                string dialogTitle = "Confirm Deletion";
                DialogResult dialogResult = MessageBox.Show(dialogErrorMessage, dialogTitle, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    foreach (var item in Utility.appointments)
                    {
                        _ = item.CUSTOMERID == selectedCustomerId ? cutomerHasScheduledAppointments = true : cutomerHasScheduledAppointments = false;
                    }

                    if (cutomerHasScheduledAppointments)
                    {
                        string errorMessage = "A customer with scheduled appointment(s) cannot be deleted!";
                        string title = "Confirm Deletion";
                        _ = MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Customer selectedCustomer = Utility.customers.Where(customer => customer.CUSTOMERID == selectedCustomerId).Single();
                    Utility.DeleteCustomer(selectedCustomer);
                    ClearFields();
                } else
                {
                    dataGridViewCustomers.ClearSelection();
                    ClearFields();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion


        #region Text Change Event Handler Methods
        private void TxtCustomerId_TextChanged(object sender, EventArgs e)
        {
            //ToggleSaveAndClearBtnStatus();
        }

        private void TxtCustomerName_TextChanged(object sender, EventArgs e)
        {
            //ToggleSaveAndClearBtnStatus();
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            //ToggleSaveAndClearBtnStatus();
        }

        private void TxtStreet_TextChanged(object sender, EventArgs e)
        {
            //ToggleSaveAndClearBtnStatus();
        }

        private void ComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ToggleSaveAndClearBtnStatus();
        }

        private void TxtZipCode_TextChanged(object sender, EventArgs e)
        {
            //ToggleSaveAndClearBtnStatus();
        }

        private void ComboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ToggleSaveAndClearBtnStatus();
        }
        #endregion
    }
}
