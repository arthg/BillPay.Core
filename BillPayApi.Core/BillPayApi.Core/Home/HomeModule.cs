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
            Get("/", args => "Super Duper Happy Path running on .NET Core");
        }
    }
}
