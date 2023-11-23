using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        [IntentionalShortClass]
        public partial class ExpressionModuleFunctionFourty
        {
            public Tuple<Int32, Int32, Int32, Int32, String>[] TupleArray;

            public ExpressionModuleFunctionFourty(Tuple<Int32, Int32, Int32, Int32, String>[] array_TUPLE)
            {
                TupleArray = array_TUPLE;

                return;
            }

            ~ExpressionModuleFunctionFourty()
            {
                return;
            }


            [IntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(ExpressionModuleFunctionFourty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Int32, Int32, Int32, Int32, String>>(TupleArray)
                });
            }
        }
    }
}
