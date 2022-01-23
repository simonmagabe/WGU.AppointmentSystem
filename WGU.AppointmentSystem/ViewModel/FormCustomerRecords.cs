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
            btnSave.Visible = false;
            btnClear.Visible = false;
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
            string warningMessage = $"Please, select a record below to {action}!";

            if (rowCount < 1)
            {
                throw new ApplicationException(warningMessage);
            }
        }

        private void ValidateRequiredTextBoxtField(TextBox textBox, string fieldName)
        {
            if (textBox.Text == "")
            {
                throw new ApplicationException($"A customer's {fieldName} is required!");
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

                
                string name = txtCustomerName.Text;
                string streetAddress1 = txtStreet.Text;
                string streetAddress2 = txtStreet2.Text;
                string phone = txtPhone.Text;
                string zipCode = txtZipCode.Text;
                int cityId = int.Parse(comboBoxCity.SelectedValue.ToString());
                int customerId;
                string signedInUser = FormHomePage.LOGGGED_IN_USER.USERNAME;

                if (txtCustomerId.Text == "")
                {
                    int addressId = Utility.AddAddress(streetAddress1, streetAddress2, cityId, zipCode, phone, signedInUser);
                    customerId = Utility.AddCustomer(name, addressId, signedInUser);
                    txtCustomerId.Text = customerId.ToString().Trim();
                }
                else
                {
                    customerId = int.Parse(txtCustomerId.Text);
                    Customer customerToUpdate = Utility.customers.Where(customer => customer.CUSTOMERID == customerId).Single();
                    Address customerAddress = Utility.addresses[customerToUpdate.ADDRESSID];
                    
                    Utility.UpdateCustomer(customerToUpdate, name, signedInUser);
                    
                    Utility.UpdateAddress(customerAddress, streetAddress1, streetAddress2, cityId, zipCode, phone, signedInUser);
                }

                ToggleCustomerInputsAbility(false);
                btnCancel.Text = "DONE";
                btnCancel.Visible = btnCancel.Enabled = true;
                btnSave.Visible = true;
                btnClear.Visible = true;
                btnSave.Enabled = false;
                btnClear.Enabled = false;
                BtnAddNewCustomer.Visible = BtnAddNewCustomer.Enabled = false;
                BtnUpdateCustomer.Text = "CONTINUE UPDATING";
                BtnUpdateCustomer.Visible = BtnUpdateCustomer.Enabled = true;
                BtnDeleteCustomer.Visible = BtnDeleteCustomer.Enabled = false;

                dataGridViewCustomers.Rows.Cast<DataGridViewRow>().Where(dataRow => int.Parse(dataRow.Cells[0].Value.ToString().Trim()) == customerId).Single().Selected = true;
            }
            catch (ApplicationException appExc)
            {
                MessageBox.Show(appExc.Message, "Customer Record Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            BtnAddNewCustomer.Visible = BtnAddNewCustomer.Enabled = true;
            BtnUpdateCustomer.Text = "UPDATE CUSTOMER";
            BtnUpdateCustomer.Visible = BtnUpdateCustomer.Enabled = true;
            BtnDeleteCustomer.Visible = BtnDeleteCustomer.Enabled = true;
            dataGridViewCustomers.ClearSelection();
            dataGridViewCustomers.Enabled = true;
        }

        private void DataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnAddNewCustomer.Visible = false;
                btnSave.Visible = false;
                btnClear.Visible = false;
                ToggleCustomerInputsAbility(false);
                ActiveControl = txtCustomerName;

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
            try
            {
                NoRowSelectectedWarning("update");

                ToggleCustomerInputsAbility(true);
                ToggleSaveAndClearBtnStatus(true);
                btnSave.Visible = true;
                btnCancel.Text = "CANCEL";
                btnClear.Visible = true;
                btnCancel.Visible = true;
                BtnDeleteCustomer.Visible = false;
                BtnUpdateCustomer.Visible = false;
                dataGridViewCustomers.Enabled = false;

                int countrySelectedKey = int.Parse(comboBoxCountry.SelectedValue.ToString().Trim());
                var updatedCityName = Utility.cities.Where(city => city.Value.COUNTRYID == countrySelectedKey).
                    ToDictionary(city => city.Key, city => city.Value.CITYNAME);
                comboBoxCity.DataSource = new BindingSource(updatedCityName, null);
                comboBoxCity.DisplayMember = "Value";
                comboBoxCity.ValueMember = "Key";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                NoRowSelectectedWarning("delete");

                string dialogErrorMessage = "Are you sure you want to delete selected record?";
                string dialogTitle = "Confirm Deletion";
                DialogResult dialogResult = MessageBox.Show(dialogErrorMessage, dialogTitle, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool cutomerHasScheduledAppointments = false;
                    DataGridViewRow selectedDataGridRow = dataGridViewCustomers.SelectedRows[0];
                    int selectedCustomerId = int.Parse(selectedDataGridRow.Cells[0].Value.ToString().Trim());

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
            catch (ApplicationException exc)
            {
                MessageBox.Show(exc.Message, "Customer Record Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        #endregion
    }
}
