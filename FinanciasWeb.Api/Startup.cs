using FinanciasWeb.CrossCutting;
using FinanciasWeb.Api.Helpers;
using FinanciasWeb.SharedKernel.Events;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System.Web.Http;
using Unity;

namespace FinanciasWeb.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            var container = new UnityContainer();

            ConfigureDependencyInjection(config, container);
            ConfigureWebApi(config);

            // ConfigureOAuth(app, container.Resolve<IUserApplicationService>());

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);  // Isso irá liberar o acesso em Dominios Externos
            app.UseWebApi(config);
        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            var formatters = config.Formatters;      //Configuração para formatação do tipo de retorno
            formatters.Remove(formatters.XmlFormatter); // Retira o xml dos tipos de retorno deixando só p Json

            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
        }

        public static void ConfigureDependencyInjection(HttpConfiguration config, UnityContainer container)
        {
            DependencyRegister.Register(container);

            config.DependencyResolver = new UnityResolverHelper(container);
            DomainEvents.Container = new DomainEventsContainer(config.DependencyResolver);

        }

    }
}