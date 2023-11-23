using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void IterationafterFileCategory()
        {
            if (MeasureFlag.MaterialValidateFlag is true)
            {
                MaterialValidateSync();

                MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset + MeasureValue.MaterialHeaderSubstring.StringValue.Length;

                MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset + MeasureValue.MaterialFooterSubstring.StringValue.Length;

                MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset + ScopeDefault.MaterialStringEndDefault.Length;

                MeasureFile.PhysicalOffset = MeasureFile.PhysicalOffset - 1;

                var Entity_COMMA = Convert.ToChar(44);

                var HeaderSubstringSplitcharacter___VALUE = MaterialStringSplitcharacter.Simple(MeasureValue.MaterialHeaderSubstring.StringValue, Entity_COMMA);

                var FooterSubstringSafe___VALUE = MeasureValue.MaterialFooterSubstring.StringValue;

                MaterialModule materialModule;

                Material.Manual(HeaderSubstringSplitcharacter___VALUE, FooterSubstringSafe___VALUE, out materialModule);

                MeasureQuery.ElementArrayList.Add(materialModule.Material);
            }
            else
                "false".ToString();

            FileSecondaryIteration();

            return;
        }
    }
}
