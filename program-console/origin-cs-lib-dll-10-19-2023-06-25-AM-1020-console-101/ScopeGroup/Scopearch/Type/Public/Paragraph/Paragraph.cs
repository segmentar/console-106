using Core;

namespace Core
{
    using System;

    using System.Collections;
    using System.Data.SqlTypes;

    public partial class Scopearch
    {
        public static void Paragraph()
        {
            try
            {
                Boolean shouldReturnCheck;

                shouldReturnCheck = MaterialqueryValue.Data.Runtime.QueryType.Equals(MaterialqueryCode.QueryType.Paragraph) is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                foreach (Materialchain materialchain in Template.Data.MeasureValidate.MaterialchainArrayList)
                {
                    Boolean isReferenceCheck, shouldContinueContiniousCheck;

                    isReferenceCheck = Object.ReferenceEquals(materialchain, MaterialchainValue) is true;

                    shouldContinueContiniousCheck = isReferenceCheck is true;

                    if (shouldContinueContiniousCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Boolean isEqualCheck;

                    isEqualCheck = materialchain.Materialinfo.Name.Equals(MaterialqueryValue.Data.IdentityName) is true;

                    shouldContinueContiniousCheck = isEqualCheck is false;

                    if (shouldContinueContiniousCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var list = new ArrayList(MaterialchainValue.MaterialqueryIsolateArray);

                    list.Remove(MaterialqueryValue);

                    var value = Materialchain.MakeMaterialchainTemplate(MaterialchainValue.Materialinfo, MaterialchainValue.MaterialqueryArray, (Materialquery[])(list.ToArray(typeof(Materialquery)) as Array));

                    MaterialchainStack = new Stack(MaterialchainStack);

                    MaterialchainStack.Push(value);

                    MaterialchainStack = new Stack(MaterialchainStack);
                     
                    var aoth = value.MaterialqueryIsolateArray.Length;

                    var zee = (aoth + materialchain.MaterialqueryIsolateArray.Length);

                    Array.Resize(ref value.MaterialqueryIsolateArray, zee);

                    Array.Copy(materialchain.MaterialqueryIsolateArray, 0, value.MaterialqueryIsolateArray, aoth, materialchain.MaterialqueryIsolateArray.Length);

                    Scope.Render($"{ScopeCode.RenderPath.Core_Scope_Fatal}-test", String.Join('\n'.ToString(), (Object[])(value.MaterialqueryIsolateArray as Array)));

                    continue;
                }

                Template.Data.MeasureValidate.ValidateMaterialquery[MaterialqueryValue] = true;

                if (ShouldLog is true)
                {
                    ConsoleLJS.Log(false, $"found paragraph [{MaterialqueryValue.Data.IdentityName.StringValue}]");
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalParagraph().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
