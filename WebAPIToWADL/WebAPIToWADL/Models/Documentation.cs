using System.Xml;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Documentation
    {
        [XmlText]
        public string Content { get; set; }

        [XmlAttribute("title")]
        public string Title { get; set; }
    }
}