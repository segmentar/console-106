using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionTwenty
        {
            public Materialquery[] MaterialqueryArray; 

            public FunctionTwenty(Materialquery[] materialqueryArray)
            {
                this.MaterialqueryArray = materialqueryArray;

                return;
            }

            ~FunctionTwenty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionTwenty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(MaterialqueryArray) + ':' + ' ' + ". . ." + ' ' + $"<{MaterialqueryArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(MaterialqueryArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), (Object[])(MaterialqueryArray as Array))
                });
            }
        }
    }
}
