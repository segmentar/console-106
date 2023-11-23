using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void QueryTypeRuntime()
        {
            if (BothRequire)
            {
                QueryType = MaterialqueryCode.QueryType.Require;
            }
            else if (BothOption)
            {
                QueryType = MaterialqueryCode.QueryType.Option;
            }
            else if (BothAny)
            {
                QueryType = MaterialqueryCode.QueryType.Any;
            }
            else if (BothSome)
            {
                QueryType = MaterialqueryCode.QueryType.Some;
            }
            else if (BothSeparate)
            {
                QueryType = MaterialqueryCode.QueryType.Separate;
            }
            else if (BothSequence)
            {
                QueryType = MaterialqueryCode.QueryType.Sequence;
            }
            else if (BothSentence)
            {
                QueryType = MaterialqueryCode.QueryType.Sentence;
            }
            else if (BothParagraph)
            {
                QueryType = MaterialqueryCode.QueryType.Paragraph;
            }
            else if (BothUppercaseFlag)
            {
                QueryType = MaterialqueryCode.QueryType.UppercaseFlag;
            }
            else if (BothLowercaseFlag)
            {
                QueryType = MaterialqueryCode.QueryType.LowercaseFlag;
            }
            else
            {
                QueryType = MaterialqueryCode.QueryType.Unset;
            }

            return;
        }
    }
}
