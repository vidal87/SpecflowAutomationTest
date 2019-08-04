using NUnit.Framework;
using Newtonsoft.Json.Linq;
using System.Net;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    public class RestApiSuccessRegSteps
    {
        [Given(@"creating client connection")]
        public void GivenCreatingClientConnection()
        {
            
            var restUrl = restApi.SetUrl("api/register");
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"create a POST resqust")]
        public void GivenCreateAPOSTResqust()
        {
            string jsonString = @"{""email"":""eve.holt@reqres.in"",
                                    ""password"":""pistol""}";

            var restRequest = restApi.CreateRequest(jsonString);
           //ScenarioContext.Current.Pending();
        }
             
        [Then(@"I get output data from received response")]
        public void ThenIGetOutputDataFromReceivedResponse()
        {
            var response = restApi.GetResponse();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            JObject responseJsonObject = JObject.Parse(response.Content);
        }
    }
}
