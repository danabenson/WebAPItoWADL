using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIToWADL.Models
{
    public class Method
    {
        public string Id { get; set; }

        public HttpMethod HttpMethod { get; set; }
    }
}
