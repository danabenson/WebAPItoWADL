using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class ResourcesCollection : List<Resource>
    {
        [XmlAttribute("base")]
        public string Base { get; set; }
    }
}