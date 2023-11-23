using Core;

using Core.DimensionTwoSecondSecondaryII.Interop;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scope
    {
        public static String SolidStudio(ScopeCode.StudioPath StudioPath__VALUE, String Path_VALUE)
        {
            String stringResult = default;

            var StudioDirectory__PATH = InteropSpecialize.GetStudioDirectory(true);

            var result = String.Empty;

            result = result + StudioDirectory__PATH;

            switch (StudioPath__VALUE)
            {
                case ScopeCode.StudioPath.Studio1D:
                    result = Path.Combine(result, nameof(ScopeCode.StudioPath.Studio1D));
                    break;

                case ScopeCode.StudioPath.Studio2D:
                    result = Path.Combine(result, nameof(ScopeCode.StudioPath.Studio2D));
                    break;

                case ScopeCode.StudioPath.Studio3D:
                    result = Path.Combine(result, nameof(ScopeCode.StudioPath.Studio3D));
                    break;

                case ScopeCode.StudioPath.Studio4D:
                    result = Path.Combine(result, nameof(ScopeCode.StudioPath.Studio4D));
                    break;

                default:
                    break;
            }

            result = Path.Combine(result, StudioSpecialName(Path_VALUE));

            if (File.Exists(result) is false)
            {
                return stringResult;
            }
            else
                "false".ToString();

            stringResult = result;

            return stringResult;
        }
    }
}
