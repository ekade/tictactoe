using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace TicTacToeCommon.Utils
{
    public class XmlSerializer : ISerializer
    {
        public T Deserialize<T>(string rawData)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (StringReader reader = new StringReader(rawData))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        public string Serialize<T>(T obj)
        {
            var emptyNamepsaces = new System.Xml.Serialization.XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = true
            };

            using (var stream = new StringWriter())
            {
                using (var writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, obj, emptyNamepsaces);
                    return stream.ToString();
                }
            }
        }
    }
}
