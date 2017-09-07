using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleInvoice.Entities
{
    public class DailyInvoice
    {
        #region Database tables fields
        public string ClientName { get; set; }
        public string Date { get; set; }
        public long CallCount { get; set; }
        public double ActualDuration { get; set; }
        public double BilledDuration { get; set; }
        public double Rate { get; set; }
        #endregion

        #region Domestic & Incoming
        // Percentage of share
        public double AmountSharePercent { get; set; }
        public double USDRate { get; set; }

        public double Amount
        {
            get
            {
                return (BilledDuration * Rate * USDRate) * AmountSharePercent / 100;
            }
            private set
            {
                Amount = value;
            }
        }
        #endregion

        #region outgoing
        public string IGW { get; set; }
        public double SubscriberChargeXBDT { get; set; }
        public double CarrierCostYUSD { get; set; }

        public double CarrierCostYBDT
        {
            get
            {
                return this.CarrierCostYUSD * USDRate;
            }
            private set
            {
                this.CarrierCostYBDT = value;
            }
        }

        public double RevenueZBDT
        {
            get
            {
                return this.SubscriberChargeXBDT -  this.CarrierCostYBDT;
            }

            private set
            {
                this.RevenueZBDT = value;
            }
        }

        public double ICXRevenueZBDT
        {
            get
            {
                return this.RevenueZBDT * (AmountSharePercent / 100);
            }

            private set
            {
                this.ICXRevenueZBDT = value;
            }
        }
        #endregion

        public DailyInvoice()
        {
            // Set default values
            this.AmountSharePercent = 100;
            this.USDRate = 1;
        }
    }
}
