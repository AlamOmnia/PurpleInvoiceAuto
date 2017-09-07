using System;
using System.Collections.Generic;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using PurpleInvoice.Entities;
using PurpleInvoice.Helpers;
using System.Linq;
using PurpleInvoice.Configuration;

namespace PurpleInvoice
{
    public class InvoiceManager
    {
        InvoiceDataService invoiceDataService;

        Dictionary<string, Invoice> invoices;
        /*Dictionary<string, Invoice> domesticInvoices;
        Dictionary<string, Invoice> internationalIncomingInvoices;
        Dictionary<string, Invoice> internationalOutgoingInvoices;
         */

        // Singleton implementation
        private static InvoiceManager invoiceManager;
        public static InvoiceManager Instance
        {
            get
            {
                if (invoiceManager == null)
                    invoiceManager = new InvoiceManager();
                return invoiceManager;
            }
        }

        private InvoiceManager()
        {
            this.invoiceDataService = new InvoiceDataService();

            invoices = new Dictionary<string, Invoice>();
            /*
            domesticInvoices = new Dictionary<string, Invoice>();
            internationalIncomingInvoices = new Dictionary<string, Invoice>();
            internationalOutgoingInvoices = new Dictionary<string, Invoice>();*/
        }

        public Invoice GetInvoice(DateTime startDate, DateTime endDate, DateTime ans1, DateTime ans2, InvoiceType invoiceType, string clientName, double previousBalance, double adjustment, DateTime invoiceDate, double USDRate = 1)
        {
            Client client = Settings.Clients[clientName];
            int clientId = client.ID;

            DataTable dataTable = new DataTable();

            if (invoiceType == InvoiceType.Domestic)
            {
                //dataTable = invoiceDataService.GetDomesticReportDemoDataTable();
                dataTable = invoiceDataService.GetDomesticReport(startDate, endDate,ans1,ans2, clientId); //GetDomesticReportDemoDataTable();
            }
            else if (invoiceType == InvoiceType.InternationalIncoming)
            {
                //dataTable = invoiceDataService.GetInternationalIncomingReportDemoDataTable();
                dataTable = invoiceDataService.GetInternationalIncomingReport(startDate, endDate,ans1,ans2, clientId);
            }
            else if (invoiceType == InvoiceType.InternationalOutgoing)
            {
                dataTable = invoiceDataService.GetInternationalOutgoingReport(startDate, endDate,ans1,ans2, clientId);
                //dataTable = invoiceDataService.GetInternationalOutgoingReportDemoDataTable();
            }

            List<DailyInvoice> dailyInvoiceList = new List<DailyInvoice>();
            #region Populate dailyInvoiceList from dataTable
            foreach (DataRow dataRow in dataTable.AsEnumerable())
            {
                DailyInvoice dailyInvoice = new DailyInvoice();


                dailyInvoice.CallCount = long.Parse(dataRow["CallCount"].ToString());
                dailyInvoice.ActualDuration = double.Parse(dataRow["ActualDuration"].ToString());
                dailyInvoice.BilledDuration = double.Parse(dataRow["BilledDuration"].ToString());

                dailyInvoice.ClientName = client.Name;
                dailyInvoice.USDRate = USDRate;

                if (invoiceType == InvoiceType.Domestic)
                {
                    dailyInvoice.Date = dataRow["Date"].ToString();
                    dailyInvoice.Rate = Properties.Settings.Default.DomesticRate;
                    //dailyInvoice.AmountSharePercent = 100;
                }
                else if (invoiceType == InvoiceType.InternationalIncoming)
                {
                    dailyInvoice.Date = dataRow["Date"].ToString();
                    dailyInvoice.Rate = Properties.Settings.Default.InternationalIncomingRate;
                    dailyInvoice.AmountSharePercent = Properties.Settings.Default.IncomingSharedRevenuePercent;
                }
                else if (invoiceType == InvoiceType.InternationalOutgoing)
                {
                    dailyInvoice.Rate = Properties.Settings.Default.InternationalOutgoingRate;
                    //dailyInvoice.AmountSharePercent = 100;
                    dailyInvoice.IGW = dataRow["IGW"].ToString();
                    dailyInvoice.SubscriberChargeXBDT = double.Parse(dataRow["SubscriberChargeXBDT"].ToString());
                    dailyInvoice.CarrierCostYUSD = double.Parse(dataRow["CarrierCostYUSD"].ToString());
                    dailyInvoice.AmountSharePercent = Properties.Settings.Default.ICXRevenuePercent;
                }

                dailyInvoiceList.Add(dailyInvoice);
            }

            dataTable.Dispose();
            #endregion

            // Create Invoice with dailyInvoices
            Invoice invoice = new Invoice(invoiceDate, startDate, endDate,ans1,ans2,client, dailyInvoiceList, invoiceType, previousBalance, adjustment, USDRate);

            // Add the invoice to the already calculated invoice list
            // Each client can have maximum of 3 types of invoices. So we have to construct the key with both
            // invoice type & client name.
            invoices[invoiceType + client.Name] = invoice;

            return invoice;
        }

        public DataTable GetInvoiceSummary(DateTime startDate, DateTime endDate, DateTime ans1, DateTime ans2, string type)
        {
            DataTable dataTable = new DataTable();
            if (type.Equals("Domestic"))
            {
                dataTable = invoiceDataService.GetDomesticSummary(startDate, endDate,ans1,ans2);
            }
            else if (type.Equals("Int.Incoming"))
            {
                dataTable = invoiceDataService.GetInternationalIncomingSummary(startDate, endDate,ans1,ans2);
            }
            else if (type.Equals("Int.Outgoing"))
            {
                dataTable = invoiceDataService.GetInternationalOutgoingSummary(startDate, endDate,ans1,ans2);
            }
            return dataTable;
        }

        public InvoiceSummary GetInvoiceSummary(InvoiceType invoiceType, DateTime reportDate)
        {
            List<Invoice> invoiceList = invoices.Select(item => item.Value)  // Select the invoices (Value)
                .Where(invoice => invoice.InvoiceType == invoiceType)   // where each invoie has a matching type of invoice type
                .ToList<Invoice>(); // convert to a list

            InvoiceSummary invoiceSummary = new InvoiceSummary(invoiceType, reportDate, invoiceList);
            return invoiceSummary;
        }
    }
}
