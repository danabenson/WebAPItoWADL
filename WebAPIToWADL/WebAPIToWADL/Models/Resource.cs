using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Resource
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("path")]
        public string Path { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("querytype")]
        public string QueryType { get; set; }

        [XmlElement("method")]
        public List<Method> Methods { get; set; }

        [XmlElement("resource")]
        public List<Resource> SubResources { get; set; }

        [XmlElement("param")]
        public List<Parameter> Parameters { get; set; }

        [XmlElement("doc")]
        public List<Documentation> Documentations { get; set; }
    }
}