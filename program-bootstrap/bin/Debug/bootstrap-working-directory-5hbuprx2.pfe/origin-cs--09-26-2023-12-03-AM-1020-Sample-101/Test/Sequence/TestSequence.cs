using NotCore;

namespace NotCore
{
	using System;

	internal partial class TestSequence
	{
		internal Test Result { get; set; } = default;

		internal TestSequence(Boolean debug)
		{
			Debug(debug);

			Test test;

			test = new Test(debug);

			this.Result = test;

			return;
		}

		~TestSequence()
		{
			return;
		}
	}
}