using Core;

namespace Core
{
    using System;

    public partial class Hostlocalline
    {
        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Hostlocalline) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(StringValue) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StringValue) + ':' + ' ' + $"<safe><<{StringValue.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(StringInstruction) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(StringInstruction) + ':' + ' ' + $"<safe><<{StringInstruction.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(StringCall) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(StringCall) + ':' + ' ' + $"<safe><<{StringCall.StringValueSafe}>>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(InlineArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(InlineArray) + ':' + ' ' + ". . ." + ' ' + $"<{InlineArray.StringArrayValue.Length}>",
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(MultilineArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(MultilineArray) + ':' + ' ' + ". . ." + ' ' + $"<{MultilineArray.StringArrayValue.Length}>",
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(ParameterArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(ParameterArray) + ':' + ' ' + ". . ." + ' ' + $"<{ParameterArray.StringArrayValue.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + "<safe>" + ' ' + nameof(InlineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), InlineArray.StringArrayValueSafe),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + "<safe>" + ' ' + nameof(MultilineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), MultilineArray.StringArrayValueSafe),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + "<safe>" + ' ' + nameof(ParameterArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ParameterArray.StringArrayValueSafe)
            });
        }
    }
}
