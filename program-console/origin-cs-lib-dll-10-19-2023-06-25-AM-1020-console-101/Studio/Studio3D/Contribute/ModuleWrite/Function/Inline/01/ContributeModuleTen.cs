using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteInline
    {
        [ContributeIntentionalShortClass]
        public partial class ModuleTen
        {
            public Tuple<Int32, Contribute>[] TupleArray;

            public ModuleTen(Tuple<Int32, Contribute>[] tupleArray)
            {
                this.TupleArray = tupleArray;

                return;
            }

            ~ModuleTen()
            {
                return;
            }

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ModuleTen) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(TupleArray) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArray) + ':',
                    String.Empty + Contribute.SolidTupleArray<Tuple<Int32, Contribute>>(TupleArray)
                });
            }
        }
    }
}
