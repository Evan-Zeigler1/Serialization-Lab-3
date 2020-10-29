using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // using xml reader
using System.Xml.Serialization; // used to create the XML Serialization
using System.IO; // This is needed for the TextWriter

namespace XMLSample2
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //emp.ID = 123;
            //emp.Name = "Evan Zeigler";
            //emp.SSNumber = 123456789;
            //emp.EntryDate = DateTime.Now;
            //emp.JobRole = "Ninja";

            Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name}\nEmployee SS#: {emp.SSNumber}\nDate Created: {emp.EntryDate}");

            //Creating location to store your XML file
            string FilePath = "E:/";
            string FileName = "Samurai.xml";
            //new trick to create the path to save the file ^^^^ combine the two varibles above on the next line down.
            //TextWriter writer = new StreamWriter(FilePath + FileName);
            //Actual Part for Serialization
            //XmlSerializer ser = new XmlSerializer(typeof(Employee));

            //get the writer stram and the instance of the class we have... below
            //ser.Serialize(writer, emp);
            //writer.Close();

            XmlSerializer des = new XmlSerializer(typeof(Employee));
            using (XmlReader reader = XmlReader.Create(FilePath + FileName))
            {
                emp = (Employee)des.Deserialize(reader);
                Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.Name}\nEmployee SS#: {emp.SSNumber}\nDate Created: {emp.EntryDate}");
            }

            Console.ReadLine();
        }
    }
}
    
