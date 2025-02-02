* NUnit 4.x + .Net 9.0
* Functional scenario => GoogleSearchTutorialTest
* POM => GoogleHomePage
* Added BrowserConfig class with options depends on env variable, called 'DRIVER'
* Added MakeAScreenshot class for failed scenarios
* Added Logger (right now only for better view of each step, later could be extended)
* Added BeforeWebConfiguration to store [SetUp] and [TearDown] configuration applicable for all future tests
* Pipeline configuration is store in 'pipeline.yml' file

I apologize for the optional files and folders in the project.
I will need some time to understand what is misc and what isn't 