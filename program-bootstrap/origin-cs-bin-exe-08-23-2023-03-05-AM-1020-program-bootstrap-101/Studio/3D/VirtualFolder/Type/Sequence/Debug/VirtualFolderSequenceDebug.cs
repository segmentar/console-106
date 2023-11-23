using Core;

namespace Core.DimensionThreeThird
{
    using System;

    public partial class VirtualFolderSequence
    {
        public static void Debug(String fullName, Boolean debug)
        {
            if (VirtualFolderPolicy.VirtualFolderDebugPolicy is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = new String[] {

                String.Empty + nameof(VirtualFolder) + ' ' + "::" + ' ' + nameof(VirtualFolderSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(fullName) + ':' + ' ' + fullName,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            };

            var join = String.Join('\n'.ToString(), descriptor);

            ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_Debug}-{nameof(VirtualFolder)}Debug", join);

            return;
        }
    }
}
