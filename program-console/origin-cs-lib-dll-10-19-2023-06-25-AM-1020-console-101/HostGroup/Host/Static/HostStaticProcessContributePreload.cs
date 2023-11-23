using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void ProcessContributePreload(String Name_ITEM, Boolean answer_LOG_should)
        {
            ProcessContributePreloadEnumerable(Name_ITEM, Contribute.ContributeArrayList, answer_LOG_should);

            return;
        }
    }
}
