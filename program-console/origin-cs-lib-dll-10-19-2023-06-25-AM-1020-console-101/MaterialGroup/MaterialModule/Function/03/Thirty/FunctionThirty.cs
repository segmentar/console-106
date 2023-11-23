using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class FunctionThirty
    {
        public Char[] CharacterArray;

        public FunctionThirty(Char[] characterArray)
        {
            this.CharacterArray = characterArray;

            return;
        }

        ~FunctionThirty()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(FunctionThirty) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "function",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(CharacterArray) + ':' + ' ' + ". . ." + ' ' + $"<{CharacterArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(CharacterArray) + ':',
                String.Empty + String.Join('\n'.ToString(), CharacterArray)
            });
        }
    }
}
