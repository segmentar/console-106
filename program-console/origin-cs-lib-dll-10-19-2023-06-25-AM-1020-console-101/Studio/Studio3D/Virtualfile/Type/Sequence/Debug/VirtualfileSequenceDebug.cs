using Core;

namespace Core
{
    using System;

    public partial class VirtualfileSequence
    {
        public static void Debug(String Filename_VALUE, Byte[] Content_ARRAY, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            var join = String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Virtualfile) + ' ' + "::" + ' ' + nameof(VirtualfileSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Filename_VALUE) + ':' + ' ' + Filename_VALUE,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Content_ARRAY) + ':' + ' ' + Content_ARRAY,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}'
            });

            Virtualsolid.Render($"{VirtualsolidCode.RenderPath.Core_Debug_Virtualfile}", join);

            return;
        }
    }
}
