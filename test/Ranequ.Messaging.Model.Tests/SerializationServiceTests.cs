using NUnit.Framework;

namespace Ranequ.Messaging.Model.Tests
{
    [TestFixture]
    public class SerializationServiceTests
    {
        private SerializationService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new SerializationService();
        }

        [Test]
        public void SerializeToJson_SerializesObjectToJson()
        {
            var obj = new { Name = "John", Age = 42 };
            var expectedJson = "{\"Name\":\"John\",\"Age\":42}";
            var actualJson = _service.SerializeToJson(obj);
            
            Assert.AreEqual(expectedJson, actualJson);
        }

        [Test]
        public void DeserializeFromJson_DeserializesObjectFromJson()
        {
            var json = "{\"Name\":\"John\",\"Age\":42}";
            var expectedObj = new { Name = "John", Age = 42 };
            var actualObj = _service.DeserializeFromJson<dynamic>(json);

            Assert.AreEqual(expectedObj.Name, actualObj.Name);
            Assert.AreEqual(expectedObj.Age, actualObj.Age);
        }

        [Test]
        public void SerializeToXml_SerializesObjectToXml()
        {
            var obj = new { Name = "John", Age = 42 };
            var expectedXml = "<root><Name>John</Name><Age>42</Age></root>";
            var actualXml = _service.SerializeToXml(obj);

            Assert.AreEqual(expectedXml, actualXml);
        }

        [Test]
        public void DeserializeFromXml_DeserializesObjectFromXml()
        {
            var xml = "<root><Name>John</Name><Age>42</Age></root>";
            var expectedObj = new { Name = "John", Age = 42 };
            var actualObj = _service.DeserializeFromXml<dynamic>(xml);

            Assert.AreEqual(expectedObj.Name, actualObj.Name);
            Assert.AreEqual(expectedObj.Age, actualObj.Age);
        }

        [Test]
        public void DeserializeFromXml_DeserializesNestedObjectFromXml()
        {
            var xml = "<root><Name>John</Name><Age>42</Age><Address><Street>Main St.</Street><City>Anytown</City></Address></root>";
            var expectedObj = new { Name = "John", Age = 42, Address = new { Street = "Main St.", City = "Anytown" } };
            var actualObj = _service.DeserializeFromXml<dynamic>(xml);

            Assert.AreEqual(expectedObj.Name, actualObj.Name);
            Assert.AreEqual(expectedObj.Age, actualObj.Age);
            Assert.AreEqual(expectedObj.Address.Street, actualObj.Address.Street);
            Assert.AreEqual(expectedObj.Address.City, actualObj.Address.City);
        }

        [Test]
        public void DeserializeFromXml_DeserializesArrayFromXml()
        {
            var xml = "<root><Items><Item>1</Item><Item>2</Item><Item>3</Item></Items></root>";
            var expectedObj = new int[] { 1, 2, 3 };

            var actualObj = _service.DeserializeFromXml<int[]>(xml);

            Assert.AreEqual(expectedObj.Length, actualObj.Length);
            for (int i = 0; i < expectedObj.Length; i++)
            {
                Assert.AreEqual(expectedObj[i], actualObj[i]);
            }
        }
    }
}
