using System;
using System.Windows.Forms;
using PurpleInvoice.Configuration;
using PurpleInvoice.Entities;
using System.Linq;

namespace PurpleInvoice.Views
{
    public partial class InvoiceReportTab : UserControl
    {
        //private BackgroundWorker backgroundWorker;
        public InvoiceReportTab()
        {
            InitializeComponent();
            #region UI related Initialization
            #region set values of Invoice Type ComboBox
            // Text will be used for displaying purpose whereas Value will be used for all other purpose
            this.invoiceTypeComboBox.DisplayMember = "Text";
            this.invoiceTypeComboBox.ValueMember = "Value";
            this.invoiceTypeComboBox.Items.AddRange
                       (
                        new object[] 
                        {
                            new { Text = "Domestic", Value = InvoiceType.Domestic},
                            new { Text = "International Incoming", Value = InvoiceType.InternationalIncoming},
                            new { Text = "International Outgoing", Value = InvoiceType.InternationalOutgoing},
                            }
                       );

            this.invoiceTypeComboBox.SelectedIndex = 0;        // Set to the first item. This will also cause update of client combobx
            #endregion
            #region Set Month picker default value to the previous month
             this.monthYearPicker.Value = this.monthYearPicker.Value.AddMonths(-1);   // subtract 1 month from the current (now) value
            #endregion
        }

        private void InvoiceReportTab_Load(object sender, System.EventArgs e)
        {
            // Start the BackgroundWorker.
            //backgroundWorker1.RunWorkerAsync();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Get user inputs
            DateTime invoiceDate = this.invoiceDate.Value;
            DateTime start = startDate.Value.AddHours(-2);
            DateTime end = endDate.Value.AddHours(5);
            DateTime ans1 = startDate.Value;
            DateTime ans2 = endDate.Value;
            InvoiceType invoiceType = (this.invoiceTypeComboBox.SelectedItem as dynamic).Value;
            string clientName = this.invoiceForClientComboBox.SelectedItem.ToString();

            // Display a popup message if previous balance or adjustment is not given.
            if (string.IsNullOrWhiteSpace(previousBalanceTextBox.Text) || string.IsNullOrWhiteSpace(adjustmentTextBox.Text))
            {
                MessageBox.Show(this, "Previous Balance or Adjustment cannot be empty.");
            }
            else
            {
                double previousBalance = double.Parse(previousBalanceTextBox.Text);
                double adjustment = double.Parse(adjustmentTextBox.Text);
                double USDRate = 1;

                if (invoiceType == InvoiceType.InternationalIncoming || invoiceType == InvoiceType.InternationalOutgoing)
                {

                    if (string.IsNullOrWhiteSpace(this.usdRate.Text))
                    {
                        MessageBox.Show(this, "USD Rate cannot be empty.");
                    }
                    else
                    {
                        USDRate = double.Parse(this.usdRate.Text);
                    }
                    // TODO SHOW popup
                }

                // Prepare Invoice
                Invoice invoice = InvoiceManager.Instance.GetInvoice(start, end,ans1,ans2, invoiceType, clientName, previousBalance, adjustment, invoiceDate, USDRate);
                invoiceViewer.ReportSource = invoice.PrintInvoice();
            }
        }

        private void genarateInvoice()
        {/*
            status.Text = "";
            invoiceManager = new InvoiceManager();
            int USDRate = 0;
            DateTime start = startDate.Value;
            DateTime end = endDate.Value;
            string customerName = invoiceFor.SelectedItem.ToString();
            string type = invoiceType.SelectedItem.ToString();
            if (type.Equals("Domestic"))
            {
                USDRate = 0;
            }
            else
            {
                USDRate = Int32.Parse(usdRate.Text);
            }

            Cursor.Current = Cursors.WaitCursor;
            status.Text = "Query is Running and Getting data from query....";
            DataTable dt = invoiceManager.get_Report_Data(start, end, type, customerName, USDRate);
            status.Text = "Loading Data from query.....";
            ReportDocument rd = invoiceManager.printReport(start, end, dt, customerName, type, USDRate);
            invoiceViewer.ReportSource = rd;
            //  printReport (dt);
            */
        }

