using TechTalk.SpecFlow;
using Optymus.SpecFlowExtension.Configuration;
using NUnit.Framework;

namespace Optymus.SpecFlowExtension.Tests
{
	[Binding]
	public class AppConfigurationTests
	{
		public IEnvironment TestEnvironment { get; }

		public AppConfigurationTests(IEnvironment environment)
		{
			TestEnvironment = environment;
		}


		[Then("correct configuration is loaded")]
		public void ThenTheResultShouldBe(Table table)
		{
			foreach (TableRow row in table.Rows)
			{
				string expectedValue = string.Empty;

				if (row.TryGetValue("BaseUrl", out expectedValue))
				{
					Assert.That(TestEnvironment.BaseUrl, Is.EqualTo(expectedValue), $"The environment BaseUrl {TestEnvironment.BaseUrl} did not match the expected value {expectedValue}");
				}
			}
		}
	}
}