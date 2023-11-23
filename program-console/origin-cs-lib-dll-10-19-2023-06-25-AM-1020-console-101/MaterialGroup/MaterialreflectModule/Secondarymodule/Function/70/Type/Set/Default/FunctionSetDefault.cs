using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionSeventy
        {
            public static IList<SecondarymoduleFunctionSeventyPort> FunctionDefaultSet(FunctionSixty[] array__FUNCTION, Tuple<Char, String[], String[]>[] array_TUPLE)
            {
                ICollection<SecondarymoduleFunctionSeventyPort> collectionResult = default;

                collectionResult = new Collection<SecondarymoduleFunctionSeventyPort>();

                var zeroth = -1;

                do
                {
                    zeroth = zeroth + 1;

                    Boolean shouldBreakCheck;

                    shouldBreakCheck = array__FUNCTION.Length.Equals(zeroth) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    var item_FUNCTION = array__FUNCTION[zeroth];

                    foreach (Tuple<Char, String[], String[]> item_TUPLE in array_TUPLE)
                    {
                        var reflect_entry_CHARACTER__ESCAPE = item_TUPLE.Item1;

                        var reflect_entry_ARRAY__BIND = item_TUPLE.Item2;

                        var reflect_entry_ARRAY__HOLE = item_TUPLE.Item3;

                        foreach (String item_STRING in reflect_entry_ARRAY__BIND)
                        {
                            Boolean isEqualCheck;

                            isEqualCheck = item_FUNCTION.IdentityName.StringValue.Equals(item_STRING) is true;

                            if (isEqualCheck is true)
                            {
                                var entity_WHITE_SPACE = Convert.ToChar(32);

                                var join = String.Join(entity_WHITE_SPACE.ToString(), reflect_entry_ARRAY__HOLE);

                                String stringEntry, stringEntryValueSafe;

                                stringEntry = join;

                                stringEntryValueSafe = ConsoleLJS.SafeString(stringEntry);

                                MaterialStringSafe reflectString;

                                reflectString = new MaterialStringSafe();

                                reflectString.StringValue = stringEntry;

                                reflectString.StringValueSafe = stringEntryValueSafe;

                                var entry_item__FUNCTION = new SecondarymoduleFunctionSeventyPort(item_FUNCTION, reflectString);

                                collectionResult.Add(entry_item__FUNCTION);

                                goto bypass;
                            }
                            else
                                "false".ToString();

                            continue;
                        }

                        continue;
                    }

                    String stringItem, stringItemValueSafe;

                    stringItem = item_FUNCTION.Function.Function.Function.ValueString.StringValue;

                    stringItemValueSafe = item_FUNCTION.Function.Function.Function.ValueString.StringValueSafe;

                    MaterialStringSafe reflectStringItem;

                    reflectStringItem = new MaterialStringSafe();

                    reflectStringItem.StringValue = stringItem;

                    reflectStringItem.StringValueSafe = stringItemValueSafe;

                    var item_entry__FUNCTION = new SecondarymoduleFunctionSeventyPort(item_FUNCTION, reflectStringItem);

                    collectionResult.Add(item_entry__FUNCTION);

                bypass:
                    {
                        continue;
                    }

                } while (true);

                return new List<SecondarymoduleFunctionSeventyPort>(collectionResult);
            }
        }
    }
}
