using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionTen
        {
            public Tuple<Materialquery, SecondarymoduleFunctionSeventyPort>[] TupleArray;

            public FunctionTen(Tuple<Materialquery, SecondarymoduleFunctionSeventyPort>[] tupleArray)
            {
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
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + Material.SolidTupleArray<Tuple<Materialquery, SecondarymoduleFunctionSeventyPort>>(TupleArray)
                });
            }
        }
    }
}
