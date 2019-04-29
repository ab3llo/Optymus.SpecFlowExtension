using System;
using BoDi;
using NUnit.Framework;
using Optymus.SpecFlowExtension;
using TechTalk.SpecFlow;

namespace Tests
{
	[Binding]
	public class TestsSteps
	{
		private readonly FeatureContext featureContext;

		public TestsSteps(FeatureContext featureContext, IObjectContainer objectContainer)
		{
			this.featureContext = featureContext;
			Console.WriteLine(featureContext.Get<IEnvironment>());
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