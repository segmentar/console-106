using Core;

namespace Core
{
    using System;

    public partial class InteropStartInfo
    {
        public Char EscapeCharacter;

        public Char TerminatorCharacter;

        public String NativeString;

        public String SharedString;

        public InteropStartInfo(Char escapeCharacter, Char terminatorCharacter, String nativeString, String sharedString)
        {
            this.EscapeCharacter = escapeCharacter;

            this.TerminatorCharacter = terminatorCharacter;

            this.NativeString = nativeString;

            this.SharedString = sharedString;

            return;
        }

        ~InteropStartInfo()
        {
            return;
        }
    }
}
