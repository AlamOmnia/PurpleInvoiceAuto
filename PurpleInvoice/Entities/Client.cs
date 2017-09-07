using System;
using System.Xml.Serialization;
using PurpleInvoice.Configuration;

namespace PurpleInvoice.Entities
{
    [XmlRoot("Clients")]
    public class Client
    {
        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("ClientType")]
        public ClientType ClientType { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string WhomToAttention { get; set; }

        /// <summary>
        /// Only ANS type clients have this property. Populated from the XML file
        /// </summary>
        public string VatRegNo { get; set; }

        /// <summary>
        /// Reference used in the Report generateor - Only IOS type clients have this property written in the xml. For ANS
        /// Client if the invoice is domestic it should be set "ANS" and if International Outgoing it should be set "Out ANS"
        /// </summary>
        public string RefNo { get; set; }
        public string ClientRef { get; set; }
    }
}
