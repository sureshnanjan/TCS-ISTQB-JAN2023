using TechTalk.SpecFlow;
using System;
namespace PetStoreEndToEndExecutionLayer.StepDefinitions
{
    [Binding]
    public sealed class PetStoreHomePageDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public PetStoreHomePageDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }

        [Given(@"the petstore is available")]
        public void GivenThePetstoreIsAvailable()
        {
            Console.WriteLine("Executing The Test");
        }

        [When(@"logo is checked")]
        public void WhenLogoIsChecked()
        {
            Console.WriteLine("Executing The Test");
        }

        [Then(@"placement should be on the topLeft")]
        public void ThenPlacementShouldBeOnTheTopLeft()
        {
            Console.WriteLine("Executing The Test");
        }
    }
}