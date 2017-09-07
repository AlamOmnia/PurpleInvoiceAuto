using System;
using System.Data;
using MySql.Data.MySqlClient;
using PurpleInvoice.Helpers;

namespace PurpleInvoice
{
    public class InvoiceDataService
    {
        public InvoiceDataService()
        {
        }

        public DataTable GetDomesticReportDemoDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("CallCount");
            dt.Columns.Add("ActualDuration");
            dt.Columns.Add("BilledDuration");

            #region Psuedo data of April 2016, of Airtel
            dt.Rows.Add(new string[] { "1/4/2016", "795233", "1282925.67", "1288304.88" });
            dt.Rows.Add(new string[] { "2/4/2016", "856581", "1353712.50", "1359495.22" });
            dt.Rows.Add(new string[] { "3/4/2016", "869323", "1344836.44", "1350708.20" });
            dt.Rows.Add(new string[] { "4/4/2016", "905645", "1424130.86", "1430247.57" });
            dt.Rows.Add(new string[] { "5/4/2016", "869944", "1358815.49", "1364690.48" });
            dt.Rows.Add(new string[] { "6/4/2016", "901030", "1396628.37", "1402704.88" });
            dt.Rows.Add(new string[] { "7/4/2016", "840754", "1265665.75", "1271337.40" });
            dt.Rows.Add(new string[] { "8/4/2016", "834284", "1337521.88", "1343173.27" });
            dt.Rows.Add(new string[] { "9/4/2016", "861807", "1344133.37", "1349953.07" });
            dt.Rows.Add(new string[] { "10/4/2016", "915846", "1393028.35", "1399210.90" });
            dt.Rows.Add(new string[] { "11/4/2016", "983851", "1490104.26", "1496739.68" });
            dt.Rows.Add(new string[] { "12/4/2016", "1004578", "1515777.30", "1522547.73" });
            dt.Rows.Add(new string[] { "13/04/2016", "994051", "1437531.71", "1444218.90" });
            dt.Rows.Add(new string[] { "14/04/2016", "1153802", "1824786.05", "1832582.52" });
            dt.Rows.Add(new string[] { "15/04/2016", "930505", "1495921.51", "1502214.63" });
            dt.Rows.Add(new string[] { "16/04/2016", "954080", "1494610.20", "1501051.28" });
            dt.Rows.Add(new string[] { "17/04/2016", "1015530", "1587631.58", "1594485.83" });
            dt.Rows.Add(new string[] { "18/04/2016", "982073", "1556416.24", "1563040.03" });
            dt.Rows.Add(new string[] { "19/04/2016", "1009003", "1631695.63", "1638510.25" });
            dt.Rows.Add(new string[] { "20/04/2016", "965903", "1537347.54", "1543867.23" });
            dt.Rows.Add(new string[] { "21/04/2016", "986677", "1523103.82", "1529751.00" });
            dt.Rows.Add(new string[] { "22/04/2016", "909643", "1493059.11", "1499211.87" });
            dt.Rows.Add(new string[] { "23/04/2016", "944091", "1483639.89", "1490017.97" });
            dt.Rows.Add(new string[] { "24/04/2016", "960410", "1522302.62", "1528782.97" });
            dt.Rows.Add(new string[] { "25/04/2016", "871845", "1385301.31", "1391201.08" });
            dt.Rows.Add(new string[] { "26/04/2016", "814407", "1298305.41", "1303812.55" });
            dt.Rows.Add(new string[] { "27/04/2016", "775999", "1224456.74", "1229694.45" });
            dt.Rows.Add(new string[] { "28/04/2016", "807443", "1219252.89", "1224706.22" });
            dt.Rows.Add(new string[] { "29/04/2016", "732102", "1182243.12", "1187195.92" });
            dt.Rows.Add(new string[] { "30/04/2016", "761012", "1175621.52", "1180761.88" });
            #endregion
            return dt;
        }

        public DataTable GetInternationalIncomingReportDemoDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            dt.Columns.Add("CallCount");
            dt.Columns.Add("ActualDuration");
            dt.Columns.Add("BilledDuration");

