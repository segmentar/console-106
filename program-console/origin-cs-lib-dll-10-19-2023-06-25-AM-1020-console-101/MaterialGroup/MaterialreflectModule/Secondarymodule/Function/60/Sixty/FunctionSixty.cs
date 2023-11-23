using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionSixty
        {
            public FunctionFifty Function;

            public MaterialStringArraySafe SegmentArray;

            public MaterialStringSafe IdentityName;

            public MaterialStringSafe VirtualName;

            public Boolean StickyLeft;

            public Boolean StickyRight;

            public FunctionSixty(FunctionFifty function, MaterialStringArraySafe segmentArray, MaterialStringSafe identityName, MaterialStringSafe virtualName, Boolean stickyLeft, Boolean stickyRight)
            {
                this.Function = function;

                this.SegmentArray = segmentArray;

                this.IdentityName = identityName;

                this.VirtualName = virtualName;

                this.StickyLeft = stickyLeft;

                this.StickyRight = stickyRight;

                return;
            }

            ~FunctionSixty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionSixty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Function) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(SegmentArray) + ':' + ' ' + ". . ." + ' ' + $"<{SegmentArray.StringArray.Length}>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(IdentityName) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(IdentityName) + ':' + ' ' + $"<safe><<{IdentityName.StringValueSafe}>>",
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(VirtualName) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(VirtualName) + ':' + ' ' + $"<safe><<{VirtualName.StringValueSafe}>>",
                    String.Empty + '\t' + '~' + "07" + ' ' + nameof(StickyLeft) + ':' + ' ' + StickyLeft,
                    String.Empty + '\t' + '~' + "08" + ' ' + nameof(StickyRight) + ':' + ' ' + StickyRight,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(Function) + ':',
                    String.Empty + Function,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(SegmentArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), SegmentArray.StringArraySafe)
                });
            }
        }
    }
}
