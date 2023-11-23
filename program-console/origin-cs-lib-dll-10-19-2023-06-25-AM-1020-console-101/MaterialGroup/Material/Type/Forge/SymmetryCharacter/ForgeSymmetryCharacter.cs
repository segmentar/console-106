using Core;

namespace Core
{
    using System;

    internal partial class Material
    {
        internal static Char ForgeSymmetryCharacter(Char Character_VALUE)
        {
            Char characterResult = default;

            Char character;

            switch (Character_VALUE)
            {
                case MaterialSymmetry.EntityConstantParenthesisLeft:
                    character = MaterialSymmetry.EntityParenthesisRight;
                    break;

                case MaterialSymmetry.EntityConstantSquareBracketLeft:
                    character = MaterialSymmetry.EntitySquareBracketRight;
                    break;

                case MaterialSymmetry.EntityConstantCurlyBracketLeft:
                    character = MaterialSymmetry.EntityCurlyBracketRight;
                    break;

                case MaterialSymmetry.EntityConstantArrorBracesLeft:
                    character = MaterialSymmetry.EntityArrowBracesRight;
                    break;

                case MaterialSymmetry.EntityConstantUppercaseLeftL:
                    character = MaterialSymmetry.EntityUppercaseRightJ;
                    break;

                case MaterialSymmetry.EntityConstantLowercaseLeftL:
                    character = MaterialSymmetry.EntityLowercaseRightJ;
                    break;

                case MaterialSymmetry.EntityConstantParenthesisRight:
                    character = MaterialSymmetry.EntityParenthesisLeft;
                    break;

                case MaterialSymmetry.EntityConstantSquareBracketRight:
                    character = MaterialSymmetry.EntitySquareBracketLeft;
                    break;

                case MaterialSymmetry.EntityConstantCurlyBracketRight:
                    character = MaterialSymmetry.EntityCurlyBracketLeft;
                    break;

                case MaterialSymmetry.EntityConstantArrowBracesRight:
                    character = MaterialSymmetry.EntityArrorBracesLeft;
                    break;

                case MaterialSymmetry.EntityConstantUppercaseRightJ:
                    character = MaterialSymmetry.EntityUppercaseLeftL;
                    break;

                case MaterialSymmetry.EntityConstantLowercaseRightJ:
                    character = MaterialSymmetry.EntityLowercaseLeftL;
                    break;

                default:
                    character = default(Char);
                    break;
            }

            characterResult = character;

            return characterResult;
        }
    }
}
