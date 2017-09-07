using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using PurpleInvoice.Configuration;
using PurpleInvoice.Reports;

namespace PurpleInvoice.Entities
{
    public class Invoice
    {
        public ReportDocument ReportDocument { get; set; }
        public Client Client { get; private set; }
        public List<DailyInvoice> DailyInvoiceList { get; private set; }
        public InvoiceType InvoiceType { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ans1 { get; set; }
        public DateTime ans2 { get; set; }

        #region Fields for reports
        public long TotalCallCount
        {
            get
            {
                // Pres CTRL + D as often as possible to format code
                return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.CallCount);
            }
            private set
            {
                TotalCallCount = value;
            }
        }

        public double TotalActualDuration
        {
            get
            {
                return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.ActualDuration);
            }
            private set
            {
                TotalActualDuration = value;
            }
        }
        public double TotalBilledDuration
        {
            get
            {
                return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.BilledDuration);
            }
            private set
            {
                TotalBilledDuration = value;
            }
        }

        #region Calculated invoice fields
        #region Total Amount
        public double TotalAmount
        {
            get
            {
                if (this.InvoiceType == InvoiceType.InternationalOutgoing)
                    return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.ICXRevenueZBDT);
                else
                    return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.Amount);
            }
            private set
            {
                TotalAmount = value;
            }
        }

        public double TotalAmountRounded
        {
            get
            {
                return Math.Round(this.TotalAmount);
            }
            private set
            {
                TotalAmountRounded = value;
            }
        }
        #endregion

        public double TotalIncludingVatRounded
        {
            get
            {
                return Math.Round(TotalAmountRounded + TotalVatRounded);
            }
            private set
            {
                TotalIncludingVatRounded = value;
            }
        }
        #endregion

        #region Total Balance
        public double TotalBalance
        {
            get
            {
                return TotalIncludingVat + PreviousBalance;
            }
            private set
            {
                TotalBalance = value;
            }
        }

        public double TotalBalanceRounded
        {
            get
            {
                return Math.Round(TotalIncludingVatRounded + PreviousBalance);
            }
            private set
            {
                TotalBalanceRounded = value;
            }
        }
        #endregion

        #region Net Balance
        public double NetBalance
        {
            get
            {
                return TotalBalance - Adjustment;
            }
            private set
            {
                NetBalance = value;
            }
        }

        public double NetBalanceRounded
        {
            get
            {
                return Math.Round(TotalBalanceRounded - Adjustment);
            }
            private set
            {
                NetBalanceRounded = value;
            }
        }
        #endregion

        #region Total Vat
        public double TotalVat
        {
            get
            {
                if (this.InvoiceType == InvoiceType.Domestic)
                    return TotalAmount * Properties.Settings.Default.VatPercent / 100;
                else
                    return 0;
            }
            private set
            {
                TotalVat = value;
            }
        }

        public double TotalVatRounded
        {
            get
            {
                if (this.InvoiceType == InvoiceType.Domestic)
                    return Math.Round(TotalAmountRounded * Properties.Settings.Default.VatPercent / 100);
                else
                    return 0;
            }
            private set
            {
                TotalVatRounded = value;
            }
        }
        #endregion

        #region Total with Vat
        public double TotalIncludingVat
        {
            get
            {
                return TotalAmount + TotalVat;
            }
            private set
            {
                TotalIncludingVat = value;
            }
        }

        #endregion

        #region Outgoing
        #region Total SubscriberChargeXBDT
        public double TotalSubscriberChargeXBDT
        {
            get
            {
                return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.SubscriberChargeXBDT);
            }
            private set
            {
                this.TotalSubscriberChargeXBDT = value;
            }
        }

        public double TotalSubscriberChargeXBDTRounded
        {
            get
            {
                return Math.Round(this.TotalSubscriberChargeXBDT);
            }
            private set
            {
                this.TotalSubscriberChargeXBDTRounded = value;
            }
        }
        #endregion

        #region Total CarrierCostYUSD
        public double TotalCarrierCostYUSD
        {
            get
            {
                return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.CarrierCostYUSD);
            }
            private set
            {
                this.TotalCarrierCostYUSD = value;
            }
        }

        public double TotalCarrierCostYUSDRounded
        {
            get
            {
                return Math.Round(this.TotalCarrierCostYUSD);
            }
            private set
            {
                this.TotalCarrierCostYUSDRounded = value;
            }
        }
        #endregion

        #region Total CarrierCostYBDT
        public double TotalCarrierCostYBDT
        {
            get
            {
                return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.CarrierCostYBDT);
            }
            private set
            {
                this.TotalCarrierCostYBDT = value;
            }
        }

        public double TotalCarrierCostYBDTRounded
        {
            get
            {
                return Math.Round(this.TotalCarrierCostYBDT);
            }
            private set
            {
                this.TotalCarrierCostYBDTRounded = value;
            }
        }
        #endregion
        #region Total RevenueZBDT
        public double TotalRevenueZBDT
        {
            get
            {
                return DailyInvoiceList.Sum(dailyInvoice => dailyInvoice.RevenueZBDT);
            }
            private set
            {
                this.TotalRevenueZBDT = value;
            }
        }

        public double TotalRevenueZBDTRounded
        {
            get
            {
                return Math.Round(this.TotalRevenueZBDT);
            }
            private set
            {
                this.TotalRevenueZBDTRounded = value;
            }
        }
        #endregion
        #endregion

        public double PreviousBalance { get; private set; }
        public double Adjustment { get; private set; }

        public double USDRate { get; private set; }

        #endregion

        public string ClientName
        {
            get
            {
                return this.Client.DisplayName;
            }
        }

        public Invoice()
        {

        }
        public Invoice(DateTime invoiceDate, DateTime startDate, DateTime endDate,DateTime ans1,DateTime ans2, Client client, List<DailyInvoice> dailyInvoiceList, InvoiceType invoiceType, double previousBalance, double adjustment, double USDRate)
        {
            this.Client = client;
            this.DailyInvoiceList = dailyInvoiceList;
            this.InvoiceType = invoiceType;
            this.PreviousBalance = previousBalance;
            this.Adjustment = adjustment;
            this.InvoiceDate = invoiceDate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.USDRate = USDRate;
        }

        public void GenerateInvoice()
        {
            //create invoice in DB with required parameters
        }

        public void GeneratePDF()
        {

        }

        public ReportDocument PrintInvoice()
        {
            InvoiceReportDocument invoiceReportDocument = new InvoiceReportDocument();
            this.ReportDocument = invoiceReportDocument.GetReportDocument(this);
            return this.ReportDocument;
        }
    }
}
