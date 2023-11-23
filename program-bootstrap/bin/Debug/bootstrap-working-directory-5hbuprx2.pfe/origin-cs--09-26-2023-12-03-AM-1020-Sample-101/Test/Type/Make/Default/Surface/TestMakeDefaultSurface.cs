using NotCore;

namespace NotCore
{
	using System;

	internal partial class Test
	{
		internal static Test MakeTestDefaultSurface()
		{
			Test testResult = default;

			testResult = MakeTestDefault(TestPolicy.TestDebugPolicy);

			return testResult;
		}
	}
}