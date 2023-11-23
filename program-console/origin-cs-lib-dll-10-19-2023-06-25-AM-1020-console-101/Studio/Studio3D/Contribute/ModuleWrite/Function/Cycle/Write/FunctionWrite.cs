using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteCycle
    {
        [ContributeIntentionalShortClass]
        public partial class FunctionWrite
        {
            public Contribute[] ContributeArray;

            public Int32 Length;

            public FunctionWrite(Contribute[] contributeArray, Int32 length)
            {
                this.ContributeArray = contributeArray;

                this.Length = length;

                return;
            }

            ~FunctionWrite()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ContributeModuleWriteCycle) + ' ' + "::" + ' ' + nameof(FunctionWrite) + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ContributeArray) + ':' + ' ' + ". . ." + ' ' + $"<{ContributeArray.Length}>",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(Length) + ':' + ' ' + Length,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ContributeArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), (Object[])(ContributeArray as Array))
                });
            }
        }
    }
}
