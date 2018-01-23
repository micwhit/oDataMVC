using Angular2QuickStart.Models;
using Microsoft.OData.Edm;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
namespace Angular2QuickStart
{
    class WebApiConfig
    {
        #region Register
        public static void Register(HttpConfiguration config)
        {
            // OData routes
            // These must be configured before the WebAPI routes 
            config.MapHttpAttributeRoutes();
            config.MapODataServiceRoute(
               routeName: "ODataRoute",
               routePrefix: "odata",
               model: GenerateEntityDataModel());
            // Web API routes 
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        #endregion
        #region GenerateEntityDataModel
        private static IEdmModel GenerateEntityDataModel()
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            // CurrentUser function
            var CurrentUserFunction = builder.Function("CurrentUser");
            CurrentUserFunction.Returns<User>();
            
            // Register ODataProducts
            builder.EntitySet<DTOProduct>("ODataProducts");

            return builder.GetEdmModel();
        }
        #endregion
    }
}