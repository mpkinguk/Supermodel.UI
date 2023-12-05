using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Supermodel.UI.Model
{
    [XmlRoot("identity")]
    public class Identity
    {
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("version")]
        public string Version { get; set; }
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("year")]
        public string Year { get; set; }
        public Identity() 
        {
            Title = string.Empty;
            Version = string.Empty;
            Manufacturer = string.Empty;
            Year = string.Empty;
        }
    }
}
