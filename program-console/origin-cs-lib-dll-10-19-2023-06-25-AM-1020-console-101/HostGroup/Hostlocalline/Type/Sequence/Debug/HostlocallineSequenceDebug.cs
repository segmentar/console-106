using Core;

namespace Core
{
    using System;

    public partial class HostlocallineSequence
    {
        public static void Debug(String LocalLineInline___VALUE, String[] LocalLineMultiline___VALUE, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is true)
            {
                return;
            }
            else
                "false".ToString();

            var join = String.Join('\n'.ToString(), new String[] { 
                
                String.Empty + nameof(Hostlocalline) + ' ' + "::" + ' ' + nameof(HostlocallineSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(LocalLineInline___VALUE) + ':' + ' ' + LocalLineInline___VALUE,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(LocalLineMultiline___VALUE) + ':' + ' ' + ". . ." + ' ' + $"<{LocalLineMultiline___VALUE.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LocalLineMultiline___VALUE) + ':',
                String.Empty + String.Join('\n'.ToString(), LocalLineMultiline___VALUE)
            });

            Host.Render($"{HostCode.RenderPath.Core_Host_Debug}-{nameof(HostlocallineSequence)}Debug", join);

            return;
        }
    }
}
