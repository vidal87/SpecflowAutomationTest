using NUnit.Framework;
using SpecFlowDemo.Model;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    public class GetUsersAPISteps
    {
        
        [Given(@"creating an API connection")]
        public void GivenCreatingAnAPIConnection()
        {
            var restUrl = restApi.SetUrl("api/users");
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"send a GET method")]
        public void GivenSendAGETMethod()
        {
            var restRequest = restApi.CreateGetRequest();
            //ScenarioContext.Current.Pending();
        }
        [Then(@"the result should get the list of users")]
        public void ThenTheResultShouldGetTheListOfUsers()
        {
            var response = restApi.GetResponse();
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Users content = restApi.GetContent<Users>(response);
            
        }
    }
}
