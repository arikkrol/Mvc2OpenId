namespace OpenIdRelyingPartyMvc.Controllers {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;
    using DotNetOpenAuth.OpenId.RelyingParty;
    using OpenIdRelyingPartyMvc.Models;

	public class HomeController : Controller 
    {

		public ActionResult Index() {
			Response.AppendHeader(
				"X-XRDS-Location",
				new Uri(Request.Url, Response.ApplyAppPathModifier("~/Home/xrds")).AbsoluteUri);
			return View("Index");
		}

        public ActionResult MainView()
        {
            IAuthenticationResponse response = AuthenticationManager.GetAuthenticationResponse();

            if (response == null || response.Status != AuthenticationStatus.Authenticated)
            {
                return RedirectToAction("LogInOpenId", "LogOn");
            }

            return View();
        }

		public ActionResult Xrds() {
			return View("Xrds");
		}
	}
}
