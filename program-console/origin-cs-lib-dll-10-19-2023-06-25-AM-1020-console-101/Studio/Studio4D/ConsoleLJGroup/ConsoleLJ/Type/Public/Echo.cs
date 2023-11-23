using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public void Echo(String[] stringArray)
        {
            var comma = Convert.ToChar(44);

            var join = String.Join(comma.ToString(), stringArray);

            var line_feed = Convert.ToChar(10);

            var concat = String.Concat(Descriptor(), line_feed, join);

            ConsoleLJS.Log(false, concat);

            return;
        }
    }
}
