using Angular2QuickStart.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;
namespace Angular2QuickStart.Controllers
{
    public class OData4Controller : ODataController
    {
        #region public IHttpActionResult CurrentUser()
        // odata/CurrentUser() - must be a Post call
        [ODataRoute("CurrentUser()")]
        public IHttpActionResult CurrentUser()
        {
            // User to return
            User objUser = new User();
            // See if the user is logged in
            if (this.User.Identity.IsAuthenticated)
            {
                // They are logged in
                objUser.Username = this.User.Identity.Name;
            }
            else
            {
                // They are not logged in
                objUser.Username = "[Not Logged in]";
            }
            // Return the result
            return Ok(objUser);
        }
        #endregion
    }
}