namespace PurpleInvoice.Views
{
    partial class InvoiceReportTab
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
            this.btnShow = new System.Windows.Forms.Button();
            this.invoiceViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.usdRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.invoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.advanced = new System.Windows.Forms.Button();
            this.monthYearPicker = new System.Windows.Forms.DateTimePicker();
            this.dateRangePanel = new System.Windows.Forms.Panel();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.usdRatePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.adjustmentTextBox = new System.Windows.Forms.NumericUpDown();
            this.previousBalanceTextBox = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.invoiceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.invoiceForClientComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dateRangePanel.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.usdRatePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousBalanceTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(3, 151);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // invoiceViewer
            // 
            this.invoiceViewer.ActiveViewIndex = -1;
            this.invoiceViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.invoiceViewer.Location = new System.Drawing.Point(3, 180);
            this.invoiceViewer.Name = "invoiceViewer";
            this.invoiceViewer.Size = new System.Drawing.Size(873, 233);
            this.invoiceViewer.TabIndex = 5;
            // 
            // usdRate
            // 
            this.usdRate.Location = new System.Drawing.Point(68, 3);
            this.usdRate.Name = "usdRate";
            this.usdRate.Size = new System.Drawing.Size(64, 20);
            this.usdRate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "USD Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(118, 418);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 32;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(462, 142);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dateRangePanel);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.invoiceDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Controls.Add(this.advanced);
            this.panel1.Controls.Add(this.monthYearPicker);
            this.panel1.Location = new System.Drawing.Point(9, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 97);
            this.panel1.TabIndex = 9;
            // 
            // invoiceDate
            // 
            this.invoiceDate.Location = new System.Drawing.Point(3, 21);
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.Size = new System.Drawing.Size(198, 20);
            this.invoiceDate.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Advanced";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Invoice Date";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(0, 53);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(83, 13);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "Month and Year";
            // 
            // advanced
            // 
            this.advanced.AutoSize = true;
            this.advanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.advanced.FlatAppearance.BorderSize = 0;
            this.advanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advanced.Image = global::PurpleInvoice.Properties.Resources.collapse_arrow;
            this.advanced.Location = new System.Drawing.Point(178, 64);
            this.advanced.Name = "advanced";
            this.advanced.Size = new System.Drawing.Size(22, 22);
            this.advanced.TabIndex = 7;
            this.advanced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.advanced.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.advanced.UseVisualStyleBackColor = true;
            this.advanced.Click += new System.EventHandler(this.advanced_Click);
            // 
            // monthYearPicker
            // 
            this.monthYearPicker.CustomFormat = "MMMM yyyy";
            this.monthYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthYearPicker.Location = new System.Drawing.Point(3, 69);
            this.monthYearPicker.Name = "monthYearPicker";
            this.monthYearPicker.ShowUpDown = true;
            this.monthYearPicker.Size = new System.Drawing.Size(102, 20);
            this.monthYearPicker.TabIndex = 6;
            this.monthYearPicker.ValueChanged += new System.EventHandler(this.monthYearPicker_ValueChanged);
            // 
            // dateRangePanel
            // 
            this.dateRangePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateRangePanel.Controls.Add(this.endDate);
            this.dateRangePanel.Controls.Add(this.startDate);
            this.dateRangePanel.Controls.Add(this.end);
            this.dateRangePanel.Controls.Add(this.start);
            this.dateRangePanel.Location = new System.Drawing.Point(230, 24);
            this.dateRangePanel.Name = "dateRangePanel";
            this.dateRangePanel.Size = new System.Drawing.Size(215, 89);
            this.dateRangePanel.TabIndex = 5;
            this.dateRangePanel.Visible = false;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(6, 66);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 8;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(8, 16);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(198, 20);
            this.startDate.TabIndex = 7;
            this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(3, 50);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(58, 13);
            this.end.TabIndex = 6;
            this.end.Text = "End Date :";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(5, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(61, 13);
            this.start.TabIndex = 5;
            this.start.Text = "Start Date :";
            // 
            // groupbox2
            // 
            this.groupbox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupbox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupbox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupbox2.Controls.Add(this.usdRatePanel);
            this.groupbox2.Controls.Add(this.panel2);
            this.groupbox2.Controls.Add(this.invoiceTypeComboBox);
            this.groupbox2.Controls.Add(this.label11);
            this.groupbox2.Controls.Add(this.invoiceForClientComboBox);
            this.groupbox2.Controls.Add(this.label12);
            this.groupbox2.Location = new System.Drawing.Point(471, 3);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(402, 153);
            this.groupbox2.TabIndex = 16;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Invoice";
            // 
            // usdRatePanel
            // 
            this.usdRatePanel.Controls.Add(this.usdRate);
            this.usdRatePanel.Controls.Add(this.label3);
            this.usdRatePanel.Location = new System.Drawing.Point(255, 12);
            this.usdRatePanel.Name = "usdRatePanel";
            this.usdRatePanel.Size = new System.Drawing.Size(141, 28);
            this.usdRatePanel.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.adjustmentTextBox);
            this.panel2.Controls.Add(this.previousBalanceTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(6, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 70);
            this.panel2.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Adjustment :";
            // 
            // adjustmentTextBox
            // 
            this.adjustmentTextBox.DecimalPlaces = 2;
            this.adjustmentTextBox.Location = new System.Drawing.Point(101, 37);
            this.adjustmentTextBox.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.adjustmentTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.adjustmentTextBox.Name = "adjustmentTextBox";
            this.adjustmentTextBox.Size = new System.Drawing.Size(206, 20);
            this.adjustmentTextBox.TabIndex = 20;
            this.adjustmentTextBox.ThousandsSeparator = true;
            this.adjustmentTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // previousBalanceTextBox
            // 
            this.previousBalanceTextBox.DecimalPlaces = 2;
            this.previousBalanceTextBox.Location = new System.Drawing.Point(101, 7);
            this.previousBalanceTextBox.Maximum = new decimal(new int[] {
            -402653185,
            -1613725636,
            54210108,
            0});
            this.previousBalanceTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.previousBalanceTextBox.Name = "previousBalanceTextBox";
            this.previousBalanceTextBox.Size = new System.Drawing.Size(206, 20);
            this.previousBalanceTextBox.TabIndex = 21;
            this.previousBalanceTextBox.ThousandsSeparator = true;
            this.previousBalanceTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Previous Balance :";
            // 
            // invoiceTypeComboBox
            // 
            this.invoiceTypeComboBox.FormattingEnabled = true;
            this.invoiceTypeComboBox.Location = new System.Drawing.Point(48, 16);
            this.invoiceTypeComboBox.Name = "invoiceTypeComboBox";
            this.invoiceTypeComboBox.Size = new System.Drawing.Size(135, 21);
            this.invoiceTypeComboBox.TabIndex = 15;
            this.invoiceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.invoiceTypeComboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Client :";
            // 
            // invoiceForClientComboBox
            // 
            this.invoiceForClientComboBox.FormattingEnabled = true;
            this.invoiceForClientComboBox.Location = new System.Drawing.Point(48, 50);
            this.invoiceForClientComboBox.Name = "invoiceForClientComboBox";
            this.invoiceForClientComboBox.Size = new System.Drawing.Size(135, 21);
            this.invoiceForClientComboBox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Type :";
            // 
            // InvoiceReportTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.invoiceViewer);
            this.Controls.Add(this.btnShow);
            this.Name = "InvoiceReportTab";
            this.Size = new System.Drawing.Size(876, 438);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dateRangePanel.ResumeLayout(false);
            this.dateRangePanel.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.usdRatePanel.ResumeLayout(false);
            this.usdRatePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousBalanceTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer invoiceViewer;
        private System.Windows.Forms.TextBox usdRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker invoiceDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button advanced;
        private System.Windows.Forms.DateTimePicker monthYearPicker;
        private System.Windows.Forms.Panel dateRangePanel;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.NumericUpDown previousBalanceTextBox;
        private System.Windows.Forms.NumericUpDown adjustmentTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox invoiceTypeComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox invoiceForClientComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel usdRatePanel;
    }
}
