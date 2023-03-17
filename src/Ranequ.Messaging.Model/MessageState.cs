using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Xml.Serialization;

namespace Ranequ.Messaging.Model
{ 
    public class SerializationService
    {
        // Serialize an object to JSON using Newtonsoft.Json
        public string SerializeToJson<T>(T obj)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new[] { new StringEnumConverter() }
            };

            return JsonConvert.SerializeObject(obj, settings);
        }

        /// <summary>
        ///     Deserialize an object from JSON using Newtonsoft.Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public T DeserializeFromJson<T>(string json)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                Converters = new[]
                {
                    new StringEnumConverter()

                }
            };

            return JsonConvert.DeserializeObject<T>(json, settings);
        }

        /// <summary>
        ///     Serialize an object to XML using System.Xml.Serialization
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public string SerializeToXml<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }

        /// <summary>
        ///     Deserialize an object from XML using System.Xml.Serialization
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public T DeserializeFromXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var stringReader = new StringReader(xml))
            {
                return (T)serializer.Deserialize(stringReader);
            }
        }
    }

}