
namespace WGU.AppointmentSystem.ViewModel
{
    partial class FormAddEditAppointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.ComboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.txtBoxCustomerId = new System.Windows.Forms.TextBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.lblNewEditAppointmentTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePickerEndDate);
            this.panel1.Controls.Add(this.dateTimePickerStartDate);
            this.panel1.Controls.Add(this.ComboBoxAppointmentType);
            this.panel1.Controls.Add(this.ComboBoxCustomer);
            this.panel1.Controls.Add(this.txtBoxCustomerId);
            this.panel1.Controls.Add(this.endLabel);
            this.panel1.Controls.Add(this.startLabel);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.customerLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(95, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 346);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(121, 252);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(372, 24);
            this.dateTimePickerEndDate.TabIndex = 23;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(121, 200);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(372, 24);
            this.dateTimePickerStartDate.TabIndex = 22;
            // 
            // ComboBoxAppointmentType
            // 
            this.ComboBoxAppointmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAppointmentType.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAppointmentType.FormattingEnabled = true;
            this.ComboBoxAppointmentType.Location = new System.Drawing.Point(121, 144);
            this.ComboBoxAppointmentType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxAppointmentType.Name = "ComboBoxAppointmentType";
            this.ComboBoxAppointmentType.Size = new System.Drawing.Size(372, 25);
            this.ComboBoxAppointmentType.TabIndex = 3;
            // 
            // ComboBoxCustomer
            // 
            this.ComboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCustomer.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCustomer.FormattingEnabled = true;
            this.ComboBoxCustomer.Location = new System.Drawing.Point(121, 91);
            this.ComboBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxCustomer.Name = "ComboBoxCustomer";
            this.ComboBoxCustomer.Size = new System.Drawing.Size(372, 25);
            this.ComboBoxCustomer.TabIndex = 2;
            // 
            // txtBoxCustomerId
            // 
            this.txtBoxCustomerId.Enabled = false;
            this.txtBoxCustomerId.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomerId.Location = new System.Drawing.Point(121, 38);
            this.txtBoxCustomerId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxCustomerId.Name = "txtBoxCustomerId";
            this.txtBoxCustomerId.ReadOnly = true;
            this.txtBoxCustomerId.Size = new System.Drawing.Size(372, 24);
            this.txtBoxCustomerId.TabIndex = 1;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(60, 257);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(38, 17);
            this.endLabel.TabIndex = 21;
            this.endLabel.Text = "End";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(51, 200);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(49, 17);
            this.startLabel.TabIndex = 20;
            this.startLabel.Text = "Start";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(51, 148);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(47, 17);
            this.typeLabel.TabIndex = 19;
            this.typeLabel.Text = "Type";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(23, 95);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(86, 17);
            this.customerLabel.TabIndex = 18;
            this.customerLabel.Text = "Customer";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(76, 40);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "ID";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Lavender;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSave.Location = new System.Drawing.Point(138, 490);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(130, 44);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Lavender;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCancel.Location = new System.Drawing.Point(449, 490);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 44);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblNewEditAppointmentTitle
            // 
            this.lblNewEditAppointmentTitle.AutoSize = true;
            this.lblNewEditAppointmentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNewEditAppointmentTitle.Location = new System.Drawing.Point(241, 30);
            this.lblNewEditAppointmentTitle.Name = "lblNewEditAppointmentTitle";
            this.lblNewEditAppointmentTitle.Size = new System.Drawing.Size(230, 25);
            this.lblNewEditAppointmentTitle.TabIndex = 4;
            this.lblNewEditAppointmentTitle.Text = "Create New Appointment";
            // 
            // FormAddEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(732, 573);
            this.Controls.Add(this.lblNewEditAppointmentTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddEditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEditAppointment";
            this.Load += new System.EventHandler(this.FormAddEditAppointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBoxAppointmentType;
        private System.Windows.Forms.ComboBox ComboBoxCustomer;
        private System.Windows.Forms.TextBox txtBoxCustomerId;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label lblNewEditAppointmentTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
    }
}