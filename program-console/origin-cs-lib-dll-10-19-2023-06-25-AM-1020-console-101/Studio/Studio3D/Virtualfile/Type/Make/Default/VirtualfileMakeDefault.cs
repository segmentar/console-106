using Core;

namespace Core
{
    using System;

    public partial class Virtualfile
    {
        public static Virtualfile MakeVirtualfileDefault(String Filename_VALUE, Byte[] Content_ARRAY, Boolean answer_DEBUG_is)
        {
            Virtualfile virtualFileResult = default;

            var result = new VirtualfileSequence(Filename_VALUE, Content_ARRAY, answer_DEBUG_is).Result;

            VirtualfilePolicy.VirtaulFileArrayList.Add(result);

            virtualFileResult = result;

            return virtualFileResult;
        }
    }
}
