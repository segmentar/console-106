using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scope
    {
        public static void DirectionRender(Boolean answer_OPEN_should)
        {
            var result = String.Empty;

            if (MeasureWait.IsPause is true)
            {
                result = result + "pause";
            }
            else
                "false".ToString();

            var path_NAME_file = Path.GetFileName(MeasureFileArray.Filename.StringValue);

            var format = ForgeJoinfulFormat(path_NAME_file, true);

            result = result + format;

            if (answer_OPEN_should is true)
            {
                Explorer(1, Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}", default));
            }
            else
                "false".ToString();

            Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}-{nameof(MeasureValidate.MaterialchainArrayList)}", MeasureValidate.MaterialchainArrayList.ToArray());

            Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}-{nameof(MeasureValidate.ValidateMaterialchain)}", SolidDictionary(MeasureValidate.ValidateMaterialchain, MeasureValidate.ValidateMaterialchain.Count));

            Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}-{nameof(MeasureValidate.ValidateMaterialquery)}", SolidDictionary(MeasureValidate.ValidateMaterialquery, MeasureValidate.ValidateMaterialquery.Count));

            Render($"{ScopeCode.RenderPath.Core_Scope_Render}-{result}-{nameof(Scopearch.Expression)}", Scopearch.Expression);

            return;
        }
    }
}
