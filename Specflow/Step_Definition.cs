using Common;
using Common.Service;
using Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Specflow
{
    [Binding]
    public class Step_Definition
    {
        private static IEnumerable<Employee> _employees;
        private static bool isSuccessfull;

        [Given(@"I have the following employees:")]
        public void GivenIHaveTheFollowingEmployee(Table table)
        {
            //The first step has been done for you.
            var eService = new EmployeeService();
            _employees = eService.CreateEmployee(table);
        }

        [When(@"I post employee to the api")]
        public void WhenIPostEmployeeToTheApi()
        {
            var restService = new RestService();
            var helper = new StepDefinitionHelper();
            //Here you need to write a code that will add both employees by making a POST operation to the dummy endpoing which can be found in the Endpoints.cs class.
            
        }

        [Then(@"I verify that the request was successful")]
        public void ThenIVerifyThatTheRequestWasSuccessful()
        {
           //Verify request was successful.

        }

    }
}
