using System.Collections.Specialized;
using System.Configuration;
using System.Reflection;
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
			ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap
			{
				ExeConfigFilename = Assembly.GetExecutingAssembly().ManifestModule.Name + ".config"
			};

			var configuration = ConfigurationManager.OpenMappedExeConfiguration(configFileMap,ConfigurationUserLevel.None);
			environment.BaseUrl = configuration.AppSettings.Settings["BaseUrl"].Value;

		}

	}
}
