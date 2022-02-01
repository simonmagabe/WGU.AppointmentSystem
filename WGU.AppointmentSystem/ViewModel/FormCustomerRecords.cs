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
        private Form HomePage;

        public FormCustomerRecords(Form homepage)
        {
            InitializeComponent();
            dataGridViewCustomers.DataSource = Utility.CustomersList;
            ToggleSaveAndClearBtnStatus(false);
            HomePage = homepage;
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

            Dictionary<int, string> cityNamesKeyValues = Utility.CitiesList.ToDictionary(city => city.Key, city => city.Value.CITYNAME);
            comboBoxCity.DataSource = new BindingSource(cityNamesKeyValues, null);
            comboBoxCity.DisplayMember = "Value";
            comboBoxCity.ValueMember = "Key";
            comboBoxCity.SelectedItem = null;

            Dictionary<int, string> countryNameKeyValues = Utility.CountriesList.ToDictionary(country => country.Key, country => country.Value.COUNTRYNAME);
            comboBoxCountry.DataSource = new BindingSource(countryNameKeyValues, null);
            comboBoxCountry.DisplayMember = "Value";
            comboBoxCountry.ValueMember = "Key";
            comboBoxCountry.SelectedItem = null;

            dataGridViewCustomers.ClearSelection();
        }
        #endregion


        #region Helper Methods
        private void ToggleSaveAndClearBtnStatus(bool status)
        {
            btnSave.Enabled = btnSave.Visible = status;
            btnClear.Enabled = btnClear.Visible = status;
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
                        MessageBox.Show(errorMessage, "Customer Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                MessageBox.Show(exc.Message, "Customer Page", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    ToggleCustomerInputsAbility(false);
                    ToggleSaveAndClearBtnStatus(false);
                    btnCancel.Visible = btnCancel.Enabled = false;

                    ClearFields();

                    BtnAddNewCustomer.Visible = BtnAddNewCustomer.Enabled = true;
                    BtnUpdateCustomer.Text = "UPDATE CUSTOMER";
                    BtnUpdateCustomer.Visible = BtnUpdateCustomer.Enabled = true;
                    BtnDeleteCustomer.Visible = BtnDeleteCustomer.Enabled = true;

                    dataGridViewCustomers.ClearSelection();
                    dataGridViewCustomers.Enabled = true;
                }
                else
                {
                    customerId = int.Parse(txtCustomerId.Text);
                    Customer customerToUpdate = Utility.CustomersList.Where(customer => customer.CUSTOMERID == customerId).Single();
                    Address customerAddress = Utility.AddressesList[customerToUpdate.ADDRESSID];
                    
                    Utility.UpdateCustomer(customerToUpdate, name, signedInUser);
                    
                    Utility.UpdateAddress(customerAddress, streetAddress1, streetAddress2, cityId, zipCode, phone, signedInUser);

                    ToggleCustomerInputsAbility(false);
                    btnCancel.Text = "DONE";
                    ToggleSaveAndClearBtnStatus(false);
                    BtnAddNewCustomer.Visible = BtnAddNewCustomer.Enabled = false;
                    BtnUpdateCustomer.Text = "CONTINUE UPDATING";
                    BtnUpdateCustomer.Visible = BtnUpdateCustomer.Enabled = true;
                    BtnDeleteCustomer.Visible = BtnDeleteCustomer.Enabled = false;

                    dataGridViewCustomers.Rows.Cast<DataGridViewRow>().Where(dataRow => int.Parse(dataRow.Cells[0].Value.ToString().Trim()) == customerId).Single().Selected = true;
                }
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
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ToggleCustomerInputsAbility(false);
            ToggleSaveAndClearBtnStatus(false);
            ClearFields();
            btnCancel.Visible = false;
            BtnAddNewCustomer.Visible = BtnAddNewCustomer.Enabled = true;
            BtnUpdateCustomer.Visible = BtnUpdateCustomer.Enabled = true;
            BtnDeleteCustomer.Visible = BtnDeleteCustomer.Enabled = true;
            BtnUpdateCustomer.Text = "UPDATE CUSTOMER";
            
            dataGridViewCustomers.ClearSelection();
            dataGridViewCustomers.Enabled = true;
        }

        private void DataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnAddNewCustomer.Visible = BtnAddNewCustomer.Enabled = false;
                btnSave.Visible = false;
                btnClear.Visible = false;
                ToggleCustomerInputsAbility(false);

                var selectedRow = dataGridViewCustomers.SelectedRows[0];
                int selectedCustomerId = int.Parse(selectedRow.Cells[0].Value.ToString().Trim());
                Customer selectedCustomer = Utility.CustomersList.Where(customer => customer.CUSTOMERID == selectedCustomerId).Single();
                int selectedCustomerAddressId = int.Parse(selectedCustomer.ADDRESSID.ToString().Trim());
                int selectedCustomerCityId = Utility.AddressesList[selectedCustomerAddressId].CITYID;
                int selectedCustomerCountryId = Utility.CitiesList[selectedCustomerCityId].COUNTRYID;

                txtCustomerId.Text = selectedCustomer.CUSTOMERID.ToString().Trim();
                txtCustomerName.Text = selectedCustomer.CUSTOMERNAME.ToString().Trim();
                txtPhone.Text = Utility.AddressesList[selectedCustomerAddressId].PHONE;
                txtStreet.Text = Utility.AddressesList[selectedCustomerAddressId].STREET1;
                txtStreet2.Text = Utility.AddressesList[selectedCustomerAddressId].STREET2;
                comboBoxCity.Text = Utility.CitiesList[selectedCustomerCityId].CITYNAME;
                txtZipCode.Text = Utility.AddressesList[selectedCustomerAddressId].ZIPCODE;
                comboBoxCountry.Text = Utility.CountriesList[selectedCustomerCountryId].COUNTRYNAME;
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
            BtnAddNewCustomer.Enabled = false;
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
                btnCancel.Text = "CANCEL";
                btnCancel.Visible = btnCancel.Enabled = true;
                BtnDeleteCustomer.Visible = BtnDeleteCustomer.Enabled = false;
                BtnUpdateCustomer.Visible = BtnUpdateCustomer.Enabled = false;
                dataGridViewCustomers.Enabled = false;

                int countrySelectedKey = int.Parse(comboBoxCountry.SelectedValue.ToString().Trim());

                // This lambda expression makes code concise, more readable, less code to do simple things
                var updatedCityName = Utility.CitiesList.Where(city => city.Value.COUNTRYID == countrySelectedKey).
                    ToDictionary(city => city.Key, city => city.Value.CITYNAME);

                comboBoxCity.DataSource = new BindingSource(updatedCityName, null);
                comboBoxCity.DisplayMember = "Value";
                comboBoxCity.ValueMember = "Key";
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

                    foreach (var item in Utility.AppointmentsList)
                    {
                        // This ternary (?:) operator is a a substitute for if...else statement
                        _ = item.CUSTOMERID == selectedCustomerId ? cutomerHasScheduledAppointments = true : cutomerHasScheduledAppointments = false;
                    }

                    if (cutomerHasScheduledAppointments)
                    {
                        string errorMessage = "A customer with scheduled appointment(s) cannot be deleted!";
                        string title = "Confirm Deletion";
                        _ = MessageBox.Show(errorMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // This lambda expression makes code concise, more readable, less code to do simple things
                    Customer selectedCustomer = Utility.CustomersList.Where(customer => customer.CUSTOMERID == selectedCustomerId).Single();

                    Utility.DeleteCustomer(selectedCustomer);
                    Utility.DeleteAddress(selectedCustomer.ADDRESSID);
                    ClearFields();
                } 
                else
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

        private void FormCustomerRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage.Show();
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '+') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
