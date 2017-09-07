using System.Collections.Generic;
using PurpleInvoice.Entities;
using PurpleInvoice.Helpers;
using System.Windows.Forms;
using PurpleInvoice.Views;
using System;

namespace PurpleInvoice
{
    class PurpleInvoiceApp
    {
        //Client[] clients;

        public PurpleInvoiceApp()
        {
            //this.clients = XmlHelper.Instance.GetDeserializedObject<Client[]>(Properties.Settings.Default.ClientProfilesFilePath);
        }

        public void Start()
        {
            MainContainer mainContainer = null;

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                mainContainer = new MainContainer();
                Application.Run(mainContainer);
            /*}
            //catch (Exception ex)
           // {
                if (mainContainer != null & !mainContainer.IsDisposed)
                    MessageBox.Show(mainContainer, ex.ToString());
                Console.WriteLine(ex.ToString());*/
            }
            finally
            {
                if (mainContainer != null)
                    mainContainer.Dispose();
            }
        }
    }
}
