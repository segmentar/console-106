using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionSeventy
        {
            public SecondarymoduleFunctionSeventyPort[] FunctionArray;

            public FunctionSeventy(SecondarymoduleFunctionSeventyPort[] functionArray)
            {
                this.FunctionArray = functionArray;

                return;
            }

            ~FunctionSeventy()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionSeventy) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(FunctionArray) + ':' + ' ' + ". . ." + ' ' + $"<{FunctionArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(FunctionArray) + ":",
                    String.Empty + String.Join('\n'.ToString(), (Object[])(FunctionArray as Array))
                });
            }
        }
    }
}
