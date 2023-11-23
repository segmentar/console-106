using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void ProcessGlobalLineArray(String[] GlobalLine_Array)
        {
            var array = Contribute.ContributeDefaultSetSurface(GlobalLine_Array);

            ProcessContributePreloadEnumerable("sample", array, false);

            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(Contribute)}SaveStatic", String.Join('\n'.ToString(), Contribute.ContributeArrayList.ToArray()));

            ProcessContributePreload("nani", false);

            Render($"{HostCode.RenderPath.Core_Host_Static}-{nameof(Contribute)}LoadStatic", String.Join('\n'.ToString(), Contribute.ContributeArrayList.ToArray()));

            return;
        }
    }
}
