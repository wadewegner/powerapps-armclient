using System.Configuration;
using System.Threading.Tasks;
using ARMClient.Authentication.Contracts;
using ARMClient.Library;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Tests.Models;

namespace Tests
{
    [TestFixture]
    public class PowerApps
    {
        private static readonly string Username = ConfigurationManager.AppSettings["Username"];
        private static readonly string Password = ConfigurationManager.AppSettings["Password"];
        const string ApiVersion = "2015-08-01-alpha";

        [Test]
        public async Task DeleteAllConnections()
        {
            var url = "https://management.azure.com/providers/Microsoft.PowerApps/connections/";
            var armClient = ARMLib.GetDynamicClient(ApiVersion, AzureEnvironments.Prod, url).ConfigureLogin(LoginType.Upn, Username, Password);
            var connections = await armClient.GetAsync<Connections>();

            foreach (var connection in connections.value)
            {
                url = string.Concat("https://management.azure.com", connection.id);
                armClient = ARMLib.GetDynamicClient(ApiVersion, AzureEnvironments.Prod, url).ConfigureLogin(LoginType.Upn, Username, Password);

                await armClient.DeleteAsync<JObject>();
            }

            Assert.IsTrue(true);
        }
    }
}
