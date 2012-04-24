using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OpenId.RelyingParty;
using OpenIdRelyingPartyMvc.Models;

namespace OpenIdRelyingPartyMvc.Controllers
{
    public class LogOnController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogInOpenId()
        {
            IAuthenticationResponse response = AuthenticationManager.GetAuthenticationResponse();

            //TODO: change
            return null;
        }

    }
}
