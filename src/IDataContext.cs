using System.Collections.Generic;

namespace Optymus.SpecFlowExtension
{
	public interface IDataContext
	{
		Dictionary<string, object> Current { get; set; }
	}
}