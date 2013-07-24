using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Representation
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("mediatype")]
        public string MediaType { get; set; }

        [XmlAttribute("element")]
        public string Element { get; set; }

        [XmlAttribute("profile")]
        public string Profile { get; set; }

        [XmlElement("doc")]
        public List<Documentation> Documentations { get; set; }

        [XmlElement("param")]
        public Parameter Parameter { get; set; }
    }
}