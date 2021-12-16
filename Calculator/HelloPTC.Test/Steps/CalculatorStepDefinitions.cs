using Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HelloPTC.Test.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        int result;
        private SimpleCalculator calculator = new SimpleCalculator(); 


        public CalculatorStepDefinitions()
        {
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result =  calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
