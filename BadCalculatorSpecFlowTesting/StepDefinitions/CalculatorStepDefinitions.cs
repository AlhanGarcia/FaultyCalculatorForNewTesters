using BadCalculator;
using NUnit.Framework;

namespace test.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private float _num1, _num2;
        private int _count;

        [Given(@"the user enters the first number ""([^""]*)""")]
        public void GivenTheUserEntersTheNumber(float num)
        {
            _num1 = num;
        }

        [Given(@"the user enters the second number ""([^""]*)""")]
        public void GivenTheUserEntersTheSecondNumber(float num)
        {
            _num2 = num;
        }


        [Given(@"the user presses the button ""([^""]*)""")]
        public void GivenTheUserPressesTheButton(string operation)
        {
            if (operation == "+")
            {
                _count = 2;
            }
            else if (operation == "-")
            {
                _count = 1;
            }
            else if (operation == "*")
            {
                _count = 3;
            }
            else if (operation == "/")
            {
                _count = 4;
            }
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(float res)
        {
            Assert.AreEqual(res, Logic.compute(_num1, _num2, _count), 0.001);
        }

    }
}