using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionEighty
        {
            public static IList<SecondarymoduleFunctionEightyPort> FunctionDefaultSet(SecondarymoduleFunctionSeventyPort[] array_FUNCTION)
            {
                ICollection<SecondarymoduleFunctionEightyPort> collectionResult = default;

                collectionResult = new Collection<SecondarymoduleFunctionEightyPort>();

                foreach (SecondarymoduleFunctionSeventyPort item_FUNCTION in array_FUNCTION)
                {
                    MaterialStringSafe initialStringValue;

                    initialStringValue = item_FUNCTION.Function.Function.Function.Function.ValueString;

                    MaterialStringSafe subsequentStringValue;

                    subsequentStringValue = item_FUNCTION.ValueString;

                    MaterialStringArraySafe segmentArray;

                    segmentArray = item_FUNCTION.Function.SegmentArray;

                    MaterialStringSafe identityName;

                    identityName = item_FUNCTION.Function.IdentityName;

                    MaterialStringSafe virtualName;

                    virtualName = item_FUNCTION.Function.VirtualName;

                    Boolean stickyLeft, stickyRight;

                    stickyLeft = item_FUNCTION.Function.StickyLeft;

                    stickyRight = item_FUNCTION.Function.StickyRight;

                    Int32 layer;

                    layer = item_FUNCTION.Function.Function.Function.Layer;

                    Int32 rank;

                    rank = item_FUNCTION.Function.Function.Function.Function.Rank;

                    Int32 leftPosition, rightPosition;

                    leftPosition = item_FUNCTION.Function.Function.Function.Function.Left.Position;

                    rightPosition = item_FUNCTION.Function.Function.Function.Function.Right.Position;

                    Char leftCharacter, rightCharacter;

                    leftCharacter = item_FUNCTION.Function.Function.Function.Function.Left.Character.CharacterValue;

                    rightCharacter = item_FUNCTION.Function.Function.Function.Function.Right.Character.CharacterValue;

                    Char leftCharacterSafe, rightCharacterSafe;

                    leftCharacterSafe = item_FUNCTION.Function.Function.Function.Function.Left.Character.CharacterValueSafe;

                    rightCharacterSafe = item_FUNCTION.Function.Function.Function.Function.Right.Character.CharacterValueSafe;

                    Char leftSymmetryCharacter, rightSymmetryCharacter;

                    leftSymmetryCharacter = item_FUNCTION.Function.Function.Function.Function.Left.SymmetryCharacter.CharacterValue;

                    rightSymmetryCharacter = item_FUNCTION.Function.Function.Function.Function.Right.SymmetryCharacter.CharacterValue;

                    Char leftSymmetryCharacterSafe, rightSymmetryCharacterSafe;

                    leftSymmetryCharacterSafe = item_FUNCTION.Function.Function.Function.Function.Left.SymmetryCharacter.CharacterValueSafe;

                    rightSymmetryCharacterSafe = item_FUNCTION.Function.Function.Function.Function.Right.SymmetryCharacter.CharacterValueSafe;

                    Boolean leftSymmetryHas, rightSymmetryHas;

                    leftSymmetryHas = item_FUNCTION.Function.Function.Function.Function.Left.HasSymmetry;

                    rightSymmetryHas = item_FUNCTION.Function.Function.Function.Function.Right.HasSymmetry;

                    MaterialCharacterSafe reflectLeftCharacter, reflectRightCharacter;

                    reflectLeftCharacter = new MaterialCharacterSafe();

                    reflectLeftCharacter.CharacterValue = leftCharacter;

                    reflectLeftCharacter.CharacterValueSafe = leftCharacterSafe;

                    reflectRightCharacter = new MaterialCharacterSafe();

                    reflectRightCharacter.CharacterValue = rightCharacter;

                    reflectRightCharacter.CharacterValueSafe = rightCharacterSafe;

                    MaterialCharacterSafe reflectLeftSymmetryCharacter, reflectRightSymmetryCharacter;

                    reflectLeftSymmetryCharacter = new MaterialCharacterSafe();

                    reflectLeftSymmetryCharacter.CharacterValue = leftSymmetryCharacter;

                    reflectLeftSymmetryCharacter.CharacterValueSafe = leftSymmetryCharacterSafe;

                    reflectRightSymmetryCharacter = new MaterialCharacterSafe();

                    reflectRightSymmetryCharacter.CharacterValue = rightSymmetryCharacter;

                    reflectLeftSymmetryCharacter.CharacterValueSafe = rightSymmetryCharacterSafe;

                    var function = new SecondarymoduleFunctionEightyPort()
                    {
                        Origin = item_FUNCTION,
                        InitialStringValue = initialStringValue,
                        SubsequentStringValue = subsequentStringValue,
                        SegmentArray = segmentArray,
                        IdentityName = identityName,
                        VirtualName = virtualName,
                        StickyLeft = stickyLeft,
                        StickyRight = stickyRight,
                        Layer = layer,
                        Rank = rank,
                        LeftPosition = leftPosition,
                        LeftCharacter = reflectLeftCharacter,
                        LeftSymmetryCharacter = reflectLeftSymmetryCharacter,
                        LeftSymmetryHas = leftSymmetryHas,
                        RightPosition = rightPosition,
                        RightCharacter = reflectRightCharacter,
                        RightSymmetryCharacter = reflectRightSymmetryCharacter,
                        RightSymmetryHas = rightSymmetryHas
                    };

                    collectionResult.Add(function);

                    continue;
                }

                return new List<SecondarymoduleFunctionEightyPort>(collectionResult);
            }
        }
    }
}
