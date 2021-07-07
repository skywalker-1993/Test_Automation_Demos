Feature: Search Google & Amazon

    Scenario: Search Something on Google
        Given I am on the Google search page
        When I click the 'I agree' button
        Then I search for Star Wars
        Then I get the number of results
        Then I quit the browser

# Scenario: Search Something on Amazon
#     Given I am on the Amazon search page
#     Then I quit the browser again