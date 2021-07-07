# from selenium import webdriver
from robot.api import TestSuite
from robot.api import ResultWriter
import pandas as pd


df = pd.read_csv('Master_Input.csv')
# print(df)

suite = TestSuite('Amazon_Test_Suite')
suite.resource.imports.library('SeleniumLibrary')
suite.resource.imports.library('functions.py')

for [test_case, user] in df.values:
    # print(test_case, user)
    search_item = test_case.lower().split(' ')[-1].strip()
    # print(search_item)
    # print(test_case)
    test = suite.tests.create(test_case)
    test.keywords.create('open browser', args=['https://www.amazon.co.uk', 'firefox'])
    test.keywords.create('maximize browser window')
    test.keywords.create('input text', args=['xpath=//input[@id="twotabsearchtextbox"]', search_item])
    test.keywords.create('click element', args=['xpath=//input[@id="nav-search-submit-button"]'])
    test.keywords.create('get text', args=['xpath=//span[@dir="auto"]'], assign=['${my_text}'])
    test.keywords.create('retrieve result count', args=['${my_text}'])
    test.keywords.create('sleep', args=[5])
    test.keywords.create('close browser')


suite.run(output='output.xml')
ResultWriter('output.xml').write_results(report='report.html', log='log.html')

'''driver = webdriver.Firefox()
driver.get('https://www.amazon.com/')

driver.find_element_by_id('twotabsearchtextbox').send_keys('laptops')
driver.find_element_by_id('nav-search-submit-button').click()'''
