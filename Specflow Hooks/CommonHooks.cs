using System;
using TechTalk.SpecFlow;
	
namespace SeleniumWebdriver
{
	[Binding]
	public class CommonHooks
	{
		[BeforeFeature]
        public static void SetupBrowser(FeatureContext context)
        {
            Base.SetupBrowser();
            Base.GoToURL(new JupiterToys_Menu("Home").JupiterToys_Default_Page_URL);
            ExtentReportsHelper.CreateNewReport();
            ExtentReportsHelper.CreateFeatureReport(context);
        }
		
		[AfterFeature]
        public static void TeardownBrowser()
        {	
            Base.WebDriver.Quit();
            ExtentReportsHelper.EndReport();
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext context)
        {
            ExtentReportsHelper.CreateScenarioReport(context);
        }

        [AfterStep]
        public static void AfterStep(ScenarioContext context)
        {
            ExtentReportsHelper.CreateStepReport(context);
        }

	}
}