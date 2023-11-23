using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        static Host()
        {
            return;
        }
        
        public static void Procedure()
        {
            return;
        }

        public static void Manual()
        {
            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(SystemHostCurrentDirectory)}", String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(SystemHostCurrentDirectory) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + String.Format("{0}", "[EXPRESSION]"),
                String.Empty + '}'
            }));

            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(SystemHostCreateFolder)}", String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(SystemHostCreateFolder) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + String.Format("{0}", "[NAME]"),
                String.Empty + '}'
            }));

            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(SystemHostCreateFile)}", String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(SystemHostCreateFile) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + String.Format("{0} {1} {2}", "[DIRECTORY_FULL_NAME]", "[FILE_NAME]", "[FILE_EXTENSION]"),
                String.Empty + '}'
            }));

            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(SystemHostAppendText)}", String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(SystemHostAppendText) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + String.Format("{0} {1}", "[DIRECTORY_FULL_NAME]", "[TEXT]"),
                String.Empty + '}'
            }));

            return;
        }
        
        public static void Raise()
        {
            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
