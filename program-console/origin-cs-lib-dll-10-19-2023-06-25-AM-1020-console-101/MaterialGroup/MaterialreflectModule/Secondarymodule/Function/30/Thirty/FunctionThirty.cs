using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionThirty
        {
            public FunctionTwenty Left;

            public FunctionTwenty Right;

            public Int32 Rank;

            public MaterialStringSafe ValueString;

            public FunctionThirty(FunctionTwenty left, FunctionTwenty right, Int32 rank, MaterialStringSafe valueString)
            {
                this.Left = left;

                this.Right = right;

                this.Rank = rank;

                this.ValueString = valueString;

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
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Left) + ':' + ' ' + ". . ." + ' ' + $"<{(Left == default)}>",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(Right) + ':' + ' ' + ". . ." + ' ' + $"<{(Right == default)}>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(Rank) + ':' + ' ' + Rank,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(ValueString) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(ValueString) + ':' + ' ' + $"<safe><<{ValueString.StringValueSafe}>>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(Left) + ':',
                    String.Empty + Left,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(Right) + ':',
                    String.Empty + Right
                });
            }
        }
    }
}
