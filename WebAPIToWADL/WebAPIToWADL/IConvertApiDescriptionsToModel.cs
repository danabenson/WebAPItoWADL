using System.Collections.Generic;
using System.Web.Http.Description;
using WebAPIToWADL.Models;

namespace WebAPIToWADL
{
    public interface IConvertApiDescriptionsToModel
    {
        Application Execute(ICollection<ApiDescription> descriptions);
    }
}