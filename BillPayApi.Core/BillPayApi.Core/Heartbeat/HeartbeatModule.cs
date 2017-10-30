using Nancy;

namespace BillPayApi.Core.Heartbeat
{
    // ReSharper disable once UnusedMember.Global
    public sealed class HeartbeatModule : NancyModule
    {
        public HeartbeatModule()
            : base("heartbeat")
        {
            Get("/", args => "Super Duper HEARTBEAT running on .NET Core", null, "GetHeartbeat");
        }
    }
}
