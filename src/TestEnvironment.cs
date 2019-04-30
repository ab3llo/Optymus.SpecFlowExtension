using System.Collections.Specialized;
using System.Configuration;

namespace Optymus.SpecFlowExtension
{
	public class TestEnvironment : IEnvironment
	{
		public NameValueCollection configuration;
		public static TestEnvironment Current { get; }

		public string BaseUrl { get; }

		private TestEnvironment()
		{
			if (this.configuration != null)
			{
				this.configuration = ConfigurationManager.AppSettings;
				BaseUrl = this.configuration["BaseUrl"];
			}
		}

		static TestEnvironment() 
		{
			if (Current == null)
			{
				Current = new TestEnvironment();
			}
		}
	}
}
