Feature: Bad Calculator

@ExampleTag
Scenario: Add two numbers
	Given the user enters the first number "2"
	And the user presses the button "+"
	And the user enters the second number "3"
	Then the result should be "5"

@ExampleTag
Scenario: Multiply two numbers (failed)
	Given the user enters the first number "4"
	And the user presses the button "*"
	And the user enters the second number "3"
	Then the result should be "10"
