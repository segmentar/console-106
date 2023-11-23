using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void ParenthesisRuntimeIsandhas(Char Character_LEFT, Char Character_RIGHT, Boolean answer_INVERT_should)
        {
            if (ParenthesisRuntimeCore(Character_LEFT, Character_RIGHT))
            {
                if (answer_INVERT_should)
                {
                    HasParenthesis = true;
                }
                else
                {
                    IsParenthesis = true;
                }
            }
            else
            {
                return;
            }
        }
    }
}
