﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIToWADL.Models
{
    public class Application
    {
        public ResourcesCollection Resources { get; set; }

        public Grammars Grammars { get; set; }
    }
}
