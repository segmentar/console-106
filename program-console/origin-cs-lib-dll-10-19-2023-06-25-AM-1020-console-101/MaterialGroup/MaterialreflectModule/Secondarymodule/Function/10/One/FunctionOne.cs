using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public static MaterialreflectSecondarymodule FunctionOne(MaterialreflectSecondarymodule module)
        {
            Char[] openCharacterArray, closeCharacterArray;

            openCharacterArray = new Char[] {

                MaterialSymmetry.EntityParenthesisLeft,
                MaterialSymmetry.EntitySquareBracketLeft,
                MaterialSymmetry.EntityCurlyBracketLeft,
                MaterialSymmetry.EntityArrorBracesLeft
            };

            closeCharacterArray = new Char[] {

                MaterialSymmetry.EntityParenthesisRight,
                MaterialSymmetry.EntitySquareBracketRight,
                MaterialSymmetry.EntityCurlyBracketRight,
                MaterialSymmetry.EntityArrowBracesRight
            };

            var tuple = FunctionTen.FunctionDefaultContainerSurface<Tuple<Char, Char, Boolean>>(openCharacterArray, closeCharacterArray);

            var function = new FunctionTen(tuple);

            FunctionFirst first;

            first = new FunctionFirst(function);

            module.First = first;

            return module;
        }
    }
}
