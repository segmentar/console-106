using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void HostApply()
        {
            Scopefile scopefile;

            scopefile = Scopefile.MakeScopeFileDefaultSurface();

            //Host.ProcessLocalLineArray(MeasureFileArray.Filename.StringValue, scopefile.LocalLineArray.StringArrayValue);

            //Host.ProcessGlobalLineArray(scopefile.GlobalLineArray.StringArrayValue);

            MeasureQuery.ScopefileArrayList.Add(scopefile);

            return;
        }
    }
}
