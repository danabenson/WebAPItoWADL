using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Parameter
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("required")]
        public bool Required { get; set; }

        [XmlAttribute("type")]
        public ParamType ParamType { get; set; }

        [XmlAttribute("style")]
        public Style Style { get; set; }

        [XmlAttribute("default")]
        public string Default { get; set; }

        public List<Option> Options { get; set; }

        [XmlElement("doc")]
        public List<Documentation> Documentations { get; set; }
    }
}