
namespace WGU.AppointmentSystem
{
    partial class FormAppointmentDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.BtnEditAppointment = new System.Windows.Forms.Button();
            this.BtnNewAppointment = new System.Windows.Forms.Button();
            this.BtnDeleteAppointment = new System.Windows.Forms.Button();
            this.lblAppointmentsDashboard = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxApptType = new System.Windows.Forms.ComboBox();
            this.BtnSearchAppointment = new System.Windows.Forms.Button();
            this.DateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtboxCustomerId = new System.Windows.Forms.TextBox();
            this.RadioBtnDates = new System.Windows.Forms.RadioButton();
            this.RadioBtnAppointmentType = new System.Windows.Forms.RadioButton();
            this.RadioBtnCustomerId = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppointmentTableTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(53, 460);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 24;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(937, 226);
            this.dataGridViewAppointments.TabIndex = 0;
            // 
            // BtnEditAppointment
            // 
            this.BtnEditAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditAppointment.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditAppointment.Location = new System.Drawing.Point(448, 707);
            this.BtnEditAppointment.Name = "BtnEditAppointment";
            this.BtnEditAppointment.Size = new System.Drawing.Size(97, 45);
            this.BtnEditAppointment.TabIndex = 2;
            this.BtnEditAppointment.Text = "EDIT";
            this.BtnEditAppointment.UseVisualStyleBackColor = true;
            // 
            // BtnNewAppointment
            // 
            this.BtnNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewAppointment.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewAppointment.Location = new System.Drawing.Point(302, 707);
            this.BtnNewAppointment.Name = "BtnNewAppointment";
            this.BtnNewAppointment.Size = new System.Drawing.Size(121, 45);
            this.BtnNewAppointment.TabIndex = 1;
            this.BtnNewAppointment.Text = "NEW";
            this.BtnNewAppointment.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteAppointment
            // 
            this.BtnDeleteAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteAppointment.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAppointment.Location = new System.Drawing.Point(565, 707);
            this.BtnDeleteAppointment.Name = "BtnDeleteAppointment";
            this.BtnDeleteAppointment.Size = new System.Drawing.Size(109, 45);
            this.BtnDeleteAppointment.TabIndex = 3;
            this.BtnDeleteAppointment.Text = "DELETE";
            this.BtnDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // lblAppointmentsDashboard
            // 
            this.lblAppointmentsDashboard.AutoSize = true;
            this.lblAppointmentsDashboard.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentsDashboard.Location = new System.Drawing.Point(303, 20);
            this.lblAppointmentsDashboard.Name = "lblAppointmentsDashboard";
            this.lblAppointmentsDashboard.Size = new System.Drawing.Size(306, 28);
            this.lblAppointmentsDashboard.TabIndex = 1;
            this.lblAppointmentsDashboard.Text = "Appointments Dashboard";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.Location = new System.Drawing.Point(766, 28);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(126, 19);
            this.lblLoggedUser.TabIndex = 2;
            this.lblLoggedUser.Text = "Logged User:";
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToHome.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToHome.Location = new System.Drawing.Point(770, 785);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(220, 51);
            this.btnBackToHome.TabIndex = 2;
            this.btnBackToHome.Text = "< BACK TO HOME";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            this.btnBackToHome.Click += new System.EventHandler(this.BtnBackToHome_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitApp.Location = new System.Drawing.Point(53, 785);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(147, 51);
            this.btnExitApp.TabIndex = 1;
            this.btnExitApp.Text = "EXIT APP";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxApptType);
            this.panel1.Controls.Add(this.BtnSearchAppointment);
            this.panel1.Controls.Add(this.DateTimePickerStartDate);
            this.panel1.Controls.Add(this.DateTimePickerEndDate);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.lblEndDate);
            this.panel1.Controls.Add(this.txtboxCustomerId);
            this.panel1.Controls.Add(this.RadioBtnDates);
            this.panel1.Controls.Add(this.RadioBtnAppointmentType);
            this.panel1.Controls.Add(this.RadioBtnCustomerId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.panel1.Location = new System.Drawing.Point(53, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 299);
            this.panel1.TabIndex = 5;
            // 
            // comboBoxApptType
            // 
            this.comboBoxApptType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApptType.FormattingEnabled = true;
            this.comboBoxApptType.Items.AddRange(new object[] {
            "Consultation",
            "Lunch",
            "Interview",
            "Presentation",
            "Scrum",
            ""});
            this.comboBoxApptType.Location = new System.Drawing.Point(206, 125);
            this.comboBoxApptType.Name = "comboBoxApptType";
            this.comboBoxApptType.Size = new System.Drawing.Size(189, 26);
            this.comboBoxApptType.TabIndex = 1;
            // 
            // BtnSearchAppointment
            // 
            this.BtnSearchAppointment.BackColor = System.Drawing.Color.Azure;
            this.BtnSearchAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchAppointment.FlatAppearance.BorderSize = 0;
            this.BtnSearchAppointment.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchAppointment.Location = new System.Drawing.Point(394, 233);
            this.BtnSearchAppointment.Name = "BtnSearchAppointment";
            this.BtnSearchAppointment.Size = new System.Drawing.Size(138, 49);
            this.BtnSearchAppointment.TabIndex = 3;
            this.BtnSearchAppointment.Text = "SEARCH";
            this.BtnSearchAppointment.UseVisualStyleBackColor = false;
            this.BtnSearchAppointment.Click += new System.EventHandler(this.BtnSearchAppointment_Click);
            // 
            // DateTimePickerStartDate
            // 
            this.DateTimePickerStartDate.Location = new System.Drawing.Point(576, 122);
            this.DateTimePickerStartDate.Name = "DateTimePickerStartDate";
            this.DateTimePickerStartDate.Size = new System.Drawing.Size(342, 26);
            this.DateTimePickerStartDate.TabIndex = 1;
            this.DateTimePickerStartDate.ValueChanged += new System.EventHandler(this.DateTimePickerStartDate_ValueChanged);
            // 
            // DateTimePickerEndDate
            // 
            this.DateTimePickerEndDate.Location = new System.Drawing.Point(576, 161);
            this.DateTimePickerEndDate.Name = "DateTimePickerEndDate";
            this.DateTimePickerEndDate.Size = new System.Drawing.Size(342, 26);
            this.DateTimePickerEndDate.TabIndex = 2;
            this.DateTimePickerEndDate.Value = new System.DateTime(2021, 12, 24, 0, 0, 0, 0);
            this.DateTimePickerEndDate.ValueChanged += new System.EventHandler(this.DateTimePickerEndDate_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(436, 125);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(98, 19);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(434, 167);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(87, 19);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtboxCustomerId
            // 
            this.txtboxCustomerId.Location = new System.Drawing.Point(32, 125);
            this.txtboxCustomerId.Name = "txtboxCustomerId";
            this.txtboxCustomerId.Size = new System.Drawing.Size(163, 26);
            this.txtboxCustomerId.TabIndex = 1;
            // 
            // RadioBtnDates
            // 
            this.RadioBtnDates.AutoSize = true;
            this.RadioBtnDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnDates.Location = new System.Drawing.Point(437, 70);
            this.RadioBtnDates.Name = "RadioBtnDates";
            this.RadioBtnDates.Size = new System.Drawing.Size(77, 23);
            this.RadioBtnDates.TabIndex = 3;
            this.RadioBtnDates.Text = "Dates";
            this.RadioBtnDates.UseVisualStyleBackColor = true;
            this.RadioBtnDates.CheckedChanged += new System.EventHandler(this.RadioBtnDates_CheckedChanged);
            // 
            // RadioBtnAppointmentType
            // 
            this.RadioBtnAppointmentType.AutoSize = true;
            this.RadioBtnAppointmentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnAppointmentType.Location = new System.Drawing.Point(206, 70);
            this.RadioBtnAppointmentType.Name = "RadioBtnAppointmentType";
            this.RadioBtnAppointmentType.Size = new System.Drawing.Size(177, 23);
            this.RadioBtnAppointmentType.TabIndex = 2;
            this.RadioBtnAppointmentType.Text = "Appointment Type";
            this.RadioBtnAppointmentType.UseVisualStyleBackColor = true;
            this.RadioBtnAppointmentType.CheckedChanged += new System.EventHandler(this.RadioBtnAppointmentType_CheckedChanged);
            // 
            // RadioBtnCustomerId
            // 
            this.RadioBtnCustomerId.AutoSize = true;
            this.RadioBtnCustomerId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtnCustomerId.Location = new System.Drawing.Point(32, 70);
            this.RadioBtnCustomerId.Name = "RadioBtnCustomerId";
            this.RadioBtnCustomerId.Size = new System.Drawing.Size(133, 23);
            this.RadioBtnCustomerId.TabIndex = 1;
            this.RadioBtnCustomerId.Text = "Customer ID";
            this.RadioBtnCustomerId.UseVisualStyleBackColor = true;
            this.RadioBtnCustomerId.CheckedChanged += new System.EventHandler(this.RadioBtnCustomerId_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(320, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for an Appointment";
            // 
            // lblAppointmentTableTitle
            // 
            this.lblAppointmentTableTitle.AutoSize = true;
            this.lblAppointmentTableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAppointmentTableTitle.Location = new System.Drawing.Point(49, 413);
            this.lblAppointmentTableTitle.Name = "lblAppointmentTableTitle";
            this.lblAppointmentTableTitle.Size = new System.Drawing.Size(427, 24);
            this.lblAppointmentTableTitle.TabIndex = 6;
            this.lblAppointmentTableTitle.Text = "This will display the Title of the Appointment Table";
            // 
            // FormAppointmentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1034, 851);
            this.Controls.Add(this.lblAppointmentTableTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblAppointmentsDashboard);
            this.Controls.Add(this.BtnNewAppointment);
            this.Controls.Add(this.BtnDeleteAppointment);
            this.Controls.Add(this.BtnEditAppointment);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Name = "FormAppointmentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAppointmentDashboard";
            this.Load += new System.EventHandler(this.FormAppointmentDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button BtnEditAppointment;
        private System.Windows.Forms.Button BtnNewAppointment;
        private System.Windows.Forms.Button BtnDeleteAppointment;
        private System.Windows.Forms.Label lblAppointmentsDashboard;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxApptType;
        private System.Windows.Forms.Button BtnSearchAppointment;
        private System.Windows.Forms.DateTimePicker DateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtboxCustomerId;
        private System.Windows.Forms.RadioButton RadioBtnDates;
        private System.Windows.Forms.RadioButton RadioBtnAppointmentType;
        private System.Windows.Forms.RadioButton RadioBtnCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppointmentTableTitle;
    }
}