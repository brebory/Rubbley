using System;
using System.Collections.Generic;

namespace Rubbley
{
	public class ConfigurationManager
	{
		private IDictionary _opts;

		public ConfigurationManager()
		{
			_opts = new Dictionary<String, object>();
		}

		public object getKeyWithDefault(String key, object defaultValue)
		{

			if (_opts.ContainsKey(key)) {
				return _opts.TryGetValue(key);
			}

			return defaultValue;
		}
	}
}

