using System.Collections.Generic;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Grammars
    {
        [XmlElement("include")]
        public List<Include> Includes { get; set; }
    }
}