using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WGU.AppointmentSystem.Model;
using WGU.AppointmentSystem.ViewModel;
using System.Globalization;
using System.Linq;
using WGU.AppointmentSystem.Logs;

namespace WGU.AppointmentSystem
{
    public partial class FormLogin : Form
    {
        public string CurrentCulture;
        public List<User> users;

        public FormLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        // Helper Methods
        private void FormLogin_Load(object sender, EventArgs e)
        {
            CurrentCulture = CultureInfo.CurrentCulture.Name;
            users = Utility.GetUsers();
            lblErrorMessage.Text = "";
            ActiveControl = txtUsername;


            if (CurrentCulture == "sw-KE")
            {
                UpdateLoginInfoToSwahili();
            }
        }

        private void UpdateLoginInfoToSwahili()
        {
            lblLoginTitle.Text = "Karibu SB Consulting";
            lblLoginSubTitle.Text = "Tafadhali Ingia!";
            lblUsername.Text = "Jina La Mtumiaji";
            lblPassword.Text = "Nenosiri";
            CheckboxShowPassword.Text = "Onyesha Nenosiri";
            btnLogin.Text = "Ingia";
            btnClearForm.Text = "Futa";
            btnExitApp.Text = "Toka";
        }

        private void ClearFields()
        {
            try
            {
                foreach (Control item in FormLogin.ActiveForm.Controls)
                {
                    if (item is TextBox box)
                    {
                        box.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event Handler Methods
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                if (username.Equals("") || password.Equals(""))
                {
                    string errorMessage;
                    errorMessage = CurrentCulture == "sw-KE" ? "Jina la mtumiaji na Nenosiri zinahitajika kuingia, Jaribu tena!" : "Username and Password are required to login, Try again!";
                    MessageBox.Show(errorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                List<User> loggedInUser = users.Where(user => user.USERNAME.Equals(username)).ToList();

                if (loggedInUser.Count < 1)
                {
                    if(CurrentCulture == "sw-KE")
                    {
                        MessageBox.Show("Jina la mtumiaji halipo!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFields();
                    }

                    MessageBox.Show("Username does not exist!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFields();
                }
                else
                {
                    if (loggedInUser[0].PASSWORD.Equals(password))
                    {
                        // Log the activity here
                        LoginActivity.LoginActivityLog(loggedInUser[0]);
                        new FormHomePage(loggedInUser[0]).Show();
                        this.Hide();
                    }
                    else
                    {
                        if (CurrentCulture == "sw-KE")
                        {
                            MessageBox.Show("Nenosiri siyo sahihi!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Text = "";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message} \nError stacktrace: {ex.StackTrace} \nInner Exception: {ex.InnerException} \nError source: {ex.Source}");
                lblErrorMessage.Text = ex.Message;
            }


        }

        private void BtnClearForm_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void CheckboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            try
            {
                iExit = MessageBox.Show("Do you want to Exit the Application?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
    }
}
