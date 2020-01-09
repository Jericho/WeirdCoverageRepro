using System;

namespace WeirdCoverageRepro
{
	public static class Class1
	{
		public static string Foo(this string target)
		{
			if (target == null) throw new ArgumentNullException(nameof(target));
			return "Hello World!";
		}
	}
}
