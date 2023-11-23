using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {

        [MaterialIntentionalShortClass]
        public partial class FunctionTwenty
        {
            public Tuple<Char, String[]>[] TupleArray;

            public FunctionTwenty(Tuple<Char, String[]>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~FunctionTwenty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionTwenty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + Material.SolidTupleArray<Tuple<Char, String[]>>(TupleArray)
                });
            }
        }
    }
}
