using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Parameter
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("required")]
        public bool Required { get; set; }

        [XmlAttribute("type")]
        public ParamType Type { get; set; }

        [XmlAttribute("style")]
        public Style Style { get; set; }

        [XmlAttribute("default")]
        public string Default { get; set; }

        [XmlAttribute("href")]
        public string Href { get; set; }

        [XmlAttribute("repeating")]
        public bool Repeating { get; set; }

        [XmlAttribute("fixed")]
        public string Fixed { get; set; }

        public List<Option> Options { get; set; }

        [XmlElement("doc")]
        public List<Documentation> Documentations { get; set; }

        [XmlElement("link")]
        public Link Link { get; set; }
    }
}