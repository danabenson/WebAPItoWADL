﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WebAPIToWADL.Models
{
    public class Grammars
    {
        [XmlElement("include")]
        public List<Include> Includes { get; set; }
    }
}
