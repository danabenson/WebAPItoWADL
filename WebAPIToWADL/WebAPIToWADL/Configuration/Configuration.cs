using System.Configuration;

namespace WebAPIToWADL.Configuration
{
    public class Configuration : IConfiguration
    {
        public string BaseURI { get; set; }
    }
}