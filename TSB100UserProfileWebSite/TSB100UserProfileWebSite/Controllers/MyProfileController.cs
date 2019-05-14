using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TSB100UserProfileWebSite.Controllers
{
    public class MyProfileController : Controller
    {
        // GET: MyProfile
        public ActionResult Index()
        {
            ProfileServiceReference.UserProfileServiceClient client = new ProfileServiceReference.UserProfileServiceClient();
            return View();
        }
    }
}