
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
            this.BtnAllAppointments = new System.Windows.Forms.Button();
            this.BtnAppointmentsForEachConsultant = new System.Windows.Forms.Button();
            this.BtnNumberOfAppointmentByMonth = new System.Windows.Forms.Button();
            this.dataGridViewApptsByMonth = new System.Windows.Forms.DataGridView();
            this.dataGridViewConsultantsReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewAllScheduledApptsReport = new System.Windows.Forms.DataGridView();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.lblReportsSubTitle = new System.Windows.Forms.Label();
            this.BtnBackToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReportDash)).BeginInit();
            this.splitContainerReportDash.Panel1.SuspendLayout();
            this.splitContainerReportDash.Panel2.SuspendLayout();
            this.splitContainerReportDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApptsByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultantsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllScheduledApptsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerReportDash
            // 
            this.splitContainerReportDash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerReportDash.Font = new System.Drawing.Font("Myanmar Text", 9.5F);
            this.splitContainerReportDash.Location = new System.Drawing.Point(1, 104);
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
            this.splitContainerReportDash.Panel2.Controls.Add(this.dataGridViewApptsByMonth);
            this.splitContainerReportDash.Panel2.Controls.Add(this.dataGridViewConsultantsReport);
            this.splitContainerReportDash.Panel2.Controls.Add(this.dataGridViewAllScheduledApptsReport);
            this.splitContainerReportDash.Size = new System.Drawing.Size(1321, 420);
            this.splitContainerReportDash.SplitterDistance = 439;
            this.splitContainerReportDash.TabIndex = 0;
            // 
            // BtnAllAppointments
            // 
            this.BtnAllAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAllAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAllAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BtnAllAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllAppointments.Location = new System.Drawing.Point(2, 108);
            this.BtnAllAppointments.Name = "BtnAllAppointments";
            this.BtnAllAppointments.Size = new System.Drawing.Size(432, 56);
            this.BtnAllAppointments.TabIndex = 2;
            this.BtnAllAppointments.Text = "No. of Scheduled Appointments for Each Customer";
            this.BtnAllAppointments.UseVisualStyleBackColor = true;
            this.BtnAllAppointments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnAllAppointments_MouseDown);
            // 
            // BtnAppointmentsForEachConsultant
            // 
            this.BtnAppointmentsForEachConsultant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAppointmentsForEachConsultant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAppointmentsForEachConsultant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BtnAppointmentsForEachConsultant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointmentsForEachConsultant.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAppointmentsForEachConsultant.Location = new System.Drawing.Point(2, 55);
            this.BtnAppointmentsForEachConsultant.Name = "BtnAppointmentsForEachConsultant";
            this.BtnAppointmentsForEachConsultant.Size = new System.Drawing.Size(432, 56);
            this.BtnAppointmentsForEachConsultant.TabIndex = 1;
            this.BtnAppointmentsForEachConsultant.Text = "Appointments Scheduled For Each Consultant";
            this.BtnAppointmentsForEachConsultant.UseVisualStyleBackColor = true;
            this.BtnAppointmentsForEachConsultant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAppointmentsForEachConsultant_MouseClick);
            // 
            // BtnNumberOfAppointmentByMonth
            // 
            this.BtnNumberOfAppointmentByMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNumberOfAppointmentByMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.BtnNumberOfAppointmentByMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.BtnNumberOfAppointmentByMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNumberOfAppointmentByMonth.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNumberOfAppointmentByMonth.Location = new System.Drawing.Point(2, 3);
            this.BtnNumberOfAppointmentByMonth.Name = "BtnNumberOfAppointmentByMonth";
            this.BtnNumberOfAppointmentByMonth.Size = new System.Drawing.Size(432, 56);
            this.BtnNumberOfAppointmentByMonth.TabIndex = 0;
            this.BtnNumberOfAppointmentByMonth.Text = "Number of Appointments by Month";
            this.BtnNumberOfAppointmentByMonth.UseVisualStyleBackColor = true;
            this.BtnNumberOfAppointmentByMonth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnNumberOfAppointmentByMonth_MouseClick);
            // 
            // dataGridViewApptsByMonth
            // 
            this.dataGridViewApptsByMonth.AllowUserToAddRows = false;
            this.dataGridViewApptsByMonth.AllowUserToDeleteRows = false;
            this.dataGridViewApptsByMonth.AllowUserToResizeColumns = false;
            this.dataGridViewApptsByMonth.AllowUserToResizeRows = false;
            this.dataGridViewApptsByMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewApptsByMonth.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewApptsByMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApptsByMonth.GridColor = System.Drawing.Color.LightYellow;
            this.dataGridViewApptsByMonth.Location = new System.Drawing.Point(104, 75);
            this.dataGridViewApptsByMonth.Name = "dataGridViewApptsByMonth";
            this.dataGridViewApptsByMonth.ReadOnly = true;
            this.dataGridViewApptsByMonth.RowHeadersVisible = false;
            this.dataGridViewApptsByMonth.RowHeadersWidth = 51;
            this.dataGridViewApptsByMonth.RowTemplate.Height = 24;
            this.dataGridViewApptsByMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApptsByMonth.Size = new System.Drawing.Size(511, 265);
            this.dataGridViewApptsByMonth.TabIndex = 2;
            // 
            // dataGridViewConsultantsReport
            // 
            this.dataGridViewConsultantsReport.AllowUserToAddRows = false;
            this.dataGridViewConsultantsReport.AllowUserToDeleteRows = false;
            this.dataGridViewConsultantsReport.AllowUserToResizeColumns = false;
            this.dataGridViewConsultantsReport.AllowUserToResizeRows = false;
            this.dataGridViewConsultantsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewConsultantsReport.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridViewConsultantsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultantsReport.GridColor = System.Drawing.Color.LemonChiffon;
            this.dataGridViewConsultantsReport.Location = new System.Drawing.Point(54, 35);
            this.dataGridViewConsultantsReport.Name = "dataGridViewConsultantsReport";
            this.dataGridViewConsultantsReport.ReadOnly = true;
            this.dataGridViewConsultantsReport.RowHeadersVisible = false;
            this.dataGridViewConsultantsReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewConsultantsReport.RowTemplate.Height = 24;
            this.dataGridViewConsultantsReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultantsReport.Size = new System.Drawing.Size(793, 348);
            this.dataGridViewConsultantsReport.TabIndex = 1;
            // 
            // dataGridViewAllScheduledApptsReport
            // 
            this.dataGridViewAllScheduledApptsReport.AllowUserToAddRows = false;
            this.dataGridViewAllScheduledApptsReport.AllowUserToDeleteRows = false;
            this.dataGridViewAllScheduledApptsReport.AllowUserToResizeColumns = false;
            this.dataGridViewAllScheduledApptsReport.AllowUserToResizeRows = false;
            this.dataGridViewAllScheduledApptsReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAllScheduledApptsReport.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewAllScheduledApptsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllScheduledApptsReport.Location = new System.Drawing.Point(34, 19);
            this.dataGridViewAllScheduledApptsReport.Name = "dataGridViewAllScheduledApptsReport";
            this.dataGridViewAllScheduledApptsReport.ReadOnly = true;
            this.dataGridViewAllScheduledApptsReport.RowHeadersVisible = false;
            this.dataGridViewAllScheduledApptsReport.RowHeadersWidth = 51;
            this.dataGridViewAllScheduledApptsReport.RowTemplate.Height = 24;
            this.dataGridViewAllScheduledApptsReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllScheduledApptsReport.Size = new System.Drawing.Size(777, 382);
            this.dataGridViewAllScheduledApptsReport.TabIndex = 0;
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.lblReportsTitle.Location = new System.Drawing.Point(12, 9);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(147, 20);
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
            // BtnBackToHome
            // 
            this.BtnBackToHome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBackToHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackToHome.FlatAppearance.BorderSize = 0;
            this.BtnBackToHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBackToHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackToHome.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackToHome.Location = new System.Drawing.Point(692, 570);
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
            this.ClientSize = new System.Drawing.Size(1366, 652);
            this.Controls.Add(this.BtnBackToHome);
            this.Controls.Add(this.lblReportsSubTitle);
            this.Controls.Add(this.lblReportsTitle);
            this.Controls.Add(this.splitContainerReportDash);
            this.Name = "FormReportsDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportsDashboard";
            this.Load += new System.EventHandler(this.FormReportsDashboard_Load);
            this.splitContainerReportDash.Panel1.ResumeLayout(false);
            this.splitContainerReportDash.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReportDash)).EndInit();
            this.splitContainerReportDash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApptsByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultantsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllScheduledApptsReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerReportDash;
        private System.Windows.Forms.Button BtnAllAppointments;
        private System.Windows.Forms.Button BtnAppointmentsForEachConsultant;
        private System.Windows.Forms.Button BtnNumberOfAppointmentByMonth;
        private System.Windows.Forms.DataGridView dataGridViewAllScheduledApptsReport;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Label lblReportsSubTitle;
        private System.Windows.Forms.Button BtnBackToHome;
        private System.Windows.Forms.DataGridView dataGridViewApptsByMonth;
        private System.Windows.Forms.DataGridView dataGridViewConsultantsReport;
    }
}