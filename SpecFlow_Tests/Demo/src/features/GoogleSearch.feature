Feature: Google Search
    As a web surfer, I want to search Google, so that I can learn new things.

    Scenario: Simple Google search
        Given I am on the Google search page
        When I search phrase "dinosaur"
        Then results for "dinosaur" are displayed