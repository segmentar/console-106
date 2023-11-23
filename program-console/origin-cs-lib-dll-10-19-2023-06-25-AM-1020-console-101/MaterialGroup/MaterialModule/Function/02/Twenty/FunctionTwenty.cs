using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class FunctionTwenty
    {
        public Tuple<Int32, String>[] TupleArray;

        public FunctionTwenty(Tuple<Int32, String>[] tupleArray)
        {
            this.TupleArray = tupleArray;

            return;
        }

        ~FunctionTwenty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(FunctionTwenty) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "function",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                String.Empty + Material.SolidTupleArray<Tuple<Int32, String>>(TupleArray)
            });
        }
    }
}
