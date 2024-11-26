Feature: Login

  Scenario: Valid Login
    Given User is on the login page
    When User enters valid credentials
    And User clicks the login button
    Then User should be logged in successfully

  Scenario: Invalid Login
    Given User is on the login page
    When User enters invalid credentials
    And User clicks the login button
    Then User should see an error message

  Scenario: Empty Username
    Given User is on the login page
    When User leaves the username field empty
    And User enters a valid password
    And User clicks the login button
    Then User should see an error message about entering a username

  Scenario: Empty Password
    Given User is on the login page
    When User enters a valid username
    And User leaves the password field empty
    And User clicks the login button
    Then User should see an error message about entering a password