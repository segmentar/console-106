using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionEighty
        {
            public SecondarymoduleFunctionEightyPort[] FunctionArray;

            public FunctionEighty(SecondarymoduleFunctionEightyPort[] functionArray)
            {
                this.FunctionArray = functionArray;

                return;
            }

            ~FunctionEighty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionEighty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(FunctionArray) + ':' + ' ' + ". . ." + ' ' + $"<{FunctionArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(FunctionArray) + ":",
                    String.Empty + String.Join('\n'.ToString(), FunctionArray)
                });
            }
        }
    }
}
