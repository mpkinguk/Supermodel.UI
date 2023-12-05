using System.Xml.Serialization;

namespace Supermodel.UI.Model
{
    [XmlRoot("game")]
    public class Game
    {
        /// <summary>
        /// The rom name
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The parent, if it is variant
        /// </summary>
        [XmlAttribute(AttributeName = "parent")]
        public string Parent { get; set; }

        /// <summary>
        /// The identity values
        /// </summary>
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
