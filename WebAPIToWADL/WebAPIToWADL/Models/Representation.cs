using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Representation
    {
        [XmlAttribute("mediatype")]
        public string MediaType { get; set; }

        [XmlAttribute("element")]
        public string Element { get; set; }
    }
}
