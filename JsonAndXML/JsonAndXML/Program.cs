using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JsonAndXML
{
    public class Program
    {
        [Serializable]
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public static void Main(string[] args)
        {
            var xmlData=new Person { Name= "Sohom", Age=25 };
            var xmlSerializer= new XmlSerializer(xmlData.GetType());

            using (var writer = new StreamWriter("data.xml"))
            {
                xmlSerializer.Serialize(writer, xmlData);
            }

            using (var reader = new StreamReader("data.xml"))
            {
                var xmlObj = (Person)xmlSerializer.Deserialize(reader);
                Console.WriteLine($"Desrialized Person:  {xmlObj.Name} , {xmlObj.Age}");

            } 

        }
    }
}
