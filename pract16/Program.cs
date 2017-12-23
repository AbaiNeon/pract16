using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace pract16
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../Users.xml");

            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            Console.WriteLine(xRoot.Name);

            foreach (XmlNode xNode in xRoot)
            {
                Console.WriteLine("  {0}", xNode.Name);
                foreach (XmlNode childNode in xNode.ChildNodes)
                {
                    Console.WriteLine("    {0}", childNode.Name);
                }
            }

            Console.ReadLine();
        }
    }
}
