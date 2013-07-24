using System.Xml;

namespace WebAPIToWADL
{
    public interface IWADLProvider
    {
        XmlDocument Get();
    }
}