Feature: Calculator


Scenario: Add two numbers 1 + 1
	Given the first number is 3
	And the second number is 2
	When the two numbers are added
	Then the result should be 5

Scenario: Add two numbers 1 + 0
	Given the first number is 0
	And the second number is 1
	When the two numbers are added
	Then the result should be 1

Scenario: Add two numbers 1 + (-1)
	Given the first number is 1
	And the second number is -1
	When the two numbers are added
	Then the result should be 0
	
Scenario Outline: Add two numbers examples
	Given the first number is <FirstNumber>
	And the second number is <SecondNumber>
	When the two numbers are added
	Then the result should be <Result>
	Examples: 
	| FirstNumber | SecondNumber | Result |
	| 3           | 2            | 5      |
	| 0           | 1            | 1      |
	| -1          | 0            | -1     |
	| -1          | 1            | 0      |
