using Core;

using Core.DimensionThreeThird;

namespace Core
{
    using System;
    using System.Windows.Forms;

    internal partial class Program
    {
        internal static String[] ArgumentArray;

        internal static void Main(params String[] array_ARGUMENT)
        {
            ArgumentArray = array_ARGUMENT;

            Boolean debug;

#if DEBUG
            debug = true;
#else
            debug = false;
#endif
            ConsoleLJ.Bundle(debug);

            Bundle(debug);

            return;
        }

        internal static void Procedure()
        {
            ProgramPolicy.ProgramDebugPolicy = true;

            ProgramPolicy.ProgramInfoPolicy = true;

            VirtualFilePolicy.VirtualFileDebugPolicy = true;

            VirtualFilePolicy.VirtualFileInfoPolicy = true;

            VirtualFolderPolicy.VirtualFolderDebugPolicy = true;

            VirtualFolderPolicy.VirtualFolderInfoPolicy = true;

            VirtualFilesystemPolicy.VirtualFilesystemDebugPolicy = true;

            VirtualFilesystemPolicy.VirtualFilesystemInfoPolicy = true;

            return;
        }

        internal static void Manual()
        {
            ProgramModule programModule = ProgramModule.ProgramModuleAction(true, true, true);

            return;
        }

        internal static void Raise()
        {
            if (ProgramPolicy.ProgramInfoPolicy is true)
            {
                ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(Program)}Info", ProgramPolicy.ProgramArrayList.ToArray());
            }
            else
                "false".ToString();

            if (VirtualFilePolicy.VirtualFileInfoPolicy is true)
            {
                ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(VirtualFile)}Info", VirtualFilePolicy.VirtualFileArrayList.ToArray());
            }
            else
                "false".ToString();

            if (VirtualFolderPolicy.VirtualFolderInfoPolicy is true)
            {
                ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(VirtualFolder)}Info", VirtualFolderPolicy.VirtualFolderArrayList.ToArray());
            }
            else
                "false".ToString();

            if (VirtualFilesystemPolicy.VirtualFilesystemInfoPolicy is true)
            {
                ConsoleLJ.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(VirtualFilesystem)}Info", VirtualFilesystemPolicy.VirtualFilesystemArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        internal static void Bundle(Boolean debug)
        {
            if (debug is true)
            {
                Procedure();
            }
            else
                "false".ToString();

            Manual();

            if (debug is true)
            {
                Raise();
            }
            else
                "false".ToString();

            return;
        }

        static Program()
        {
            return;
        }
    }
}
