using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void ProcessContributeHostType(Contribute item_CONTRIBUTE, String Lower_ITEM)
        {
            switch (Lower_ITEM)
            {
                case HostConstant.SystemHostInt64:
                    SystemHostInt64(item_CONTRIBUTE);
                    break;

                case HostConstant.SystemHostInt32:
                    SystemHostInt32(item_CONTRIBUTE);
                    break;

                case HostConstant.SystemHostInt16:
                    SystemHostInt16(item_CONTRIBUTE);
                    break;

                case HostConstant.SystemHostSByte:
                    SystemHostSByte(item_CONTRIBUTE);
                    break;

                case HostConstant.SystemHostUInt64:
                    SystemHostInt64(item_CONTRIBUTE);
                    break;

                case HostConstant.SystemHostUInt32:
                    SystemHostInt32(item_CONTRIBUTE);
                    break;

                case HostConstant.SystemHostUInt16:
                    SystemHostInt16(item_CONTRIBUTE);
                    break;

                case HostConstant.SystemHostByte:
                    SystemHostSByte(item_CONTRIBUTE);
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
