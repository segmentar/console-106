using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionFifty
        {
            public FunctionFourty Function;

            public FunctionFourty FunctionParent;

            public ArrayList FunctionArray = new ArrayList();

            public FunctionFifty()
            {
                return;
            }

            ~FunctionFifty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionFifty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Function) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(FunctionParent) + ':' + ' ' + ". . ." + ' ' + $"<{FunctionParent == default}>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(FunctionArray) + ':' + ' ' + ". . ." + ' ' + $"<{FunctionArray.Count}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(Function) + ':',
                    String.Empty + Function,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(FunctionParent) + ':',
                    String.Empty + FunctionParent,
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(FunctionArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), FunctionArray.ToArray())
                });
            }
        }
    }
}