            #region Psuedo data of April 2016, of Btrac
            dt.Rows.Add(new string[] { "1/4/2016", "54617", "333267.33", "333621.68" });
            dt.Rows.Add(new string[] { "2/4/2016", "50208", "313964.10", "314293.82" });
            dt.Rows.Add(new string[] { "3/4/2016", "49460", "310055.46", "310379.73" });
            dt.Rows.Add(new string[] { "4/4/2016", "48915", "299016.91", "299337.07" });
            dt.Rows.Add(new string[] { "5/4/2016", "53680", "329509.03", "329861.43" });
            dt.Rows.Add(new string[] { "6/4/2016", "54493", "330913.11", "331271.70" });
            dt.Rows.Add(new string[] { "7/4/2016", "57858", "363600.51", "363981.00" });
            dt.Rows.Add(new string[] { "8/4/2016", "60595", "382554.86", "382950.77" });
            dt.Rows.Add(new string[] { "9/4/2016", "50335", "324988.58", "325319.25" });
            dt.Rows.Add(new string[] { "10/4/2016", "56156", "348190.15", "348557.75" });
            dt.Rows.Add(new string[] { "11/4/2016", "58552", "350227.41", "350610.78" });
            dt.Rows.Add(new string[] { "12/4/2016", "55138", "327498.04", "327859.98" });
            dt.Rows.Add(new string[] { "13/04/2016", "60215", "348141.25", "348537.10" });
            dt.Rows.Add(new string[] { "14/04/2016", "58506", "366467.06", "366852.28" });
            dt.Rows.Add(new string[] { "15/04/2016", "58609", "371090.02", "371476.60" });
            dt.Rows.Add(new string[] { "16/04/2016", "52150", "329842.75", "330185.57" });
            dt.Rows.Add(new string[] { "17/04/2016", "56857", "358794.43", "359168.72" });
            dt.Rows.Add(new string[] { "18/04/2016", "49790", "311191.31", "311517.07" });
            dt.Rows.Add(new string[] { "19/04/2016", "46208", "286074.74", "286377.10" });
            dt.Rows.Add(new string[] { "20/04/2016", "43714", "275945.18", "276232.07" });
            dt.Rows.Add(new string[] { "21/04/2016", "43330", "276607.24", "276890.03" });
            dt.Rows.Add(new string[] { "22/04/2016", "51362", "324488.99", "324826.23" });
            dt.Rows.Add(new string[] { "23/04/2016", "48318", "296984.02", "297301.30" });
            dt.Rows.Add(new string[] { "24/04/2016", "57010", "362415.52", "362788.80" });
            dt.Rows.Add(new string[] { "25/04/2016", "53703", "334407.05", "334759.17" });
            dt.Rows.Add(new string[] { "26/04/2016", "55422", "349162.57", "349526.20" });
            dt.Rows.Add(new string[] { "27/04/2016", "57709", "363457.87", "363836.70" });
            dt.Rows.Add(new string[] { "28/04/2016", "55363", "340524.35", "340888.08" });
            dt.Rows.Add(new string[] { "29/04/2016", "62021", "383215.66", "383623.00" });
            dt.Rows.Add(new string[] { "30/04/2016", "56086", "359490.64", "359857.38" });

