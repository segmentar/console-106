using NotCore;

namespace NotCore
{
	using System;

	internal partial class Test
	{
		internal static Test MakeTestDefault(Boolean debug)
		{
			Test testResult = default;

			var result = new TestSequence(debug).Result;

			TestPolicy.TestArrayList.Add(result);

			testResult = result;

			return testResult;
		}
	}
}