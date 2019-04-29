using TechTalk.SpecFlow;

namespace Optymus.SpecFlowExtension.FrameworkHooks
{
	public class FrameworkHooks
	{
		private readonly ScenarioContext _scenarioContext;
		private readonly FeatureContext _featureContext;

		public FrameworkHooks(ScenarioContext scenarioContext, FeatureContext featureContext)
		{
			_scenarioContext = scenarioContext;
			_featureContext = featureContext;
		}

		[BeforeTestRun()]
		public void BeforeTestRun()
		{

		}

		[BeforeScenario(Order = 0)]
		public void BeforeTest()
		{

		}
	}
}
