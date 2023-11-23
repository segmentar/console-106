using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Scope
    {
        public static void GetText()
        {
            var text = File.ReadAllText(MeasureFileArray.Filename.StringValue);

            var safe = ScopeStringSafe.Simple(text);

            MeasureFileArray.Text = safe;
            
            return;
        }
    }
}
