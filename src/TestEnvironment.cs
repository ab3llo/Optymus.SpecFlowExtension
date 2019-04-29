using System.Collections.Specialized;
using System.Configuration;

namespace Optymus.SpecFlowExtension
{
	public class TestEnvironment : IEnvironment
	{
		public NameValueCollection configuration;
		private static TestEnvironment environment;

		private TestEnvironment()
		{
			if (this.configuration != null)
			{
				this.configuration = ConfigurationManager.AppSettings;
			}
		}

		static TestEnvironment() 
		{
			if (environment == null)
			{
				environment = new TestEnvironment();
			}
		}

		public static TestEnvironment GetEnvironment => environment;

	}
}
