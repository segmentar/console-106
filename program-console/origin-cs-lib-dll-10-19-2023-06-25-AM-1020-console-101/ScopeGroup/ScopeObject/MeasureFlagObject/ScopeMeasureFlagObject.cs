using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureFlag
    {
        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureFlag) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(EndOfFileArrayFlag) + ':' + ' ' + EndOfFileArrayFlag,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(EndOfFileFlag) + ':' + ' ' + EndOfFileFlag,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(LocalLineFlag) + ':' + ' ' + LocalLineFlag,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(GlobalLineFlag) + ':' + ' ' + GlobalLineFlag,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(MaterialHeaderFlag) + ':' + ' ' + MaterialHeaderFlag,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(MaterialFooterFlag) + ':' + ' ' + MaterialFooterFlag,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(MaterialValidateFlag) + ':' + ' ' + MaterialValidateFlag,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(ScopeShutdownFlag) + ':' + ' ' + ScopeShutdownFlag,
                String.Empty + '}'
            });
        }
    }
}
