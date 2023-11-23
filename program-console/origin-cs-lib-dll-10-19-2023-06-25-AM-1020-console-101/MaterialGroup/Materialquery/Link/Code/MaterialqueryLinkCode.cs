using Core;

namespace Core
{
    using System;

    public partial class MaterialqueryCode
    {
        public enum QueryType
        {
            Unset,
            Require,
            Option,
            Any,
            Some,
            Sequence,
            Separate,
            Sentence,
            Paragraph,
            UppercaseFlag,
            LowercaseFlag
        }
    }
}
