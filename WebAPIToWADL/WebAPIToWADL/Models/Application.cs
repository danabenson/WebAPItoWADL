using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Application
    {
        [XmlArray("resources")]
        [XmlArrayItem("resource")]
        public ResourcesCollection Resources { get; set; }

        [XmlElement("grammars")]
        public Grammars Grammars { get; set; }
    }
}