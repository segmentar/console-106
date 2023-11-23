using Core;

namespace Core
{
    using System;

    [MaterialIntentionalShortClass]
    public partial class SecondarymoduleFunctionSeventyPort
    {
        public MaterialreflectSecondarymodule.FunctionSixty Function;

        public MaterialStringSafe ValueString;

        public SecondarymoduleFunctionSeventyPort(MaterialreflectSecondarymodule.FunctionSixty function, MaterialStringSafe valueString)
        {
            this.Function = function;

            this.ValueString = valueString;

            return;
        }

        ~SecondarymoduleFunctionSeventyPort()
        {
            return;
        }

        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(SecondarymoduleFunctionSeventyPort) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "function",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Function) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ValueString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ValueString) + ':' + ' ' + $"<safe><<{ValueString.StringValueSafe}>>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Function) + ':',
                String.Empty + Function
            });
        }
    }
}
