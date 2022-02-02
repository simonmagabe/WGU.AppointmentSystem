
namespace WGU.AppointmentSystem
{
    partial class FormCustomerRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitContainerUserRecords = new System.Windows.Forms.SplitContainer();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            this.BtnAddNewCustomer = new System.Windows.Forms.Button();
            this.BtnUpdateCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.btnBackToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUserRecords)).BeginInit();
            this.splitContainerUserRecords.Panel1.SuspendLayout();
            this.splitContainerUserRecords.Panel2.SuspendLayout();
            this.splitContainerUserRecords.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers Records";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCustomerName.Location = new System.Drawing.Point(44, 63);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(139, 23);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(198, 58);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(338, 36);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(198, 100);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(338, 38);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSave.Location = new System.Drawing.Point(290, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // splitContainerUserRecords
            // 
            this.splitContainerUserRecords.BackColor = System.Drawing.Color.Thistle;
            this.splitContainerUserRecords.Location = new System.Drawing.Point(12, 58);
            this.splitContainerUserRecords.Name = "splitContainerUserRecords";
            // 
            // splitContainerUserRecords.Panel1
            // 
            this.splitContainerUserRecords.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainerUserRecords.Panel1.Controls.Add(this.comboBoxCountry);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.comboBoxCity);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.lblCustomerId);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.btnClear);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.btnCancel);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.btnSave);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.lblCustomerName);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.lblCountry);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.lblZip);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.lblCity);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.label2);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.lblStreet2);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.txtCustomerId);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.lblPhone);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.txtCustomerName);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.txtZipCode);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.txtStreet);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.txtStreet2);
            this.splitContainerUserRecords.Panel1.Controls.Add(this.txtPhone);
            // 
            // splitContainerUserRecords.Panel2
            // 
            this.splitContainerUserRecords.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainerUserRecords.Panel2.Controls.Add(this.BtnDeleteCustomer);
            this.splitContainerUserRecords.Panel2.Controls.Add(this.BtnAddNewCustomer);
            this.splitContainerUserRecords.Panel2.Controls.Add(this.btnBackToHome);
            this.splitContainerUserRecords.Panel2.Controls.Add(this.BtnUpdateCustomer);
            this.splitContainerUserRecords.Size = new System.Drawing.Size(827, 422);
            this.splitContainerUserRecords.SplitterDistance = 583;
            this.splitContainerUserRecords.TabIndex = 6;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(198, 315);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(338, 31);
            this.comboBoxCountry.TabIndex = 7;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(198, 232);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(338, 31);
            this.comboBoxCity.TabIndex = 6;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCustomerId.Location = new System.Drawing.Point(73, 21);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(110, 23);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnClear.Location = new System.Drawing.Point(432, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 44);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCancel.FlatAppearance.BorderSize = 2;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCancel.Location = new System.Drawing.Point(148, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCountry.Location = new System.Drawing.Point(108, 323);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(75, 23);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblZip.Location = new System.Drawing.Point(147, 280);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(36, 23);
            this.lblZip.TabIndex = 1;
            this.lblZip.Text = "Zip";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblCity.Location = new System.Drawing.Point(141, 236);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 23);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(125, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Street";
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblStreet2.Location = new System.Drawing.Point(110, 193);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(73, 23);
            this.lblStreet2.TabIndex = 1;
            this.lblStreet2.Text = "Street 2";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerId.Location = new System.Drawing.Point(198, 16);
            this.txtCustomerId.Multiline = true;
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(338, 36);
            this.txtCustomerId.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblPhone.Location = new System.Drawing.Point(124, 105);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 23);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone";
            // 
            // txtZipCode
            // 
            this.txtZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(198, 269);
            this.txtZipCode.Multiline = true;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(338, 38);
            this.txtZipCode.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(198, 144);
            this.txtStreet.Multiline = true;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(338, 38);
            this.txtStreet.TabIndex = 2;
            // 
            // txtStreet2
            // 
            this.txtStreet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtStreet2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStreet2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet2.Location = new System.Drawing.Point(198, 188);
            this.txtStreet2.Multiline = true;
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(338, 38);
            this.txtStreet2.TabIndex = 2;
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnDeleteCustomer.FlatAppearance.BorderSize = 2;
            this.BtnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(24, 232);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(195, 44);
            this.BtnDeleteCustomer.TabIndex = 4;
            this.BtnDeleteCustomer.Text = "DELETE CUSTOMER";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = false;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnAddNewCustomer
            // 
            this.BtnAddNewCustomer.BackColor = System.Drawing.Color.White;
            this.BtnAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnAddNewCustomer.FlatAppearance.BorderSize = 2;
            this.BtnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnAddNewCustomer.Location = new System.Drawing.Point(24, 65);
            this.BtnAddNewCustomer.Name = "BtnAddNewCustomer";
            this.BtnAddNewCustomer.Size = new System.Drawing.Size(195, 44);
            this.BtnAddNewCustomer.TabIndex = 4;
            this.BtnAddNewCustomer.Text = "ADD NEW CUSTOMER";
            this.BtnAddNewCustomer.UseVisualStyleBackColor = false;
            this.BtnAddNewCustomer.Click += new System.EventHandler(this.BtnAddNewCustomer_Click);
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.BackColor = System.Drawing.Color.White;
            this.BtnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnUpdateCustomer.FlatAppearance.BorderSize = 2;
            this.BtnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BtnUpdateCustomer.Location = new System.Drawing.Point(24, 149);
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.Size = new System.Drawing.Size(195, 44);
            this.BtnUpdateCustomer.TabIndex = 4;
            this.BtnUpdateCustomer.Text = "UPDATE CUSTOMER";
            this.BtnUpdateCustomer.UseVisualStyleBackColor = false;
            this.BtnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewCustomers);
            this.panel1.Location = new System.Drawing.Point(14, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 186);
            this.panel1.TabIndex = 7;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeColumns = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCustomers.MultiSelect = false;
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersVisible = false;
            this.dataGridViewCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(817, 173);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCustomers_CellClick);
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBackToHome.FlatAppearance.BorderSize = 2;
            this.btnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnBackToHome.Location = new System.Drawing.Point(24, 365);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(195, 44);
            this.btnBackToHome.TabIndex = 4;
            this.btnBackToHome.Text = "< BACK TO HOME";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            this.btnBackToHome.Click += new System.EventHandler(this.BtnBackToHome_Click);
            // 
            // FormCustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(849, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainerUserRecords);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCustomerRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCustomerRecords_FormClosed);
            this.Load += new System.EventHandler(this.FormCustomerRecords_Load);
            this.splitContainerUserRecords.Panel1.ResumeLayout(false);
            this.splitContainerUserRecords.Panel1.PerformLayout();
            this.splitContainerUserRecords.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUserRecords)).EndInit();
            this.splitContainerUserRecords.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SplitContainer splitContainerUserRecords;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BtnDeleteCustomer;
        private System.Windows.Forms.Button BtnUpdateCustomer;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnAddNewCustomer;
    }
}

