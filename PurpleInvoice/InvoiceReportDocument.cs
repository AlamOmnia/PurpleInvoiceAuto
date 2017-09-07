using System;
using System.Collections.Generic;
using CrystalDecisions.CrystalReports.Engine;
using PurpleInvoice.Configuration;
using PurpleInvoice.Entities;
using PurpleInvoice.Reports;

namespace PurpleInvoice
{
    public class InvoiceReportDocument
    {
        public InvoiceReportDocument()
        {
        }

        public ReportDocument GetSummaryReportDocument(InvoiceSummary invoiceSummary)
        {
            ReportDocument rd = new ReportDocument();

            if (invoiceSummary.InvoiceType == Configuration.InvoiceType.Domestic)
            {
                rd = new DomesticSummaryReport();
            }
            else if (invoiceSummary.InvoiceType == Configuration.InvoiceType.InternationalIncoming)
            {
                rd = new InternationalIncomingSummaryReport();
            }
            else if (invoiceSummary.InvoiceType == Configuration.InvoiceType.InternationalOutgoing)
            {
                rd = new InternationalOutgoingSummaryReport();
            }

            rd.SetDataSource(invoiceSummary.InvoiceList);

            // Add value for common parameters
            rd.SetParameterValue("@Date", invoiceSummary.Date.ToString("MMMM dd, yyyy"));
            rd.SetParameterValue("@GrandTotalCallCount", invoiceSummary.GrandTotalCallCount);
            rd.SetParameterValue("@GrandTotalActualDuration", invoiceSummary.GrandTotalActualDuration);
            rd.SetParameterValue("@GrandTotalBilledDuration", invoiceSummary.GrandTotalBilledDuration);


            // Set different types of values for different types of invoice
            if (invoiceSummary.InvoiceType == Configuration.InvoiceType.Domestic)
            {
                rd.SetParameterValue("@GrandTotalAmount", invoiceSummary.GrandTotalAmount);
                rd.SetParameterValue("@GrandTotalVat", invoiceSummary.GrandTotalVat);
                rd.SetParameterValue("@GrandTotalIncludingVat", invoiceSummary.GrandTotalIncludingVat);
            }
            else if (invoiceSummary.InvoiceType == Configuration.InvoiceType.InternationalIncoming)
            {
                rd.SetParameterValue("@GrandTotalAmount", invoiceSummary.GrandTotalAmount);
            }
            else if (invoiceSummary.InvoiceType == Configuration.InvoiceType.InternationalOutgoing)
            {
                rd.SetParameterValue("@GrandTotalSubscriberChargeXBDT", invoiceSummary.GrandTotalSubscriberChargeXBDT);
                rd.SetParameterValue("@GrandTotalCarrierCostYUSD", invoiceSummary.GrandTotalCarrierCostYUSD);
                rd.SetParameterValue("@GrandTotalCarrierCostYBDT", invoiceSummary.GrandTotalCarrierCostYBDT);
                rd.SetParameterValue("@GrandTotalRevenueZBDT", invoiceSummary.GrandTotalRevenueZBDT);
                rd.SetParameterValue("@GrandTotalICXRevenueZBDT", invoiceSummary.GrandTotalICXRevenueZBDT);
            }

            return rd;
        }

        public ReportDocument GetReportDocument(Invoice invoice)
        {
            ReportDocument rd = new ReportDocument();

            if (invoice.InvoiceType == Configuration.InvoiceType.Domestic)
            {
                rd = new DomesticReport();
            }
            else if (invoice.InvoiceType == Configuration.InvoiceType.InternationalIncoming)
            {
                rd = new InternationalIncomingReport();
            }
            else if (invoice.InvoiceType == Configuration.InvoiceType.InternationalOutgoing)
            {
                rd = new InternationalOutgoingReport();
            }

            // Add value for common parameters
            rd.SetDataSource(invoice.DailyInvoiceList);

            rd.SetParameterValue("@InvoiceDate", invoice.InvoiceDate.ToString("MMMM dd, yyyy"));
            rd.SetParameterValue("@rptMonthYear", invoice.StartDate.AddDays(+1).ToString("MMMM, yyyy"));
            rd.SetParameterValue("@refNoYear", invoice.StartDate.AddDays(+1).ToString("yyyy"));
            rd.SetParameterValue("@refNoMonth", invoice.StartDate.AddDays(+1).ToString("MM"));

            rd.SetParameterValue("@ClientFullName", invoice.Client.FullName);
            rd.SetParameterValue("@clientAddress", invoice.Client.Address);
            rd.SetParameterValue("@WhomToAttention", invoice.Client.WhomToAttention);
            rd.SetParameterValue("@vatRegNo", invoice.Client.VatRegNo);
            
            // Add calculated values
            rd.SetParameterValue("@PreviousBalance", invoice.PreviousBalance);
            rd.SetParameterValue("@Adjustment", invoice.Adjustment);
            rd.SetParameterValue("@TotalCallCount", invoice.TotalCallCount);
            rd.SetParameterValue("@TotalActualDuration", invoice.TotalActualDuration);
            rd.SetParameterValue("@TotalBilledDuration", invoice.TotalBilledDuration);

            rd.SetParameterValue("@TotalAmount", invoice.TotalAmount);
            rd.SetParameterValue("@TotalAmountRounded", invoice.TotalAmountRounded);
            rd.SetParameterValue("@TotalBalanceRounded", invoice.TotalBalanceRounded);
            rd.SetParameterValue("@NetBalanceRounded", invoice.NetBalanceRounded);


            // Set different types of values for different types of invoice
            if (invoice.InvoiceType == Configuration.InvoiceType.Domestic)
            {
                rd.SetParameterValue("@RefNo", "ANS");
                rd.SetParameterValue("@TotalVatRounded", invoice.TotalVatRounded);
                rd.SetParameterValue("@TotalIncludingVatRounded", invoice.TotalIncludingVatRounded);
                rd.SetParameterValue("@ClientRef", invoice.Client.ClientRef);
                rd.SetParameterValue("@client", invoice.Client.DisplayName);
            }
            else if (invoice.InvoiceType == Configuration.InvoiceType.InternationalIncoming)
            {
                rd.SetParameterValue("@RefNo", invoice.Client.RefNo);
                // rd.SetParameterValue("@client", invoice.Client.Name);
                rd.SetParameterValue("@USDRate", invoice.USDRate);
            }
            else if (invoice.InvoiceType == Configuration.InvoiceType.InternationalOutgoing)
            {
                rd.SetParameterValue("@RefNo", "OUT ANS");
                rd.SetParameterValue("@TotalSubscriberChargeXBDT", invoice.TotalSubscriberChargeXBDT);
                rd.SetParameterValue("@TotalCarrierCostYUSD", invoice.TotalCarrierCostYUSD);
                rd.SetParameterValue("@TotalCarrierCostYBDT", invoice.TotalCarrierCostYBDT);
                rd.SetParameterValue("@TotalRevenueZBDT", invoice.TotalRevenueZBDT);
                rd.SetParameterValue("@client", invoice.Client.DisplayName);
                rd.SetParameterValue("@USDRate", invoice.USDRate);
                rd.SetParameterValue("@ClientRef", invoice.Client.ClientRef);
            }

            return rd;
        }
    }
}
