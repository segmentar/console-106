using Core;

namespace Core
{
    using System;

    using System.Reflection;

    public partial class ConsoleLJS
    {
        public static T SafeTuple<T>(T item_TYPE)
        {
            T typeResult = default;

            Type type;
            
            type = item_TYPE.GetType();

            PropertyInfo[] propertyInfoArray;

            propertyInfoArray = type.GetProperties();

            var zeroth = -1;

            foreach (PropertyInfo propertyInfo in propertyInfoArray)
            {
                zeroth = zeroth + 1;

                var value = propertyInfo.GetValue(item_TYPE);

                Boolean isStringCheck, isCharacterCheck, isStringArray;

                isStringCheck = value is String;

                isCharacterCheck = value is Char;

                isStringArray = value is String[];

                if (isStringCheck is true)
                {
                    var item_STRING = (String)(value as Object);

                    var entry_STRING = SafeString(item_STRING);

                    propertyInfoArray[zeroth].SetValue(item_TYPE, entry_STRING);

                    continue;
                }
                else
                    "false".ToString();
                
                if (isCharacterCheck is true)
                {
                    try
                    {
                        var item_CHARACTER = (Char)(value as Object);

                        var entry_CHARACTER = SafeCharacter(item_CHARACTER);

                        propertyInfoArray[zeroth].SetValue(item_TYPE, entry_CHARACTER);
                    }
                    catch (Exception e)
                    {
                        ConsoleLJS.Log(false, $"is char [{e}]");
                    }

                    continue;
                }
                else
                    "false".ToString();
                /*
                if (isStringArray is true)
                {
                    var item_ARRAY = (String[])(value as Array);

                    var entry_ARRAY = SafeArray(item_ARRAY);

                    propertyInfoArray[indexer].SetValue(item_TYPE, entry_ARRAY);
                }
                else
                    "false".ToString();
                */

                continue;
            }

            typeResult = item_TYPE;

            return typeResult;
        }
    }
}
