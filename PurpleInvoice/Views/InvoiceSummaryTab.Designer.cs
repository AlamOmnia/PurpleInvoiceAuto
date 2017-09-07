namespace PurpleInvoice.Views
{
    partial class InvoiceSummaryTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invoiceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.buttonShowReport = new System.Windows.Forms.Button();
            this.endDateValue = new System.Windows.Forms.DateTimePicker();
            this.startDateValue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 25);
            this.panel1.TabIndex = 29;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(372, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(88, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Invoice Summary";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.reportDateTimePicker);
            this.panel2.Controls.Add(this.invoiceTypeComboBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.buttonSendMail);
            this.panel2.Controls.Add(this.buttonShowReport);
            this.panel2.Controls.Add(this.endDateValue);
            this.panel2.Controls.Add(this.startDateValue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonExport);
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 131);
            this.panel2.TabIndex = 30;
            // 
            // invoiceTypeComboBox
            // 
            this.invoiceTypeComboBox.FormattingEnabled = true;
            this.invoiceTypeComboBox.Location = new System.Drawing.Point(138, 22);
            this.invoiceTypeComboBox.Name = "invoiceTypeComboBox";
            this.invoiceTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.invoiceTypeComboBox.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Type";
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(573, 65);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(109, 32);
            this.buttonSendMail.TabIndex = 35;
            this.buttonSendMail.Text = "Send Mail";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            // 
            // buttonShowReport
            // 
            this.buttonShowReport.Location = new System.Drawing.Point(434, 65);
            this.buttonShowReport.Name = "buttonShowReport";
            this.buttonShowReport.Size = new System.Drawing.Size(119, 32);
            this.buttonShowReport.TabIndex = 34;
            this.buttonShowReport.Text = "Show Report";
            this.buttonShowReport.UseVisualStyleBackColor = true;
            this.buttonShowReport.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // endDateValue
            // 
            this.endDateValue.Location = new System.Drawing.Point(138, 91);
            this.endDateValue.Name = "endDateValue";
            this.endDateValue.Size = new System.Drawing.Size(200, 20);
            this.endDateValue.TabIndex = 33;
            this.endDateValue.Value = new System.DateTime(2016, 7, 19, 0, 0, 0, 0);
            // 
            // startDateValue
            // 
            this.startDateValue.Location = new System.Drawing.Point(138, 57);
            this.startDateValue.Name = "startDateValue";
            this.startDateValue.Size = new System.Drawing.Size(200, 20);
            this.startDateValue.TabIndex = 32;
            this.startDateValue.Value = new System.DateTime(2016, 7, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "End Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Start Date:";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(706, 65);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(119, 32);
            this.buttonExport.TabIndex = 29;
            this.buttonExport.Text = "Export to Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reportViewer);
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 350);
            this.panel3.TabIndex = 31;
            // 
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.Location = new System.Drawing.Point(0, 13);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1076, 336);
            this.reportViewer.TabIndex = 1;
            // 
            // reportDateTimePicker
            // 
            this.reportDateTimePicker.Location = new System.Drawing.Point(434, 19);
            this.reportDateTimePicker.Name = "reportDateTimePicker";
            this.reportDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.reportDateTimePicker.TabIndex = 39;
            this.reportDateTimePicker.Value = new System.DateTime(2016, 7, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Report Date :";
            // 
            // InvoiceSummaryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InvoiceSummaryTab";
            this.Size = new System.Drawing.Size(1082, 424);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Button buttonShowReport;
        private System.Windows.Forms.DateTimePicker endDateValue;
        private System.Windows.Forms.DateTimePicker startDateValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.ComboBox invoiceTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker reportDateTimePicker;

    }
}
