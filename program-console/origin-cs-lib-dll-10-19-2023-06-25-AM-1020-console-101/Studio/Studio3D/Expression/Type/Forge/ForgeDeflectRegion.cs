using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public static Object DeflectRegion(String item_STRING, Object item_OBJECT)
        {
            Object objectResult = default;
   
            var lower = ForgeDashfulFormat(item_STRING).ToLower();

            switch (lower)
            {
                case ExpressionConstant.ValidationCSharpInt32:
                    objectResult = DeflectRegionCSharpInt32(item_OBJECT);
                    break;

                case ExpressionConstant.ValidationCSharpUInt32:
                    objectResult = DeflectRegionCSharpUInt32(item_OBJECT);
                    break;

                default:
                    objectResult = item_OBJECT;
                    break;
            }
            
            return objectResult;
        }
    }
}
