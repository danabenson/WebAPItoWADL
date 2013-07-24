using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Link
    {
        [XmlAttribute("resource_type")]
        public string ResourceType { get; set; }

        [XmlAttribute("rel")]
        public string Rel { get; set; }

        [XmlAttribute("rev")]
        public string Rev { get; set; }
    }
}