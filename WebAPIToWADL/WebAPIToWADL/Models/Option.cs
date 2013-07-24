using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Option
    {
        [XmlAttribute("value")]
        public string Value { get; set; }

        [XmlAttribute("mediaType")]
        public string MediaType { get; set; }
    }
}