using System.Net;
using Nancy.Metadata.Modules;
using Nancy.Swagger;
using Swagger.ObjectModel;

namespace BillPayApi.Core.Heartbeat
{  
    // ReSharper disable once UnusedMember.Global
    public class HeartbeatMetadataModule : MetadataModule<PathItem>
    {
        public HeartbeatMetadataModule()
        {
            Describe["GetHeartbeat"] = description => description.AsSwagger(
            with => with.Operation(
                op => op.OperationId("GetHeartbeat")
                        .Tag("Heartbeat")
                        .Summary("Heartbeat")
                        .Response(HttpStatusCode.OK, r => r.Description("The blah blah blah"))
                        .Description("This returns status code 200 and some blah blah blah when the service is alive and heart is beating")));
        }
    }
    
}
