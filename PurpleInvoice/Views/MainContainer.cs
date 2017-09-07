using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PurpleInvoice.Views
{
    public partial class MainContainer : Form
    {
        private InvoiceSummaryTab summaryTab;
        //private BTRCDailyTab dailyTab;
        private InvoiceReportTab invoiceTab;
       // private BTRCMonthlyReportTab btrcMonthlyTab;



        public MainContainer()
        {
            InitializeComponent();
            summaryTab = new InvoiceSummaryTab();
          //  dailyTab = new BTRCDailyTab();
            invoiceTab = new InvoiceReportTab();
            //btrcMonthlyTab = new BTRCMonthlyReportTab();

            DisplayTab(invoiceTab, tabPageReport);
         //   DisplayTab(dailyTab,tabPage1);
            DisplayTab(summaryTab, tabPage2);
          //  DisplayTab(btrcMonthlyTab ,tabPage3);
        }
        private void DisplayTab(UserControl userControl, TabPage tabPage)
        {
            try
            {
                tabPage.Invoke((MethodInvoker)delegate
                {
                    if (!tabPage.Controls.Contains(userControl))
                    {
                        tabPage.Controls.Add(userControl);
                        ResizeTabControl(userControl, tabPage);
                    }
                });
            }
            catch
            {
                if (!tabPage.Controls.Contains(userControl))
                {
                    tabPage.Controls.Add(userControl);
                    ResizeTabControl(userControl, tabPage);
                }
            }

            userControl.Enabled = true;
            userControl.Visible = true;
            userControl.BringToFront();
        }
        public void ResizeTabControl(UserControl userControl, TabPage tabPage)
        {
            int leftPosition = 20;
            int width = tabPageReport.Width - 40;
            /*
            if (userControl == ManualTab)
            {
                userControl.Dock = DockStyle.Top;
                userControl.Location = new Point(leftPosition, 35);
                userControl.Height = 200;
                userControl.Width = width;
            }
            else if (userControl == LogTab)
            {
                userControl.Dock = DockStyle.Fill;
                userControl.Location = new Point(leftPosition, 35);
                userControl.Height = tabLog.Height - tabLogTitle.Height - tabLogTitleUnderline.Height;
                userControl.Width = width;
            }
            else if (userControl == SettingsTab)
            {
                userControl.Dock = DockStyle.Fill;
                userControl.Location = new Point(leftPosition, 35);
            }*/
        }

        #region Draw the Main Tabs
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
        #endregion

        

     
    }
}
