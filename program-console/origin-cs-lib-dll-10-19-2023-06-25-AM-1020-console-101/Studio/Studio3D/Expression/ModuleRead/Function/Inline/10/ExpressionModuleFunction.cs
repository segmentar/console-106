using Core;

namespace Core
{
    using System;

    public partial struct ExpressionModuleRead
    {
        [IntentionalShortClass]
        public partial class ExpressionModuleFunctionTen
        {
            public Tuple<Int32, Int32, Int32> Tuple;

            public ExpressionModuleFunctionTen(Tuple<Int32, Int32, Int32> tuple)
            {
                this.Tuple = tuple;

                return;
            }


            ~ExpressionModuleFunctionTen()
            {
                return;
            }

            [IntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(ExpressionModuleFunctionTen) + ' ' + "::" + ' ' + '{',
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Tuple) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(Tuple) + ':',
                    String.Empty + Tuple
                });
            }
        }
    }
}
