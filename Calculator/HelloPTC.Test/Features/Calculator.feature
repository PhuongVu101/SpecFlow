Feature: Calculator

Scenario Outline: Add two numbers examples
	Given the first number is <FirstNumber>
	And the second number is <SecondNumber>
	When the two numbers are added
	Then the result should be <Result>
	Examples: 
	| FirstNumber | SecondNumber | Result |
	| 1           | 1            | 2      |
	| 1           | 0            | 1      |
	| 1           | -1           | 0      |