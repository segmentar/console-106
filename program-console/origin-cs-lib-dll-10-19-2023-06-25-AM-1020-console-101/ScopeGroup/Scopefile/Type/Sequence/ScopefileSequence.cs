using Core;

namespace Core
{
    using System;

    public partial class ScopefileSequence
    {
        public Scopefile Result { get; set; } = default;

        public ScopefileSequence(Boolean answer_DEBUG_is)
        {
            Debug(answer_DEBUG_is);

            var LocalLineArraySafe___REFLECT = ScopeStringArraySafe.Simple((String[])(Scope.MeasureQuery.LocalLineArrayList.ToArray(typeof(String)) as Array));

            var GlobaLineArraySafe___REFLECT = ScopeStringArraySafe.Simple((String[])(Scope.MeasureQuery.GlobalLineArrayList.ToArray(typeof(String)) as Array));

            var ElementArray__REFLECT = (Material[])(Scope.MeasureQuery.ElementArrayList.ToArray(typeof(Material)) as Array);

            Scopefile scopefile;

            scopefile = new Scopefile(Scope.MeasureFileArray.Filename, LocalLineArraySafe___REFLECT, GlobaLineArraySafe___REFLECT, answer_DEBUG_is);

            this.Result = scopefile;

            return;
        }

        ~ScopefileSequence()
        {
            return;
        }
    }
}
