using Core;

namespace Core
{
    using System;

    public partial class Scopefile
    {
        public static Scopefile MakeScopeFileDefault(Boolean answer_DEBUG_is)
        {
            Scopefile scopefileResult = default;

            var result = new ScopefileSequence(answer_DEBUG_is).Result;

            ScopefilePolicy.ScopefileArrayList.Add(result);

            scopefileResult = result;

            return scopefileResult;
        }
    }
}
