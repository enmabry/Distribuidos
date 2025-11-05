using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Libreria
{
    public static class XmlHelper
    {
        // Convierte a su representación en XML
        public static string SerializeToXml<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var memorystream = new MemoryStream())
            {
                serializer.Serialize(memorystream, obj);
                return Encoding.UTF8.GetString(memorystream.ToArray());
            }
        }

        // Convierte un XML (string) a un objeto del tipo indicado:

        public static T Deserialize<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var stringreader = new StringReader(xml))
            {
                var result = serializer.Deserialize(stringreader);
                if (result == null)
                    throw new InvalidOperationException("Error al deserializar el XML.");
                return (T)result;
            }
        }



    }
}
