using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        [IntentionalShortClass]
        public partial class ExpressionModuleFunctionThirty
        {
            public Tuple<Int32, Int32, Int32, Int32, String, Byte[]>[] TupleArray;

            public ExpressionModuleFunctionThirty(Tuple<Int32, Int32, Int32, Int32, String, Byte[]>[] tupleArray)
            {
                this.TupleArray = tupleArray;

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
                    String.Empty + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + ConsoleLJS.SafeTupleArrayString<Tuple<Int32, Int32, Int32, Int32, String, Byte[]>>(TupleArray)
                });
            }
        }
    }
}
