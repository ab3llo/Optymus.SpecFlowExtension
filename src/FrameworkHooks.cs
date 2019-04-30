using System;
using BoDi;
using TechTalk.SpecFlow;

namespace Optymus.SpecFlowExtension.FrameworkHooks
{
	[Binding]
	public class FrameworkHooks
	{
		private readonly IObjectContainer objectContainer;
		private readonly FeatureContext featureContext;
		private readonly IEnvironment environment;

		public FrameworkHooks(IObjectContainer objectContainer)
		{
			this.objectContainer = objectContainer;
			this.environment = TestEnvironment.Current;
			this.objectContainer.RegisterInstanceAs<IEnvironment>(this.environment);
		}

		[BeforeFeature()]
		public static void BeforeTestRun()
		{
			Console.WriteLine("Hello");
		}

		[BeforeScenario(Order = 0)]
		public void BeforeTest()
		{

		}
	}
}
