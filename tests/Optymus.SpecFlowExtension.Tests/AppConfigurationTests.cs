using System;
using TechTalk.SpecFlow;

namespace Optymus.SpecFlowExtension.Tests
{
	[Binding]
	public class AppConfigurationTests
	{
		private readonly FeatureContext featureContext;
		private readonly IEnvironment environment;

		public AppConfigurationTests(FeatureContext featureContext, IEnvironment environment)
		{
			this.featureContext = featureContext;
			this.environment = environment;
			Console.WriteLine(this.environment);
		}

		[Given("I have entered (.*) into the calculator")]
		public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
		{
		}

		[When("I press add")]
		public void WhenIPressAdd()
		{
		}

		[Then("the result should be (.*) on the screen")]
		public void ThenTheResultShouldBe(int result)
		{
		}
	}
}