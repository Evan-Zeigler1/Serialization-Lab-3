using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; // using xml reader
using System.Xml.Serialization;

namespace XMLSample2
{
    [XmlRoot("New Employees", Namespace ="www.nerdinc.ninja")]//Declare that this is the root and get the value. You don't need the Namespace, but it is important in some XML applications.
    public class Employee //NOTE YOU CANNOT SERIALIZE PRIVATE FIELDS
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SSNumber { get; set; }
        public DateTime EntryDate { get; set; } // using DateTime method. Predefined method in .NET Framework
        [XmlIgnore]
        public string JobRole { get; set; }
    }  
}
