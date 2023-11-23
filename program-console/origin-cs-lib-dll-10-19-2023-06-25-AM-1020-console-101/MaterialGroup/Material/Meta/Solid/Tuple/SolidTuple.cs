using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Reflection;

    internal partial class Material
    {
        internal static String SolidTuple<T>(T Type_VALUE)
        {
            String stringResult = default;

            var result = String.Empty;

            foreach (PropertyInfo propertyInfo in SolidPropertyArray<T>(Type_VALUE))
            {
                var name = propertyInfo.Name;

                var value = propertyInfo.GetValue(Type_VALUE);

                Boolean isArrayContagentCheck;

                isArrayContagentCheck = (value is Array) is true;

                if (isArrayContagentCheck)
                {
                    result = result + SolidRepresentArray(name, value);
                }
                else
                {
                    result = result + SolidRepresentObject(name, value);
                }

                result = result + '\n';

                continue;
            }

            stringResult = result;

            return stringResult;
        }
    }
}
