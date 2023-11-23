using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Reflection;

    public partial class ConsoleLJS
    {
        public static String SafeTupleString<T>(T item_TYPE)
        {
            String stringResult = default;

            var result = String.Empty;

            Type type = item_TYPE.GetType();

            PropertyInfo[] propertyInfoArray;

            propertyInfoArray = type.GetProperties();

            foreach (PropertyInfo propertyInfo in propertyInfoArray)
            {
                var value = propertyInfo.GetValue(item_TYPE);

                Boolean isArrayContagentCheck;

                isArrayContagentCheck = (value is Array) is true;

                var name_PROPERTY = $"{propertyInfo.Name}";

                if (isArrayContagentCheck)
                {
                    var array = (Array)(value as Object);

                    var list = new ArrayList(array);

                    var descriptor = String.Join('\n'.ToString(), new String[] { 
                    
                        String.Empty + name_PROPERTY + ':' + ' ' + ". . ." + ' ' + $"<{list.Count}>" + ':',
                        String.Empty +  String.Join('\n'.ToString(), list.ToArray())
                    });

                    result = result + descriptor;
                }
                else
                {
                    var descriptor = String.Join('\n'.ToString(), new String[] { 

                        String.Empty + name_PROPERTY + ':',
                        String.Empty + value
                    });

                    result = result + descriptor;
                }

                var entity_LINE_FEED = Convert.ToChar(10);

                result = result + entity_LINE_FEED;

                continue;
            }

            stringResult = result;

            return stringResult;
        }
    }
}
