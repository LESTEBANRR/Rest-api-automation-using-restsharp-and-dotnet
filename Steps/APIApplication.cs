using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace APIAutomationTestSuite.Steps
{
    [Binding]
    public sealed class APIApplication
    {
        [Given(@"I have a endpoint (.*)")]
        public void GivenIHaveAEndpointEndpoint(string endpoint)
        {
            RestApiHelper.SetUrl(endpoint);
        }
               
        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfApi()
        {
            RestApiHelper.CreateRequest();
        }

        [Then(@"I get a API response in json format")]
        public void ThenIGetAAPIResponseInJsonFormat()
        {
            var expected = "something";
            var response = RestApiHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.Content, Is.EqualTo(expected),"Error Message");
            }
        }

        [When(@"I call get method to get user information using (.*)")]
        public void WhenICallGetMethodToGetUserInformationUsingUser(string userId)
        {
            RestApiHelper.CreateRequest(userId);
        }

        [Then(@"I will get user information")]
        public void ThenIWillGetUserInformation()
        {
            var response = RestApiHelper.GetResponse();
        }


    }
}
