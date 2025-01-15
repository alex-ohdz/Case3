Feature: Calculator
	As Alice (the customer)
	I want to execute binary operations
	So I can save my time


Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Substract two numbers
	Given the first number is 70
	And the second number is 40
	When I substract first number to second number
	Then the result should be 30

Scenario: Product of two numbers
	Given the first number is 30
	And the second number is 30
	When I multiply both numbers
	Then the result shall be 900

Scenario: Division of two numbers
	Given the first number is 20
	And the second number is 4
	When I divide the numbers
	Then the result is 5

Scenario: Division of two numbers returning non integer value
    Given the first number is 10
    And the second number is 4
    When I divide first number by second number
    Then the result is 2.5

Scenario: Division by 0 shall return NaN
    Given the first number is 30
    And the second number is 0
    When I divide the numbers
    Then the result shall be exactly NaN


