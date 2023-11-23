using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        [IntentionalShortClass]
        public partial class ExpressionModuleFunctionTwenty
        {
            public Tuple<Int32, Int32, Int32, Int32, String>[] TupleArray;

            public ExpressionModuleFunctionTwenty(Tuple<Int32, Int32, Int32, Int32, String>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~ExpressionModuleFunctionTwenty()
            {
                return;
            }

            [IntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(ExpressionModuleFunctionTwenty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Int32, Int32, Int32, Int32, String>>(TupleArray)
                });
            }
        }
    }
}
