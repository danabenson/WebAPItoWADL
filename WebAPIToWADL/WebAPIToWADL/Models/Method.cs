using System.Collections.Generic;
using System.Net.Http;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Method
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public HttpMethod HttpMethod { get; set; }

        [XmlElement("request")]
        public Request Request { get; set; }

        [XmlElement("response")]
        public List<Response> Responses { get; set; }
    }
}