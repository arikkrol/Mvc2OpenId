using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.OpenId.RelyingParty;

namespace OpenIdRelyingPartyMvc.Models
{
    public static class AuthenticationManager
    {
        private static OpenIdRelyingParty s_Openid = new OpenIdRelyingParty();

        public static IAuthenticationResponse GetAuthenticationResponse()
        {
            return s_Openid.GetResponse();
        }

        public static IAuthenticationRequest MakeAuthenticationRequest(string openIdProviderUrl)
        {
            return s_Openid.CreateRequest(openIdProviderUrl);
        }
    }
}