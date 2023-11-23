using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectPrimarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionThirty
        {
            public Tuple<Char, String[], String[]>[] TupleArray;

            public FunctionThirty(Tuple<Char, String[], String[]>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~FunctionThirty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionThirty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + Material.SolidTupleArray<Tuple<Char, String[], String[]>>(TupleArray)
                });
            }
        }
    }
}
