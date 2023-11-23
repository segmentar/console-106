using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        [MaterialIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Materialquery) + ' ' + "::" + ' ' + nameof(MaterialqueryRuntime) + ' ' + '{',
                String.Empty + '.' + "runtime",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsParenthesis) + ':' + ' ' + IsParenthesis,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(IsSquare) + ':' + ' ' + IsSquare,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(IsArrow) + ':' + ' ' + IsArrow,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(IsCurly) + ':' + ' ' + IsCurly,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(IsLJUpper) + ':' + ' ' + IsLJUpper,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(IsLJLower) + ':' + ' ' + IsLJLower,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(HasParenthesis) + ':' + ' ' + HasParenthesis,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(HasSquare) + ':' + ' ' + HasSquare,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(HasArrow) + ':' + ' ' + HasArrow,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(HasCurly) + ':' + ' ' + HasCurly,
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(HasLJUpper) + ':' + ' ' + HasLJUpper,
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(HasLJLower) + ':' + ' ' + HasLJLower,
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(BothRequire) + ':' + ' ' + BothRequire,
                String.Empty + '\t' + '~' + "14" + ' ' + nameof(BothOption) + ':' + ' ' + BothOption,
                String.Empty + '\t' + '~' + "15" + ' ' + nameof(BothAny) + ':' + ' ' + BothAny,
                String.Empty + '\t' + '~' + "16" + ' ' + nameof(BothSome) + ':' + ' ' + BothSome,
                String.Empty + '\t' + '~' + "17" + ' ' + nameof(BothSeparate) + ':' + ' ' + BothSeparate,
                String.Empty + '\t' + '~' + "18" + ' ' + nameof(BothSequence) + ':' + ' ' + BothSequence,
                String.Empty + '\t' + '~' + "19" + ' ' + nameof(BothSentence) + ':' + ' ' + BothSentence,
                String.Empty + '\t' + '~' + "20" + ' ' + nameof(BothParagraph) + ':' + ' ' + BothParagraph,
                String.Empty + '\t' + '~' + "21" + ' ' + nameof(BothUppercaseFlag) + ':' + ' ' + BothUppercaseFlag,
                String.Empty + '\t' + '~' + "22" + ' ' + nameof(BothLowercaseFlag) + ':' + ' ' + BothLowercaseFlag,
                String.Empty + '\t' + '~' + "23" + ' ' + nameof(QueryType) + ':' + ' ' + QueryType,
                String.Empty + '}'
            });
        }
    }
}
