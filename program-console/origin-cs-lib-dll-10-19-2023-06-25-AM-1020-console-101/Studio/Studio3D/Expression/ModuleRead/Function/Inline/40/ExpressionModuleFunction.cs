using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        [IntentionalShortClass]
        public partial class ExpressionModuleFunctionFourty
        {
            public Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression>[] TupleArray;

            public ExpressionModuleFunctionFourty(Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression>[] tupleArray)
            {
                this.TupleArray = tupleArray;

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
                    String.Empty + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Int32, Int32, Int32, Int32, String, Byte[], Expression>>(TupleArray)
                });
            }
        }
    }
}
