using System;
using BoDi;
using Optymus.SpecFlowExtension.Configuration;
using TechTalk.SpecFlow;

namespace Optymus.SpecFlowExtension
{
	[Binding]
	public sealed class FrameworkHooks
	{
		private readonly IObjectContainer container;
		private readonly IEnvironment environment;

		public FrameworkHooks(IObjectContainer container)
		{
			this.container = container;
			this.environment = TestEnvironment.Current;

			container.RegisterInstanceAs<IEnvironment>(this.environment);
		}

		[BeforeTestRun(Order = 0)]
		public static void BeforeTestRun()
		{
			Console.WriteLine("Start Tests");
		}

		[BeforeFeature(Order =0)]
		public static void BeforeFeature()
		{

		}

		[BeforeScenario(Order = 0)]
		public void BeforeTest()
		{

		}
	}
}
