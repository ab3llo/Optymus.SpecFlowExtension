using BoDi;
using TechTalk.SpecFlow;

namespace Optymus.SpecFlowExtension.FrameworkHooks
{
	public class FrameworkHooks
	{
		private readonly IObjectContainer objectContainer;
		private readonly ScenarioContext _scenarioContext;
		private readonly FeatureContext _featureContext;

		public FrameworkHooks(IObjectContainer objectContainer)
		{
			this.objectContainer = objectContainer;
		}

		[BeforeTestRun()]
		public void BeforeTestRun()
		{
			IEnvironment environment = TestEnvironment.Environment;
			objectContainer.RegisterInstanceAs<IEnvironment>(environment);
		}

		[BeforeScenario(Order = 0)]
		public void BeforeTest()
		{

		}
	}
}
