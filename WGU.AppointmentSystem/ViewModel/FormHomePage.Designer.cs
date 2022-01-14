
namespace WGU.AppointmentSystem.ViewModel
{
    partial class FormHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHomepageIntroText = new System.Windows.Forms.Label();
            this.lblHomepageTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.panelFeatures = new System.Windows.Forms.Panel();
            this.lblFeaturesDesc = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.lblFeaturesTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("MS PGothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(28, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SB Consulting";
            // 
            // lblHomepageIntroText
            // 
            this.lblHomepageIntroText.AutoSize = true;
            this.lblHomepageIntroText.BackColor = System.Drawing.Color.Transparent;
            this.lblHomepageIntroText.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomepageIntroText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHomepageIntroText.Location = new System.Drawing.Point(6, 76);
            this.lblHomepageIntroText.MaximumSize = new System.Drawing.Size(650, 500);
            this.lblHomepageIntroText.Name = "lblHomepageIntroText";
            this.lblHomepageIntroText.Size = new System.Drawing.Size(649, 120);
            this.lblHomepageIntroText.TabIndex = 1;
            this.lblHomepageIntroText.Text = resources.GetString("lblHomepageIntroText.Text");
            this.lblHomepageIntroText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHomepageTitle
            // 
            this.lblHomepageTitle.AutoSize = true;
            this.lblHomepageTitle.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomepageTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHomepageTitle.Location = new System.Drawing.Point(3, 27);
            this.lblHomepageTitle.Name = "lblHomepageTitle";
            this.lblHomepageTitle.Size = new System.Drawing.Size(182, 38);
            this.lblHomepageTitle.TabIndex = 2;
            this.lblHomepageTitle.Text = "About Us:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHomepageTitle);
            this.panel1.Controls.Add(this.lblHomepageIntroText);
            this.panel1.Location = new System.Drawing.Point(34, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 228);
            this.panel1.TabIndex = 3;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHome.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Black;
            this.lblHome.Location = new System.Drawing.Point(605, 27);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(98, 32);
            this.lblHome.TabIndex = 4;
            this.lblHome.Text = "HOME";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFeatures
            // 
            this.panelFeatures.BackColor = System.Drawing.Color.LightCyan;
            this.panelFeatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFeatures.Controls.Add(this.lblFeaturesDesc);
            this.panelFeatures.Controls.Add(this.btnReports);
            this.panelFeatures.Controls.Add(this.btnAppointments);
            this.panelFeatures.Controls.Add(this.btnCustomers);
            this.panelFeatures.Controls.Add(this.lblFeaturesTitle);
            this.panelFeatures.Location = new System.Drawing.Point(34, 389);
            this.panelFeatures.Name = "panelFeatures";
            this.panelFeatures.Size = new System.Drawing.Size(669, 279);
            this.panelFeatures.TabIndex = 5;
            // 
            // lblFeaturesDesc
            // 
            this.lblFeaturesDesc.AutoSize = true;
            this.lblFeaturesDesc.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeaturesDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFeaturesDesc.Location = new System.Drawing.Point(81, 84);
            this.lblFeaturesDesc.Name = "lblFeaturesDesc";
            this.lblFeaturesDesc.Size = new System.Drawing.Size(502, 24);
            this.lblFeaturesDesc.TabIndex = 2;
            this.lblFeaturesDesc.Text = "Click links below to learn more about our features";
            this.lblFeaturesDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(442, 159);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(188, 56);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.Location = new System.Drawing.Point(227, 159);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(199, 56);
            this.btnAppointments.TabIndex = 1;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.BtnAppointments_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(39, 159);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(171, 56);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // lblFeaturesTitle
            // 
            this.lblFeaturesTitle.AutoSize = true;
            this.lblFeaturesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFeaturesTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeaturesTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFeaturesTitle.Location = new System.Drawing.Point(243, 20);
            this.lblFeaturesTitle.Name = "lblFeaturesTitle";
            this.lblFeaturesTitle.Size = new System.Drawing.Size(132, 30);
            this.lblFeaturesTitle.TabIndex = 0;
            this.lblFeaturesTitle.Text = "Features";
            this.lblFeaturesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(283, 722);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(727, 837);
            this.Controls.Add(this.panelFeatures);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFeatures.ResumeLayout(false);
            this.panelFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHomepageIntroText;
        private System.Windows.Forms.Label lblHomepageTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelFeatures;
        private System.Windows.Forms.Label lblFeaturesDesc;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label lblFeaturesTitle;
        private System.Windows.Forms.Button btnExit;
    }
}