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
		private readonly DataContext dataContext;
		public DataContext Current;

		public FrameworkHooks(IObjectContainer container)
		{
			this.container = container;
			this.environment = TestEnvironment.Current;
			this.dataContext = new DataContext();
			Current = this.dataContext;

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
