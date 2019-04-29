using System;
using TechTalk.SpecFlow;

namespace SpecFlowExtension.FrameworkHooks
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

		[BeforeFeature(Order = 0)]
		public void BeforeFeature()
		{

		}

		[BeforeScenario(Order = 0)]
		public void BeforeTest()
		{

		}
	}
}
