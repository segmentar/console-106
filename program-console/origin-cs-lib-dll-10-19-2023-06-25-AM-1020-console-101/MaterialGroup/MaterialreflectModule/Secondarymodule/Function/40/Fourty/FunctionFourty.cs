using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionFourty
        {
            public FunctionThirty Function;

            public Int32 Layer;

            public FunctionFourty(FunctionThirty function, Int32 layer)
            {
                this.Function = function;

                this.Layer = layer;

                return;
            }

            ~FunctionFourty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionFourty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Function) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(Layer) + ':' + ' ' + Layer,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "01" + ' ' + nameof(Function) + ':',
                    String.Empty + Function
                });
            }
        }
    }
}
