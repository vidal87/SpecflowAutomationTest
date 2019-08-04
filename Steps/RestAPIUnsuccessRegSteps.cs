using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.Net;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    public class RestAPIUnsuccessRegSteps
    {
        [Given(@"creating client connect")]
        public void GivenCreatingClientConnect()
        {
            var restUrl = restApi.SetUrl("api/register");
            // ScenarioContext.Current.Pending();
        }
        
        [Given(@"creating json post")]
        public void GivenCreatingJsonPost()
        {
            string jsonString = @"{""email"":""eve.holt@reqres.in""}";

            var restRequest = restApi.CreateRequest(jsonString);
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be BadRequest")]
        public void ThenTheResultShouldBeBadRequest()
        {
            var response = restApi.GetResponse();
            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
            JObject responseJsonObject = JObject.Parse(response.Content);
            // ScenarioContext.Current.Pending();
        }
    }
}
