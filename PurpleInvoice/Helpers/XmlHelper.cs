using System;
using System.IO;
using System.Xml.Serialization;

namespace PurpleInvoice.Helpers
{
    public class XmlHelper
    {
        #region Singleton Implementation
        private static XmlHelper instance;
        public static XmlHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new XmlHelper();
                return instance;
            }
        }
        #endregion

        private XmlHelper()
        {
        }

        public bool WriteSerializedObject<T>(string filePath, T obj)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    xs.Serialize(writer, obj);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public T GetDeserializedObject<T>(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }

        /*using System;
using System.IO;
using System.Xml.Serialization;

namespace PurpleInvoice.Helpers
{
    public class XmlHelper
    {
        #region Singleton Implementation
        private static XmlHelper instance;
        public static XmlHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new XmlHelper();
                return instance;
            }
        }
        #endregion

        public bool SaveObject<T>(string filePath, T obj)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(T));
                    xs.Serialize(writer, obj);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public T ParseObject<T>(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }

        public T ParseList<T>(string filePath, string xmlRootName = null)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer;

                if (xmlRootName != null)
                    serializer = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootName));
                else
                    serializer = new XmlSerializer(typeof(T));

                return (T)serializer.Deserialize(reader);
            }
        }

    }
}
*/
    }
}
