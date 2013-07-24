using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Request
    {
        public List<Documentation> Documentations { get; set; }

        public List<Representation> Representations { get; set; }

        //style will be "query" or "header"
        [XmlArrayItem("parameter")]
        public List<Parameter> Parameters { get; set; }
    }
}