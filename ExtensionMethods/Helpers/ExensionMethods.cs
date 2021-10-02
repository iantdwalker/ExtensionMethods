using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Helpers
{
	public static class ExensionMethods
	{
		public static string Combine(this string value)
		{
			return value + " appended";
		}
	}
}
