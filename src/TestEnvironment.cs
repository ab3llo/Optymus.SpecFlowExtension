using System.Collections.Specialized;
using System.Configuration;

namespace Optymus.SpecFlowExtension
{
	public class TestEnvironment : IEnvironment
	{
		public NameValueCollection configuration;
		public static TestEnvironment Environment;

		private TestEnvironment()
		{
			if (configuration != null)
			{
				configuration = ConfigurationManager.AppSettings;
			}
		}

		static TestEnvironment() 
		{
			if (Environment == null)
			{
				Environment = new TestEnvironment();
			}
		}
	}
}
