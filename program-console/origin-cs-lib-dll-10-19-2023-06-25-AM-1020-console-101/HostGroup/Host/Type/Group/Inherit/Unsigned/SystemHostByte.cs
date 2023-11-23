using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void SystemHostByte(Contribute item_CONTRIBUTE)
        {
            var parse = Byte.Parse(item_CONTRIBUTE.Value.StringValue);

            item_CONTRIBUTE.ByteArray = BitConverter.GetBytes(parse);

            item_CONTRIBUTE.ObjectIdentity = parse;

            return;
        }
    }
}
