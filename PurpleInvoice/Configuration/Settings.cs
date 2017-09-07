using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleInvoice.Entities;
using PurpleInvoice.Helpers;

namespace PurpleInvoice.Configuration
{
    public class Settings
    {
        private static Dictionary<string, Client> clients;
        public static Dictionary<string, Client> Clients
        {
            get
            {
                if (clients == null)
                    clients = clients = XmlHelper.Instance.GetDeserializedObject<Client[]>(Properties.Settings.Default.ClientProfilesFilePath)
                .ToDictionary(client => client.Name, client => client); // set client name as the key, and client object as the value
                return clients;
            }
        }

        public Settings()
        {

        }
    }
}
