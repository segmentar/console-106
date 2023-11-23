using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJS
    {
        public static void Render(String item__PATH_RELATIVE, params Object[] objectArray)
        {
            ConsoleLJ.ConsoleLJRenderSetSurface(item__PATH_RELATIVE, objectArray);

            return;
        }
    }
}
