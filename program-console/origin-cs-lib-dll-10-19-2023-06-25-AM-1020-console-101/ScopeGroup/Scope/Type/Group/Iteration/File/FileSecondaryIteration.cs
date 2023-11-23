using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void FileSecondaryIteration()
        {
            LocalLineApply();

            if (MeasureFlag.GlobalLineFlag is true)
            {
                GlobalLineSync();

                MeasureQuery.GlobalLineArrayList.Add(MeasureFile.Line.StringValue);

                AdvanceLine();
            }
            else
                "false".ToString();

            if (MeasureFlag.MaterialHeaderFlag is true)
            {
                MaterialHeaderSync();

                MeasureValue.MaterialHeaderSubstring = default(ScopeStringSafe);
            }
            else
                "false".ToString();

            if (MeasureFlag.MaterialFooterFlag is true)
            {
                MaterialFooterSync();

                MeasureValue.MaterialFooterSubstring = default(ScopeStringSafe);
            }
            else
                "false".ToString();

            return;
        }
    }
}