        private void addInvoiceInfoTODB()
        {

        }

        private void advanced_Click(object sender, EventArgs e)
        {
            //this.splitContainer.Panel2Collapsed = !this.splitContainer.Panel2Collapsed;
            this.dateRangePanel.Visible = !this.dateRangePanel.Visible;
            this.monthYearPicker.Enabled = !this.monthYearPicker.Enabled;
        }

        /// <summary>
        /// Called when invoice type changed. Changing the invoice type to 
        /// 1. Domestic :  Will hide the USD rate, show only the ANS in the client selection box
        /// 2. International Incoming: will display the incoming USD rate, show only the IOS in the client box
        /// 3. International outgoing: will display the outgoing USD rate, show only the ANS clients
        /// the client dropbox. For domestic 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invoiceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the selected invoice type's value property cause the text is not same as the value
            InvoiceType invoiceType = (this.invoiceTypeComboBox.SelectedItem as dynamic).Value;

            if (invoiceType == InvoiceType.Domestic)
            {
                // Hide usd rate if not already hidden
                if (this.usdRatePanel.Visible)
                {
                    this.usdRatePanel.Visible = false;
                }

                string[] ansClientsName = Settings.Clients
                                           .Where(item => item.Value.ClientType == ClientType.ANS) // Select ANS clients
                                           .Select(item => item.Value.DisplayName).ToArray<string>(); // Select all ans clients' display name

                PopulateClientComboBox(ansClientsName);
            }
            else if (invoiceType == InvoiceType.InternationalIncoming)
            {
                // USD rate value to incoming usd rate
                this.usdRate.Text = Properties.Settings.Default.USDRateIncoming.ToString();

                // Display usd rate if not visible
                if (!this.usdRatePanel.Visible)
                {

                    this.usdRatePanel.Visible = true;
                }

                string[] iosClientsName = Settings.Clients
                                           .Where(item => item.Value.ClientType == ClientType.IOS) // Select ANS clients
                                           .Select(item => item.Value.DisplayName).ToArray<string>(); // Select all ans clients' display name

                PopulateClientComboBox(iosClientsName);
            }
            else if (invoiceType == InvoiceType.InternationalOutgoing)
            {
                // // USD rate value to outgoing usd rate
                this.usdRate.Text = Properties.Settings.Default.USDRateOutgoing.ToString();

                // Display usd rate if not visible
                if (!this.usdRatePanel.Visible)
                {
                    this.usdRatePanel.Visible = true;
                }

                string[] ansClientsName = Settings.Clients
                                          .Where(item => item.Value.ClientType == ClientType.ANS) // Select ANS clients
                                          .Select(item => item.Value.DisplayName).ToArray<string>(); // Select all ans clients' display name

                PopulateClientComboBox(ansClientsName);
            }
        }

        private void PopulateClientComboBox(string[] items)
        {
            #region set values of Invoice For ComboBox
            this.invoiceForClientComboBox.Items.Clear();    // Clear all the items from the combobox
            this.invoiceForClientComboBox.Items.AddRange(items); // Each items value is a client and Select the DisplayNames as an array.
            #endregion

            this.invoiceForClientComboBox.SelectedIndex = 0;

            #endregion
        }

        /// <summary>
        /// Called when month or year is changed.
        /// Sets the start date and end date pickers default value to the start day and end day of this month
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthYearPicker_ValueChanged(object sender, EventArgs e)
        {
            this.startDate.Value = new DateTime(this.monthYearPicker.Value.Year,
                                                this.monthYearPicker.Value.Month,
                                                1); // start day is 1

            // For end date, the last day of the month should be selected
            this.endDate.Value = new DateTime(this.monthYearPicker.Value.Year,
                                              this.monthYearPicker.Value.Month,
                                              DateTime.DaysInMonth(this.monthYearPicker.Value.Year, this.monthYearPicker.Value.Month)).AddDays(1);
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}



