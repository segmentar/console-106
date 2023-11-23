using Core;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Natf04IL()
        {
            var colon = Convert.ToChar(58);

            var item__DOUBLE_COLON = new String(colon, 2);

            Specialize.SetNativeString(item__DOUBLE_COLON, true);

            return;
        }
    }
}
