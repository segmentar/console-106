using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public static void Include(Contribute[] array_CONTRIBUTE, Boolean answer_CLEAR_should)
        {
            if (answer_CLEAR_should is true)
            {
                ContributeArrayList.Clear();
            }
            else
                "false".ToString();

            foreach (Contribute item_CONTRIBUTE in array_CONTRIBUTE)
            {
                ContributeArrayList.Add(item_CONTRIBUTE);

                continue;
            }

            return;
        }
    }
}
