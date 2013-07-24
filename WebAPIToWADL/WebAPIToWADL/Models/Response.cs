using System.Collections.Generic;
using System.Net;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Response
    {
        [XmlAttribute("status")]
        public HttpStatusCode HttpStatusCode { get; set; }

        [XmlElement("doc")]
        public List<Documentation> Documentations { get; set; }

        [XmlElement("representation")]
        public List<Representation> Representations { get; set; }

        //style will be "header"
        [XmlElement("param")]
        public List<Parameter> Parameters { get; set; }
    }
}