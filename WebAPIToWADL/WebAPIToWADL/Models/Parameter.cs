using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIToWADL.Models
{
    public class Parameter
    {
        public string Name { get; set; }

        public bool Required { get; set; }

        public ParamType ParamType { get; set; }

        public string Style { get; set; }

        public string Default { get; set; }

        public List<Option> Options { get; set; }
    }
}
