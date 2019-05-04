using System.Collections.Generic;

namespace Optymus.SpecFlowExtension
{
	public class DataContext : IDataContext
	{
		public Dictionary<string, object> Current { get; set; }

		public DataContext()
		{
			Current = new Dictionary<string, object>();
		}
	}
}