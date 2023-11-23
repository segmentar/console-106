using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        [MaterialIntentionalShortClass]
        public partial class FunctionTwenty
        {
            public MaterialCharacterSafe Character;

            public MaterialCharacterSafe SymmetryCharacter;

            public Int32 Position;

            public Boolean HasSymmetry;

            public FunctionTwenty(MaterialCharacterSafe character, MaterialCharacterSafe symmetryCharacter, Int32 position, Boolean answer_SYMMETRY_has)
            {
                this.Character = character;

                this.SymmetryCharacter = symmetryCharacter;

                this.Position = position;

                if (answer_SYMMETRY_has is true)
                {
                    this.HasSymmetry = true;
                }
                else
                    "false".ToString();

                return;
            }

            ~FunctionTwenty()
            {
                return;
            }

            [MaterialIntentionalShortMethod]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(FunctionTwenty) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(Character) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(Character) + ':' + ' ' + $"<safe><<{Character.CharacterValueSafe}>>",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(SymmetryCharacter) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(SymmetryCharacter) + ':' + ' ' + $"<safe><<{SymmetryCharacter.CharacterValueSafe}>>",
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(Position) + ':' + ' ' + Position,
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(HasSymmetry) + ':' + ' ' + HasSymmetry,
                    String.Empty + '}'
                });
            }
        }
    }
}
