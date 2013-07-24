using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Request
    {
        [XmlElement("doc")]
        public List<Documentation> Documentations { get; set; }

        [XmlElement("representation")]
        public List<Representation> Representations { get; set; }

        //style will be "query" or "header"
        [XmlArrayItem("parameter")]
        public List<Parameter> Parameters { get; set; }
    }
}