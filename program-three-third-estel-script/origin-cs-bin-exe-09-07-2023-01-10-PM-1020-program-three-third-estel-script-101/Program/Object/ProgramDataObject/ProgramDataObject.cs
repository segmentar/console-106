using Core;

namespace Core
{
	using System;

	internal partial struct ProgramData
	{

        [IntentionalShort]
        public override String ToString()
		{
			return String.Join('\n'.ToString(), new String[] {

				String.Empty + nameof(Program) + ' ' + "::" + ' ' + nameof(ProgramData) + ' ' + '{',
				String.Empty + '.' + "data",
				String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
				String.Empty + '}'
			});				
		}
	}
}