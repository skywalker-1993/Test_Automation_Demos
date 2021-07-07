*** Settings ***
Library    SeleniumLibrary

*** Variables ***
${BROWSER}=     firefox
${URL}=     https://www.amazon.com

*** Test Cases ***
Test Case 1
    log     ${URL}
    open browser    ${URL}  ${BROWSER}
    maximize browser window
    sleep   2
    #Click Element  id=nav-cart
    #Click Element   xpath=/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[1]/div/div
    #wait until element is visible   //select[contains(@aria-describedby,'searchDropdownDescription')]
    Click Element   xpath=//div[@id="nav-search-dropdown-card"]
    click element  xpath=//select/option[@value="search-alias=arts-crafts-intl-ship"]
    close browser