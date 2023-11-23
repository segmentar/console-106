using NotCore;

namespace NotCore
{
	using System;

	internal partial struct TestData
	{

		public override String ToString()
		{
			return String.Join('\n'.ToString(), new String[] {

				String.Empty + nameof(Test) + ' ' + "::" + ' ' + nameof(TestData) + ' ' + '{',
				String.Empty + '.' + "data",
				String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
				String.Empty + '}'
			});
		}
	}
}