using System.Xml.Serialization;

namespace Supermodel.UI.Model
{
    [XmlRoot("games")]
    public class Games
    {
        /// <summary>
        /// List of games
        /// </summary>
        [XmlElement("game")]
        public List<Game> GameList { get; set; }

        /// <summary>
        /// The constructor
        /// </summary>
        public Games() 
        { 
            GameList = new List<Game>();
        }
    }
}
