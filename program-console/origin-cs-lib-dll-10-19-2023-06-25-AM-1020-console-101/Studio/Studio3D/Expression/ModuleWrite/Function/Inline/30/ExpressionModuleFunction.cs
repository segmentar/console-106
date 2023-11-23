using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleWrite
    {
        [IntentionalShortClass]
        public partial class ExpressionModuleFunctionThirty
        {
            public Tuple<Int32, Int32, Int32, Int32, Expression>[] TupleArray;

            public ExpressionModuleFunctionThirty(Tuple<Int32, Int32, Int32, Int32, Expression>[] array_TUPLE)
            {
                TupleArray = array_TUPLE;

                return;
            }

            ~ExpressionModuleFunctionThirty()
            {
                return;
            }


            [IntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(ExpressionModuleFunctionThirty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Int32, Int32, Int32, Int32, Expression>>(TupleArray)
                });
            }
        }
    }
}
