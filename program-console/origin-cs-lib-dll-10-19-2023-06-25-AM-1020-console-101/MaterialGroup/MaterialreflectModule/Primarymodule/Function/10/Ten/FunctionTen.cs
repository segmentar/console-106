using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionTen
        {
            public MaterialStringSafe StringResult;

            public Tuple<Char, String[]>[] TupleArray;

            public FunctionTen(MaterialStringSafe stringResult, Tuple<Char, String[]>[] tupleArray)
            {
                this.StringResult = stringResult;

                this.TupleArray = tupleArray;

                return;
            }

            ~FunctionTen()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionTen) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(StringResult) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(StringResult) + ':' + ' ' + $"<safe><<{StringResult.StringValueSafe}>>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + Material.SolidTupleArray<Tuple<Char, String[]>>(TupleArray)
                });
            }
        }
    }
}
