
namespace WGU.AppointmentSystem.ViewModel
{
    partial class FormReportsDashboard
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
            this.splitContainerReportDash = new System.Windows.Forms.SplitContainer();
            this.BtnNumberOfAppointmentByMonth = new System.Windows.Forms.Button();
            this.BtnAppointmentsForEachConsultant = new System.Windows.Forms.Button();
            this.BtnAllAppointments = new System.Windows.Forms.Button();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.lblReportsSubTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnBackToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReportDash)).BeginInit();
            this.splitContainerReportDash.Panel1.SuspendLayout();
            this.splitContainerReportDash.Panel2.SuspendLayout();
            this.splitContainerReportDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerReportDash
            // 
            this.splitContainerReportDash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerReportDash.Font = new System.Drawing.Font("Myanmar Text", 9.5F);
            this.splitContainerReportDash.Location = new System.Drawing.Point(0, 104);
            this.splitContainerReportDash.Name = "splitContainerReportDash";
            // 
            // splitContainerReportDash.Panel1
            // 
            this.splitContainerReportDash.Panel1.Controls.Add(this.BtnAllAppointments);
            this.splitContainerReportDash.Panel1.Controls.Add(this.BtnAppointmentsForEachConsultant);
            this.splitContainerReportDash.Panel1.Controls.Add(this.BtnNumberOfAppointmentByMonth);
            // 
            // splitContainerReportDash.Panel2
            // 
            this.splitContainerReportDash.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainerReportDash.Size = new System.Drawing.Size(1172, 420);
            this.splitContainerReportDash.SplitterDistance = 390;
            this.splitContainerReportDash.TabIndex = 0;
            // 
            // BtnNumberOfAppointmentByMonth
            // 
            this.BtnNumberOfAppointmentByMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnNumberOfAppointmentByMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BtnNumberOfAppointmentByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNumberOfAppointmentByMonth.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNumberOfAppointmentByMonth.Location = new System.Drawing.Point(-1, -1);
            this.BtnNumberOfAppointmentByMonth.Name = "BtnNumberOfAppointmentByMonth";
            this.BtnNumberOfAppointmentByMonth.Size = new System.Drawing.Size(393, 56);
            this.BtnNumberOfAppointmentByMonth.TabIndex = 0;
            this.BtnNumberOfAppointmentByMonth.Text = "Number of Appointments by Month";
            this.BtnNumberOfAppointmentByMonth.UseVisualStyleBackColor = true;
            this.BtnNumberOfAppointmentByMonth.Click += new System.EventHandler(this.BtnNumberOfAppointmentByMonth_Click);
            // 
            // BtnAppointmentsForEachConsultant
            // 
            this.BtnAppointmentsForEachConsultant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAppointmentsForEachConsultant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BtnAppointmentsForEachConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointmentsForEachConsultant.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppointmentsForEachConsultant.Location = new System.Drawing.Point(-1, 51);
            this.BtnAppointmentsForEachConsultant.Name = "BtnAppointmentsForEachConsultant";
            this.BtnAppointmentsForEachConsultant.Size = new System.Drawing.Size(393, 56);
            this.BtnAppointmentsForEachConsultant.TabIndex = 1;
            this.BtnAppointmentsForEachConsultant.Text = "Appointments Schedule For Each Consultant";
            this.BtnAppointmentsForEachConsultant.UseVisualStyleBackColor = true;
            this.BtnAppointmentsForEachConsultant.Click += new System.EventHandler(this.BtnAppointmentsForEachConsultant_Click);
            // 
            // BtnAllAppointments
            // 
            this.BtnAllAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAllAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BtnAllAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllAppointments.Location = new System.Drawing.Point(-1, 101);
            this.BtnAllAppointments.Name = "BtnAllAppointments";
            this.BtnAllAppointments.Size = new System.Drawing.Size(393, 56);
            this.BtnAllAppointments.TabIndex = 2;
            this.BtnAllAppointments.Text = "All Scheduled Appointments";
            this.BtnAllAppointments.UseVisualStyleBackColor = true;
            this.BtnAllAppointments.Click += new System.EventHandler(this.BtnAllAppointments_Click);
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblReportsTitle.Location = new System.Drawing.Point(12, 9);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(184, 25);
            this.lblReportsTitle.TabIndex = 1;
            this.lblReportsTitle.Text = "Generate a Report";
            // 
            // lblReportsSubTitle
            // 
            this.lblReportsSubTitle.AutoSize = true;
            this.lblReportsSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReportsSubTitle.Location = new System.Drawing.Point(10, 39);
            this.lblReportsSubTitle.Name = "lblReportsSubTitle";
            this.lblReportsSubTitle.Size = new System.Drawing.Size(137, 25);
            this.lblReportsSubTitle.TabIndex = 1;
            this.lblReportsSubTitle.Text = "Public Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item counter";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnBackToHome
            // 
            this.BtnBackToHome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackToHome.FlatAppearance.BorderSize = 0;
            this.BtnBackToHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBackToHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackToHome.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackToHome.Location = new System.Drawing.Point(479, 553);
            this.BtnBackToHome.Name = "BtnBackToHome";
            this.BtnBackToHome.Size = new System.Drawing.Size(217, 50);
            this.BtnBackToHome.TabIndex = 3;
            this.BtnBackToHome.Text = "<  BACK TO HOME";
            this.BtnBackToHome.UseVisualStyleBackColor = false;
            this.BtnBackToHome.Click += new System.EventHandler(this.BtnBackToHome_Click);
            // 
            // FormReportsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.BtnBackToHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReportsSubTitle);
            this.Controls.Add(this.lblReportsTitle);
            this.Controls.Add(this.splitContainerReportDash);
            this.Name = "FormReportsDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportsDashboard";
            this.splitContainerReportDash.Panel1.ResumeLayout(false);
            this.splitContainerReportDash.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReportDash)).EndInit();
            this.splitContainerReportDash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerReportDash;
        private System.Windows.Forms.Button BtnAllAppointments;
        private System.Windows.Forms.Button BtnAppointmentsForEachConsultant;
        private System.Windows.Forms.Button BtnNumberOfAppointmentByMonth;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Label lblReportsSubTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBackToHome;
    }
}