using System;
using System.Collections.Generic;
using System.Web.Http.Description;
using WebAPIToWADL.Configuration;
using WebAPIToWADL.Models;

namespace WebAPIToWADL
{
    public class ConvertApiDescriptionsToModel : IConvertApiDescriptionsToModel
    {
        private readonly IConfiguration _config;

        public ConvertApiDescriptionsToModel(IConfiguration config)
        {
            _config = config;
        }

        public Application Execute(ICollection<ApiDescription> descriptions)
        {
            var app = new Application();
            app.Resources = new ResourcesCollection();
            app.Resources.Base = _config.BaseURI;

            return app;
        }
    }
}