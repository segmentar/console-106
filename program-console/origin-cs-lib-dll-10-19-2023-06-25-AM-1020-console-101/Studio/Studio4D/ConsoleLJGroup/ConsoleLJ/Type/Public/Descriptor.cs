using Core;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {
        public String Descriptor()
        {
            String stringResult = default;

            var line_feed = Convert.ToChar(10);

            var join = String.Join(line_feed.ToString(), InteropDescriptor());

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
