using Core;

namespace Core
{
    using System;

    public partial struct ContributeModuleWriteInline
    {
        [ContributeIntentionalShortClass]
        public partial struct ContributeModuleThirty
        {
            public Tuple<Int32, Int32, Int32, Contribute>[] TupleArrayA;

            public Tuple<Int32, Int32, Int32, Contribute>[] TupleArrayB;

            public Tuple<Int32, Int32, Int32, Contribute>[] TupleArrayC;

            public Tuple<Int32, Int32, Int32, Contribute>[] TupleArrayD;

            [ContributeIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(ContributeModuleWriteInline) + ' ' + "::" + ' ' + nameof(ContributeModuleThirty) + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + nameof(TupleArrayA) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArrayA.Length}>",
                    String.Empty + '\t' + nameof(TupleArrayB) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArrayB.Length}>",
                    String.Empty + '\t' + nameof(TupleArrayC) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArrayC.Length}>",
                    String.Empty + '\t' + nameof(TupleArrayD) + ':' + ' ' + ". . ." + ' ' + $"<{TupleArrayD.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(TupleArrayA) + ':',
                    String.Empty + Contribute.SolidTupleArray<Tuple<Int32, Int32, Int32, Contribute>>(TupleArrayA),
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(TupleArrayB) + ':',
                    String.Empty + Contribute.SolidTupleArray<Tuple<Int32, Int32, Int32, Contribute>>(TupleArrayB),
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(TupleArrayC) + ':',
                    String.Empty + Contribute.SolidTupleArray<Tuple<Int32, Int32, Int32, Contribute>>(TupleArrayC),
                    String.Empty,
                    String.Empty + '~' + "40" + ' ' + nameof(TupleArrayD) + ':',
                    String.Empty + Contribute.SolidTupleArray<Tuple<Int32, Int32, Int32, Contribute>>(TupleArrayD)
                });
            }
        }
    }
}
