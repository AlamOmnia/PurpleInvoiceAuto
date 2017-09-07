using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using PurpleInvoice.Configuration;

namespace PurpleInvoice.Entities
{
    public class InvoiceSummary
    {
        public List<Invoice> InvoiceList { get; protected set; }
        protected ReportDocument reportDocument;
        protected InvoiceReportDocument invoiceReportDocument;
        public InvoiceType InvoiceType { get; private set; }

        public DateTime Date;

        #region Calculated properties
        #region Common
        public long GrandTotalCallCount
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalCallCount);
            }
        }

        public double GrandTotalActualDuration
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalActualDuration);
            }
        }

        public double GrandTotalBilledDuration
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalBilledDuration);
            }
        }
        #endregion
        public double GrandTotalAmount
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalAmountRounded);
            }
        }

        public double GrandTotalVat
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalVatRounded);
            }
        }

        public double GrandTotalIncludingVat
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalIncludingVatRounded);
            }
        }

        #region outgoing
        public double GrandTotalSubscriberChargeXBDT
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalSubscriberChargeXBDTRounded);
            }
        }
        public double GrandTotalCarrierCostYUSD
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalCarrierCostYUSDRounded);
            }
        }
        public double GrandTotalCarrierCostYBDT
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalCarrierCostYBDTRounded);
            }
        }
        public double GrandTotalRevenueZBDT
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalRevenueZBDTRounded);
            }
        }
        public double GrandTotalICXRevenueZBDT
        {
            get
            {
                return this.InvoiceList.Sum(invoice => invoice.TotalAmountRounded);
            }
        }
        #endregion
        #endregion

        public InvoiceSummary()
        {

        }
        public InvoiceSummary(InvoiceType invoiceType, DateTime date, List<Invoice> invoiceList)
        {
            this.InvoiceType = invoiceType;
            this.Date = date;
            this.InvoiceList = invoiceList;

            this.invoiceReportDocument = new InvoiceReportDocument();
            this.reportDocument = new ReportDocument();
        }

        public void GenerateSummaryInDB()
        {
            //create invoice in DB with required parameters
        }

        public void GeneratePDF()
        {

        }

        public ReportDocument Print()
        {
            this.reportDocument = invoiceReportDocument.GetSummaryReportDocument(this);
            return this.reportDocument;
        }

    }
}
