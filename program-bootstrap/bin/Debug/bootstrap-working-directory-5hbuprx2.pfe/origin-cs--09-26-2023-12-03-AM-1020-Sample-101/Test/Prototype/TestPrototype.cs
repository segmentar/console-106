using NotCore;

namespace NotCore
{
	using System;

	internal partial class Test
	{
		internal Test(Boolean debug)
		{
			TestData data;

			data = new TestData();

			if (debug is true)
			{

				data.IsDebug = true;
			}
			else
				"false".ToString();

			this.Data = data;

			return;
		}
	}
}