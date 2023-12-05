using System.Xml.Serialization;

namespace Supermodel.UI.Model
{
    [XmlRoot("game")]
    public class Game
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "parent")]
        public string Parent { get; set; }

        [XmlElement("identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Game()
        {
            Name = string.Empty;
            Parent = string.Empty;
            Identity = new Identity();
        }
    }
}