            #endregion
            return dt;
        }

        public DataTable GetInternationalOutgoingReportDemoDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IGW");
            dt.Columns.Add("CallCount");
            dt.Columns.Add("ActualDuration");
            dt.Columns.Add("BilledDuration");
            dt.Columns.Add("SubscriberChargeXBDT");
            dt.Columns.Add("CarrierCostYUSD");

            #region Psuedo of Blink
            dt.Rows.Add(new string[] { "Btrac", "27625", "16459.92", "20953.75", "276883", "2628.23026" });
            dt.Rows.Add(new string[] { "DIGICON", "12864", "12114.4", "14251.5", "180886.5", "1566.064" });
            dt.Rows.Add(new string[] { "GVTEL", "15234", "9936.39", "12412.5", "161294.5", "1390.92598" });
            dt.Rows.Add(new string[] { "MIR", "12471", "13930.27", "15948.75", "210090.25", "1859.71162" });
            dt.Rows.Add(new string[] { "Novotel", "32696", "15041.64", "20545.5", "280963.75", "2618.36209" });
            dt.Rows.Add(new string[] { "Roots", "32403", "14597.9", "20173.5", "274101", "2388.09531" });
            dt.Rows.Add(new string[] { "Unique", "30576", "16096.24", "21271.5", "303623.5", "2788.06792" });

            #endregion
            return dt;
        }

        public DataTable GetDomesticReport(DateTime startDate, DateTime endDate, DateTime ans1, DateTime ans2, int clientId)
        {
            string start = startDate.ToString("yyyy-MM-dd");
            string end = endDate.ToString("yyyy-MM-dd");
            string ans1Date = ans1.ToString("yyyy-MM-dd");
            string ans2Date = ans2.ToString("yyyy-MM-dd");
            return GetInvoiceReport(Properties.Resources.DomesticInvoice, start, end, ans1Date, ans2Date, clientId);
        }

        public DataTable GetInternationalIncomingReport(DateTime startDate, DateTime endDate,DateTime ans1, DateTime ans2, int clientId)
        {
            string start = startDate.ToString("yyyy-MM-dd");
            string end = endDate.ToString("yyyy-MM-dd");
            string ans1Date = ans1.ToString("yyyy-MM-dd");
            string ans2Date = ans2.ToString("yyyy-MM-dd");
            return GetInvoiceReport(Properties.Resources.InternationalIncomingInvoice, start, end, ans1Date, ans2Date, clientId);
        }

        public DataTable GetInternationalOutgoingReport(DateTime startDate, DateTime endDate, DateTime ans1, DateTime ans2, int clientId)
        {
            string start = startDate.ToString("yyyy-MM-dd");
            string end = endDate.ToString("yyyy-MM-dd");
            string ans1Date = ans1.ToString("yyyy-MM-dd");
            string ans2Date = ans2.ToString("yyyy-MM-dd");
            return GetInvoiceReport(Properties.Resources.InternationalOutgoingInvoice, start, end, ans1Date, ans2Date, clientId);
        }

        public DataTable GetDomesticSummary(DateTime startDate, DateTime endDate, DateTime ans1, DateTime ans2)
        {
            string start = startDate.ToString("yyyy-MM-dd");
            string end = endDate.ToString("yyyy-MM-dd");
            string ans1Date = ans1.ToString("yyyy-MM-dd");
            string ans2Date = ans2.ToString("yyyy-MM-dd");
            return GetInvoiceSummary(Properties.Resources.DomesticSummary, start, end, ans1Date, ans2Date);
        }

        public DataTable GetInternationalIncomingSummary(DateTime startDate, DateTime endDate, DateTime ans1, DateTime ans2)
        {
            string start = startDate.ToString("yyyy-MM-dd");
            string end = endDate.ToString("yyyy-MM-dd");
            string ans1Date = ans1.ToString("yyyy-MM-dd");
            string ans2Date = ans2.ToString("yyyy-MM-dd");
            return GetInvoiceSummary(Properties.Resources.InernationalIncomingSummary, start, end,ans1Date, ans2Date);
        }

        public DataTable GetInternationalOutgoingSummary(DateTime startDate, DateTime endDate, DateTime ans1, DateTime ans2)
        {
            string start = startDate.ToString("yyyy-MM-dd");
            string end = endDate.ToString("yyyy-MM-dd");
            string ans1Date = ans1.ToString("yyyy-MM-dd");
            string ans2Date = ans2.ToString("yyyy-MM-dd");
            return GetInvoiceSummary(Properties.Resources.InternationalOutgoingSummary, start, end, ans1Date, ans2Date);
        }

        private DataTable GetInvoiceReport(string sql, string startDate, string endDate, string ans1Date, string ans2Date, int clientId)
        {
            // Open connection to the database
            DatabaseHelper.Instance.OpenConnection();

            var dataTable = new DataTable();
            MySqlCommand command = DatabaseHelper.Instance.CreateCommand();

            command.CommandText = sql;
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@ans1Date", ans1Date);
            command.Parameters.AddWithValue("@ans2Date", ans2Date);
            command.Parameters.AddWithValue("@ClientID", clientId);

            using (var dataReader = command.ExecuteReader())
            {
                dataTable.Load(dataReader);
            }

            // Close the connection after finish using
            DatabaseHelper.Instance.CloseConnection();

            return dataTable;
        }

        private DataTable GetInvoiceSummary(string sql, string startDate, string endDate, string ans1Date, string ans2Date)
        {
            // Open connection to the database
            DatabaseHelper.Instance.OpenConnection();

            var dataTable = new DataTable();
            MySqlCommand command = DatabaseHelper.Instance.CreateCommand();

            command.CommandText = sql;
            command.Parameters.AddWithValue("@startTime", startDate);
            command.Parameters.AddWithValue("@endTime", endDate);
            command.Parameters.AddWithValue("@ans1Date", ans1Date);
            command.Parameters.AddWithValue("@ans2Date", ans2Date);

            using (var dataReader = command.ExecuteReader())
            {
                dataTable.Load(dataReader);
            }

            // Close the connection after finish using
            DatabaseHelper.Instance.CloseConnection();

            return dataTable;
        }
    }
}
