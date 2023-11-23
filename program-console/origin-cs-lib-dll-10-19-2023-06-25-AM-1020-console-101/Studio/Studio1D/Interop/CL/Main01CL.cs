using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    public partial class Interop
    {
        public static void Main01CL(String[] Argument_ARRAY)
        {
            InteropArchitecture.ArgumentArray = Argument_ARRAY;

            Lenf01IL();

            Linf02IL();

            Extf03IL();

            Reff04IL();
            
            Debf05IL();
            
            //Chrf06IL();
            
            //Escf07IL();

            Finf08IL();

            return;
        }
    }
}
