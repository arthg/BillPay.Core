using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillPayApi.Core.Home
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => GetPetStoreUrl(), null, "Home");
        }

        private Response GetPetStoreUrl()
        {
            var port = Request.Url.Port ?? 80;
            return Response.AsRedirect($"http://petstore.swagger.io/?url=http://localhost:{port}/api-docs");
        }
    }
}

