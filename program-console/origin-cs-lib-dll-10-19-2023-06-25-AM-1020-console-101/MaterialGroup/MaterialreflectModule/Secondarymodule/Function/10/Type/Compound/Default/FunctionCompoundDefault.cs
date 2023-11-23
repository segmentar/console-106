using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectSecondarymodule
    {
        public partial class FunctionTen
        {
            public static void FunctionDefaultCompound(Tuple<Char, Char, Boolean>[] Tuple_ARRAY, ref String[] Separator_ARRAY)
            {
                var array = FunctionDefaultSetSurface(Tuple_ARRAY);

                var aoth = Separator_ARRAY.Length;

                var zee = (aoth + array.Length);

                Array.Resize(ref Separator_ARRAY, zee);

                Array.Copy(array, 0, Separator_ARRAY, aoth, array.Length);

                return;
            }
        }
    }
}
