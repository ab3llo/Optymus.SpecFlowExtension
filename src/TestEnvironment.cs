using System.Collections.Specialized;
using System.Configuration;
using Optymus.SpecFlowExtension.Configuration;

namespace Optymus.SpecFlowExtension
{
	public class TestEnvironment : IEnvironment
	{
		public NameValueCollection configuration;
		public static TestEnvironment Current { get; }

		public string BaseUrl { get; private set; }

		static TestEnvironment() 
		{
			if (Current == null)
			{
				Current = new TestEnvironment();
				InitConfig(Current);
			}
		}

		private static void InitConfig(TestEnvironment environment)
		{
			environment.configuration = ConfigurationManager.AppSettings;
			environment.BaseUrl = environment.configuration["BaseUrl"];

		}

	}
}
