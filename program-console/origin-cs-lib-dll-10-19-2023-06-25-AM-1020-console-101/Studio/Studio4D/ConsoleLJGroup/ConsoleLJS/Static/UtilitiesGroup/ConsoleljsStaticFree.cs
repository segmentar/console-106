﻿using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.IO;

    public partial class ConsoleLJS
    {
        public static void Free()
        {
            var path_DIRECTORY_full_name = Path.Combine(Directory.GetCurrentDirectory(), ConsoleLJCode.SpecialDirectory.Core.ToString());

            if (Directory.Exists(path_DIRECTORY_full_name) is true)
            {
                Directory.Delete(path_DIRECTORY_full_name, true);
            }
            else
                "false".ToString();

            return;
        }
    }
}
