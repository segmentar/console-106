using Core;

namespace Core
{
    using System;

    public partial class Hostlocalline
    {
        public static Hostlocalline MakeHostlocallineDefault(String LocalLineInline___VALUE, String[] LocalLineMultiline___VALUE, Boolean answer_DEBUG_is)
        {
            Hostlocalline hostlocallineResult = default;

            var result = new HostlocallineSequence(LocalLineInline___VALUE, LocalLineMultiline___VALUE, answer_DEBUG_is).Result;

            HostlocallinePolicy.HostlocallineArrayList.Add(result);

            hostlocallineResult = result;

            return hostlocallineResult;
        }
    }
}
