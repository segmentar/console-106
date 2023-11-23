using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public Boolean IsParenthesis;

        public Boolean IsSquare;

        public Boolean IsArrow;

        public Boolean IsCurly;

        public Boolean IsLJUpper;

        public Boolean IsLJLower;

        public Boolean HasParenthesis;

        public Boolean HasSquare;

        public Boolean HasArrow;

        public Boolean HasCurly;

        public Boolean HasLJUpper;

        public Boolean HasLJLower;

        public Boolean BothRequire;

        public Boolean BothOption;

        public Boolean BothAny;

        public Boolean BothSome;

        public Boolean BothSeparate;

        public Boolean BothSequence;

        public Boolean BothSentence;

        public Boolean BothParagraph;

        public Boolean BothUppercaseFlag;

        public Boolean BothLowercaseFlag;

        public MaterialqueryCode.QueryType QueryType;
    }
}
