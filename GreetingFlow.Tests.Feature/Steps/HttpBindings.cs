using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using TechTalk.SpecFlow;
using GreetingFlow.Tests.Feature.Utilities;

namespace GreetingFlow.Tests.Feature.Steps
{
    [Binding]
    public class HttpBindings
    {
        private static HttpClient _client;
        private static readonly Dictionary<string, string> HttpTriggerUris = new Dictionary<string, string>()
        {
            { "TestLogicApp", EnvVariables.LogicAppTriggerUrl }
        };

        [BeforeTestRun]
        public static void Initialize()
        {
            _client = new HttpClient();
        }

        [Given(@"I send a POST request to '(.*)' with the body")]
        [When(@"I send a POST request to '(.*)' with the body")]
        public void ISendAPOSTRequestToWithTheBody(string uriKey, Table table)
        {
            var json = JsonConvert.SerializeObject(table.Rows.First());
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _ = _client.PostAsync(HttpTriggerUris[uriKey], content).Result;
        }
    }
}
