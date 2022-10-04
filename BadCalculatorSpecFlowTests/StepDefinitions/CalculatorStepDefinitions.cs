using BadCalculator;

namespace BadCalculatorSpecFlowTests.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Form1 _calculator = new Form1();

        [Given(@"the user enters the first number ""([^""]*)""")]
        public void GivenTheUserEntersTheNumber(float num)
        {
            _calculator.setNumber1(num);
        }

        [Given(@"the user enters the second number ""([^""]*)""")]
        public void GivenTheUserEntersTheSecondNumber(float num)
        {
            _calculator.num2 = num;
        }


        [Given(@"the user presses the button ""([^""]*)""")]
        public void GivenTheUserPressesTheButton(string operation)
        {
            if(operation == "+")
            {
                _calculator.count = 2;
            }
            else if (operation == "-")
            {
                _calculator.count = 1;
            }
            else if (operation == "*")
            {
                _calculator.count = 3;
            }
            else if (operation == "/")
            {
                _calculator.count = 4;
            }
        }



    }
}