using Core;

namespace Core
{
	using System;

	internal partial class Program
	{

        [IntentionalShort]
        public override String ToString()
		{
			return Data.ToString();
		}
	}
}