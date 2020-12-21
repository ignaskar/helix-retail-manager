using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HRMDataManager.Library.DataAccess;
using HRMDataManager.Library.Models;
using Microsoft.AspNet.Identity;

namespace HRMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        [HttpGet]
        public UserModel GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            
            UserData data = new UserData();

            return data.GetUserById(userId).First();
        }
    }
}
