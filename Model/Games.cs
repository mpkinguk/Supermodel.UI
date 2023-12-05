using System.Xml.Serialization;

namespace Supermodel.UI.Model
{
    [XmlRoot("games")]
    public class Games
    {
        [XmlElement("game")]
        public List<Game> GameList { get; set; }

        public Games() 
        { 
            GameList = new List<Game>();
        }
    }
}
