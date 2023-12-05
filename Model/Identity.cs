using System.Xml.Serialization;

namespace Supermodel.UI.Model
{
    [XmlRoot("identity")]
    public class Identity
    {
        /// <summary>
        /// The full game title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// The game version
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }

        /// <summary>
        /// The game manufacturer
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The year of release
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
        
        /// <summary>
        /// The constructor
        /// </summary>
        public Identity() 
        {
            Title = string.Empty;
            Version = string.Empty;
            Manufacturer = string.Empty;
            Year = string.Empty;
        }
    }
}
