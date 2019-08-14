using System;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument newXML = new XmlDocument();
            newXML.Load("newXML.xml");
            XmlElement root = newXML.DocumentElement;

            List<Hero> listHero = new List<Hero>();

            foreach (XmlNode x in root)
            {
                string name = "";
                int level = 0;
                string ultimate = "";
                foreach (XmlNode child in x.ChildNodes)
                {
                    if (child.Name.Equals("name")) name = child.InnerText;
                    if (child.Name.Equals("level")) level = Int32.Parse(child.InnerText);
                    if (child.Name.Equals("ultimate")) ultimate = child.InnerText;
                }
                listHero.Add(new Hero(name, level, ultimate));
            }

            foreach (Hero h in listHero)
            {
                Console.WriteLine(h);
            }

            XmlSerializer ser = new XmlSerializer(typeof(Hero));
            using (FileStream fs = new FileStream("Hero.xml", FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, listHero[0]);
            }
        }
    }
}
