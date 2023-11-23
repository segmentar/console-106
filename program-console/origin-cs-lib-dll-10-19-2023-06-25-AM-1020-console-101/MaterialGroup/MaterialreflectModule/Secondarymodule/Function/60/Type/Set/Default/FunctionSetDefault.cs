using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
   
    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionSixty
        {
            public static IList<FunctionSixty> FunctionDefaultSet(String value_STRING, FunctionFifty[] array_FUNCTION, Tuple<Char, Char, Boolean>[] array_TUPLE)
            {
                ICollection<FunctionSixty> collectionResult = default;

                collectionResult = new Collection<FunctionSixty>();

                foreach (FunctionFifty value_FUNCTION in array_FUNCTION)
                {
                    var entity_COLON = Convert.ToChar(58);

                    var entity_DOUBLE_COLON = new String(entity_COLON, 2);

                    var separator = new String[] { entity_DOUBLE_COLON };

                    FunctionTen.FunctionDefaultCompound(array_TUPLE, ref separator);

                    var split = value_FUNCTION.Function.Function.ValueString.StringValue.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    String identityName, virtualName;

                    identityName = String.Empty;

                    virtualName = String.Empty;

                    Boolean stickyLeft, stickyRight;

                    stickyLeft = false;

                    stickyRight = false;

                    Boolean hasIdentityNameCheck, hasVirtualNameCheck;

                    hasIdentityNameCheck = (split.Length >= 1) is true;

                    hasVirtualNameCheck = (split.Length >= 2) is true;

                    if (hasIdentityNameCheck is true)
                    {
                        var first = split[0];

                        identityName = first;
                    }
                    else
                        "false".ToString();

                    if (hasVirtualNameCheck is true)
                    {
                        var second = split[1];

                        virtualName = second;
                    }
                    else
                        "false".ToString();

                    var roth = (value_FUNCTION.Function.Function.Left.Position - 1);

                    var zee = (value_FUNCTION.Function.Function.Right.Position + 1);

                    var aoth = value_STRING.Length;

                    Boolean hasStartCheck, hasEndCheck;

                    hasStartCheck = (roth < 0) is false;

                    hasEndCheck = (zee >= aoth) is false;

                    var entity_PERIOD = Convert.ToChar(46);

                    if (hasStartCheck is true)
                    {
                        stickyLeft = value_STRING[roth].Equals(entity_PERIOD) is true;
                    }
                    else
                        "false".ToString();

                    if (hasEndCheck is true)
                    {
                        stickyRight = value_STRING[zee].Equals(entity_PERIOD) is true;
                    }
                    else
                        "false".ToString();

                    var ReflectSegmentSafe__ARRAY = MaterialStringArraySafe.Simple(split);

                    var ReflectIdentityNamesafe___VALUE = MaterialStringSafe.Simple(identityName);
                   
                    var ReflectVirtualNamesafe__VALUE = MaterialStringSafe.Simple(virtualName);

                    var item_entry_reflect_FUNCTION = new FunctionSixty(value_FUNCTION, ReflectSegmentSafe__ARRAY, ReflectIdentityNamesafe___VALUE, ReflectVirtualNamesafe__VALUE, stickyLeft, stickyRight);

                    collectionResult.Add(item_entry_reflect_FUNCTION);

                    continue;
                }

                return new List<FunctionSixty>(collectionResult);
            }
        }
    }
}
