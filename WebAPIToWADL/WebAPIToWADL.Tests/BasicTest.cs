using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAPIToWADL.Tests
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void TestBasic()
        {
            //var config = new HttpConfiguration();
            //var routeTemplate = "api/values";
            //var controllerDescriptor = new HttpControllerDescriptor(config, "ApiExplorerValues", typeof(ApiExplorerValuesController));
            //var action = new ReflectedHttpActionDescriptor(controllerDescriptor, typeof(ApiExplorerValuesController).GetMethod("Get"));
            //var actions = new ReflectedHttpActionDescriptor[] { action };
            //config.Routes.Add("Route", new HttpDirectRoute(routeTemplate, actions));

            //var descriptions = new ApiExplorer(config).ApiDescriptions;
        }

        public class ApiExplorerValuesController : ApiController
        {
            public void Get()
            {
            }
        }
    }
}