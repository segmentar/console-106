using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionTen
        {
            public Tuple<Char, Char, Boolean>[] TupleArray;

            public FunctionTen(Tuple<Char, Char, Boolean>[] tupleArray)
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
                    String.Empty + Material.SolidTupleArray<Tuple<Char, Char, Boolean>>(TupleArray)
                });
            }
        }
    }
}
