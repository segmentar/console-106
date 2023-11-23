using Core;

namespace Core
{
    using System;

    using System.Reflection;

    internal partial class Material
    {
        internal static PropertyInfo[] SolidPropertyArray<T>(T Type_VALUE)
        {
            PropertyInfo[] arrayResult = default;

            var type = Type_VALUE.GetType();

            var array = type.GetProperties();

            arrayResult = array;

            return arrayResult;
        }
    }
}
