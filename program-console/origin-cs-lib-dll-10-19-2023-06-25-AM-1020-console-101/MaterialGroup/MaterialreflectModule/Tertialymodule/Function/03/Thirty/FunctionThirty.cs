using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionThirty
        {
            public Materialchain Materialchain;

            public FunctionThirty(Materialchain materialchain)
            {
                this.Materialchain = materialchain;

                return;
            }

            ~FunctionThirty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionThirty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Materialchain) + ':' + ' ' + ". . .",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(Materialchain) + ':',
                    String.Empty + Materialchain
                });
            }
        }
    }
}
