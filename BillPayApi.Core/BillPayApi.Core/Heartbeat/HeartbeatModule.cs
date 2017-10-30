using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillPayApi.Core.Home
{
    public class HeartbeatModule : NancyModule
    {
        public HeartbeatModule()
            : base("heartbeat")
        {
            Get("/", args => "Super Duper HEARTBEAT running on .NET Core", null, "GetHeartbeat");
        }
    }
}
