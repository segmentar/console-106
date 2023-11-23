using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionTwenty
        {
            public static IList<FunctionTwenty> FunctionDefaultSet(String value_STRING, Tuple<Char, Char, Boolean>[] array_TUPLE)
            {
                ICollection<FunctionTwenty> collectionResult = default;

                collectionResult = new Collection<FunctionTwenty>();

                foreach (Tuple<Char, Char, Boolean> value_TUPLE in array_TUPLE)
                {
                    var Character_VALUE = value_TUPLE.Item1;

                    var SymmetryCharacter__VALUE = value_TUPLE.Item2;

                    var SymmetryHas__VALUE = value_TUPLE.Item3;

                    var zeroth = -1;

                    foreach (Char item_CHARACTER in value_STRING)
                    {
                        zeroth = zeroth + 1;

                        Boolean shouldContinueCheck;

                        shouldContinueCheck = Character_VALUE.Equals(item_CHARACTER) is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var total = (Character_VALUE + item_CHARACTER);

                        var divide = (total / 2);

                        var convert = Convert.ToChar(divide);

                        var ReflectCharacterSafe___VALUE = MaterialCharacterSafe.Simple(convert);

                        var ReflectCharacterSymmetrySafe____VALUE = MaterialCharacterSafe.Simple(SymmetryCharacter__VALUE);

                        FunctionTwenty value_FUNCTION;

                        value_FUNCTION = new FunctionTwenty(ReflectCharacterSafe___VALUE, ReflectCharacterSymmetrySafe____VALUE, zeroth, SymmetryHas__VALUE);

                        collectionResult.Add(value_FUNCTION);

                        continue;
                    }

                    continue;
                }

                return new List<FunctionTwenty>(collectionResult);
            }
        }
    }
}
