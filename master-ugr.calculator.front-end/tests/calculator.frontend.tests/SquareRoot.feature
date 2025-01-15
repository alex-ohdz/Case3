Feature: SquareRoot
    As Pepe (the customer)
    I want to know the square root of a number
    So I can use it in my mathematics class

Scenario Outline: A number has a square root calculated correctly
    Given a number <number>
    When I calculate its square root
    Then the square root should be <result>
    Examples: 
    | number | result |
    | 1      | 1      |
    | 4      | 2      |
    | 9      | 3      |
    | 16     | 4      |
    | 25     | 5      |
    | 49     | 7      |
    | 100    | 10     |
    | 144    | 12     |
    | 1024   | 32     |
    | 10000  | 100    |

