using System.Configuration;

namespace WebAPIToWADL.Configuration
{
    public class Configuration : ConfigurationSection
    {
        public string BaseURI { get; set; }
    }
}