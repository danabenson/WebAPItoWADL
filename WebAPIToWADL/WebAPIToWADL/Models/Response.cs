﻿using System.Collections.Generic;
using System.Net;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Response
    {
        [XmlAttribute("status")]
        public HttpStatusCode HttpStatusCode { get; set; }

        public List<Documentation> Documentations { get; set; }

        public List<Representation> Representations { get; set; }

        //style will be "header"
        public List<Parameter> Parameters { get; set; }
    }
}