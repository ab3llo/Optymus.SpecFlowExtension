using System;
using TechTalk.SpecFlow;
using Optymus.SpecFlowExtension.Configuration;
using Optymus.SpecFlowExtension;

namespace Optymus.SpecFlowExtension.Tests
{
	[Binding]
	public class AppConfigurationTests
	{
		private readonly FeatureContext featureContext;

		public IEnvironment Environment { get; }

		public AppConfigurationTests(FeatureContext featureContext, IEnvironment environment)
		{
			this.featureContext = featureContext;
			Environment = environment;
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