using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIToWADL.Models
{
    public class ResourcesCollection : List<Resource>
    {
        public string Base { get; set; }
    }
}
