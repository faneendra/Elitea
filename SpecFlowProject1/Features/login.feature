Feature: Login Functionality

  Scenario: Successful login
    Given I am on the SauceDemo login page
    When I enter valid credentials
    Then I should be redirected to the products page