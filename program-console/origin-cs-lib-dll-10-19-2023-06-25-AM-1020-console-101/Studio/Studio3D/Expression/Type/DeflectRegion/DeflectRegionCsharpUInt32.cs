using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Object DeflectRegionCSharpUInt32(Object item_OBJECT)
        {
            Object objectResult = default;

            var reflect = (Byte[])(item_OBJECT as Array);

            var result = BitConverter.ToUInt32(reflect, 0);

            objectResult = result;

            return objectResult;
        }
    }
}
