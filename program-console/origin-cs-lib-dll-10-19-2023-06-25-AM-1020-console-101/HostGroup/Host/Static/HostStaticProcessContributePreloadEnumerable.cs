using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class Host
    {
        public static void ProcessContributePreloadEnumerable(String Name_ITEM, IEnumerable item_ENUMERABLE, Boolean answer_LOG_should)
        {
            item_ENUMERABLE = item_ENUMERABLE.OfType<Contribute>().Cast<Contribute>().ToArray();
            
            var reflect = (Contribute[])(item_ENUMERABLE as Array);

            Contribute.Include(reflect, true);

            ProcessContributeArrayList();

            Contribute.SaveToCurrentDirectory(Name_ITEM);

            var array = Contribute.LoadFromCurrentDirectory(Name_ITEM);

            ProcessContributeArrayList();

            if (answer_LOG_should is true)
            {
                foreach (Contribute contribute in Contribute.ContributeArrayList)
                {
                    ConsoleLJS.Log(false, contribute);

                    continue;
                }
            }
            else
                "false".ToString();

            Contribute.Include(array, true);

            return;
        }
    }
}
