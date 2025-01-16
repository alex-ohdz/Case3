Feature: Square Root
  As a calculator user
  I want to calculate the square root of a number
  So that I can verify mathematical operations

  Scenario Outline: Calculate square root of a number
    Given the number is <number>
    When I calculate its square root
    Then the square root should be <result>

    Examples:
      | number | result |
      | 1      | 1      |
      | 4      | 2      |
      | 9      | 3      |
      | 16     | 4      |
      | 100    | 10     |
      | 144    | 12     |
