using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void CurlyRuntimeIsandhas(Char Character_LEFT, Char Character_RIGHT, Boolean answer_INVERT_should)
        {
            if (CurlyRuntimeCore(Character_LEFT, Character_RIGHT))
            {
                if (answer_INVERT_should)
                {
                    HasCurly = true;
                }
                else
                {
                    IsCurly = true;
                }
            }
            else
            {
                return;
            }
        }
    }
}
