using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Include
    {
        [XmlAttribute("href")]
        public string Href { get; set; }
    }
}