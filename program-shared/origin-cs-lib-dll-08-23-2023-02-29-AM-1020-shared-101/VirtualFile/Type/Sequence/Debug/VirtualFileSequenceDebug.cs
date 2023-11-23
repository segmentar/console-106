using Core.Shared;

namespace Core.Shared
{
    using System;

    public partial class VirtualFileSequence
    {
        public static void Debug(String filename, Byte[] contentByteArray, Boolean debug)
        {
            if (debug is true)
            {
                var descriptor = String.Join('\n'.ToString(), new String[] { 
                    String.Empty + nameof(VirtualFile) + ' ' + "::" + ' ' + nameof(VirtualFileSequence) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '}'
                });

                Console.Clear();

                Console.Out.WriteLine(descriptor);

                Console.In.ReadLine();
            }
            else
                "false".ToString();

            return;
        }
    }
}
