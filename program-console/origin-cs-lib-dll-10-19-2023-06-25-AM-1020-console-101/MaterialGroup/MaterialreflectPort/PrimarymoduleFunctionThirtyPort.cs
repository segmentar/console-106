using Core;

namespace Core
{
    using System;

    [MaterialIntentionalShortClass]
    public partial class PrimarymoduleFunctionThirtyPort
    {
        public Tuple<Char, String[], String[]>[] TupleArray;

        public PrimarymoduleFunctionThirtyPort(Tuple<Char, String[], String[]>[] tupleArray)
        {
            this.TupleArray = tupleArray;

            return;
        }

        ~PrimarymoduleFunctionThirtyPort()
        {
            return;
        }

        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(PrimarymoduleFunctionThirtyPort) + ' ' + "::" + ' ' + '{',
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
