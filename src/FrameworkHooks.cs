using BoDi;
using TechTalk.SpecFlow;

namespace Optymus.SpecFlowExtension.FrameworkHooks
{
	[Binding]
	public class FrameworkHooks
	{
		private readonly IObjectContainer objectContainer;
		private readonly ScenarioContext _scenarioContext;
		private readonly FeatureContext featureContext;

		public FrameworkHooks(FeatureContext featureContext)
		{
			this.featureContext = featureContext;
		}

		[BeforeFeature()]
		public void BeforeTestRun()
		{
			IEnvironment environment = TestEnvironment.GetEnvironment;
			this.featureContext.Set(environment);
			objectContainer.RegisterInstanceAs<IEnvironment>(environment);
		}

		[BeforeScenario(Order = 0)]
		public void BeforeTest()
		{

		}
	}
}
