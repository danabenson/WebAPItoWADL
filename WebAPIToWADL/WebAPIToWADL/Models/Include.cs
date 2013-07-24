using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Include
    {
        [XmlAttribute("href")]
        public string Href { get; set; }
    }
}
