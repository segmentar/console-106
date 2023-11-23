using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void SystemHostInt64(Contribute item_CONTRIBUTE)
        {
            var parse = Int64.Parse(item_CONTRIBUTE.Value.StringValue);

            item_CONTRIBUTE.ByteArray = BitConverter.GetBytes(parse);

            item_CONTRIBUTE.ObjectIdentity = parse;

            return;
        }
    }
}
