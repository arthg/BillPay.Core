using Nancy;
using Nancy.TinyIoc;
using Nancy.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Swagger.Services;
using Swagger.ObjectModel;
using Nancy.Conventions;

namespace BillPayApi.Core
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            SwaggerMetadataProvider.SetInfo("BillPay API", "v0", "Our awesome service", new Contact()
            {
                EmailAddress = "exampleEmail@example.com"
            });

            base.ApplicationStartup(container, pipelines);
        }

        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            nancyConventions.StaticContentsConventions.Add(
                StaticContentConventionBuilder.AddDirectory("/swagger-ui/dist")
            );
        }

        /// <summary>
        /// Initialise the request - can be used for adding pre/post hooks and
        ///             any other per-request initialisation tasks that aren't specifically container setup
        ///             related
        /// </summary>
        /// <param name="container">Container</param><param name="pipelines">Current pipelines</param><param name="context">Current context</param>
        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            pipelines.AfterRequest.AddItemToEndOfPipeline(x => x.Response.Headers.Add("Access-Control-Allow-Origin", "*"));
        }
    }
}
