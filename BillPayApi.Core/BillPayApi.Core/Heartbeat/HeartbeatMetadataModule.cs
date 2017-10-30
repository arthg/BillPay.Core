using Nancy.Metadata.Modules;
using Nancy.Swagger;
using Swagger.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BillPayApi.Core.Heartbeat
{
    
    public class HeartbeatMetadataModule : MetadataModule<PathItem>
    {
        public HeartbeatMetadataModule()
        {
            Describe["GetHeartbeat"] = description => description.AsSwagger(
            with => with.Operation(
                op => op.OperationId("GetHeartbeat")
                        .Tag("Heartbeat")
                        .Summary("Heartbeat")
                        .Description("This returns status code 200 and some blah blah blah when the service is alive and heart is beating")));
        }
    }
    
}
