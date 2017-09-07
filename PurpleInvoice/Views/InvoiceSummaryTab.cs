using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using PurpleInvoice.Configuration;
using PurpleInvoice.Entities;

namespace PurpleInvoice.Views
{
    public partial class InvoiceSummaryTab : UserControl
    {
        //InvoiceSummeryManager invoiceSummery;
        //InvoiceManager invoiceManager;

        public InvoiceSummaryTab()
        {
            InitializeComponent();
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

            #endregion
            this.invoiceTypeComboBox.SelectedIndex = 0; // set domestic as default
            //invoiceManager = new InvoiceManager();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            // Get user inputs
            DateTime start = startDateValue.Value;
            DateTime end = endDateValue.Value;
            DateTime reportDate = reportDateTimePicker.Value;
            InvoiceType invoiceType = (this.invoiceTypeComboBox.SelectedItem as dynamic).Value;

            InvoiceSummary invoiceSummary = InvoiceManager.Instance.GetInvoiceSummary(invoiceType, reportDate);
            reportViewer.ReportSource = invoiceSummary.Print();
        }
    }
}
