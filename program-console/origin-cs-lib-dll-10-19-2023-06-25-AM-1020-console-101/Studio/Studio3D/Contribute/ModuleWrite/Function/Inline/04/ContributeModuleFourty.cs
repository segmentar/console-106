using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteInline
    {
        [ContributeIntentionalShortClass]
        public partial class ContributeModuleFourty
        {
            public Byte[] ByteArray;

            public ContributeModuleFourty(Byte[] byteArray)
            {
                this.ByteArray = byteArray;

                return;
            }

            ~ContributeModuleFourty()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(ContributeModuleWriteInline) + ' ' + "::" + ' ' + nameof(ContributeModuleFourty) + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + nameof(ByteArray) + ':' + ' ' + ". . ." + ' ' + $"<{ByteArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ByteArray) + ':',
                    String.Empty + BitConverter.ToString(((ByteArray == default) ? new Byte[0] : ByteArray)),
                });
            }
        }
    }
}
