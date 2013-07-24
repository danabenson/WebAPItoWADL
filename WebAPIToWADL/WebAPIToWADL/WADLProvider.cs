using System.IO;
using System.Web.Http.Description;
using System.Xml;
using System.Xml.Serialization;
using WebAPIToWADL.Models;

namespace WebAPIToWADL
{
    public class WADLProvider : IWADLProvider
    {
        private readonly IApiExplorer _apiExplorer;
        private readonly IConvertApiDescriptionsToModel _convertToModel;

        public WADLProvider(IApiExplorer apiExplorer, IConvertApiDescriptionsToModel convertToModel)
        {
            _apiExplorer = apiExplorer;
            _convertToModel = convertToModel;
        }

        public XmlDocument Get()
        {
            var descriptions = _apiExplorer.ApiDescriptions;
            Application application = _convertToModel.Execute(descriptions);
            string xml = Serialize(application);
            return GetXmlDocument(xml);
        }

        private string Serialize(Application app)
        {
            var serialer = new XmlSerializer(typeof (Application));
            using (var ms = new MemoryStream())
            {
                var xw = new StreamWriter(ms);
                serialer.Serialize(ms, app);
                xw.Flush();
                var sr = new StreamReader(ms);
                return sr.ReadToEnd();
            }
        }

        private XmlDocument GetXmlDocument(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            return doc;
        }
    }
}