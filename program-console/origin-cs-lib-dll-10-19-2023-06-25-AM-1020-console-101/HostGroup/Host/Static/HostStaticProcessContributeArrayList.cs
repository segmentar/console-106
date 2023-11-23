using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void ProcessContributeArrayList()
        {
            foreach (Contribute item_CONTRIBUTE in Contribute.ContributeArrayList)
            {
                ProcessContribute(item_CONTRIBUTE);

                continue;
            }

            return;
        }
    }
}
