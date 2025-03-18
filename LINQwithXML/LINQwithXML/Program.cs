using System;
using System.Xml.Linq;
using System.Linq;

namespace LINQwithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "input.xml";
            string outputFilePath = "output.xml";

            XElement inputXml = XElement.Load(inputFilePath);

            // Debug: Display loaded input XML
            Console.WriteLine("Input XML:");
            Console.WriteLine(inputXml);

            // Query and transform the XML data
            var modifiedData = from element in inputXml.Elements("Person")
                               where (int)element.Element("Age") > 20
                               select new XElement("ModifiedPerson",
                                   new XElement("Name", element.Element("Name").Value),
                                   new XElement("Age", (int)element.Element("Age") + 5)
                               );

            // Debug: Check filtered/modified data
            Console.WriteLine("Filtered/Modified Data:");
            foreach (var element in modifiedData)
            {
                Console.WriteLine(element);
            }

            // Wrap and save the output XML
            XElement outputXml = new XElement("ModifiedData", modifiedData);
            outputXml.Save(outputFilePath);

            Console.WriteLine($"Data saved to: {outputFilePath}");
        }
    }
}
