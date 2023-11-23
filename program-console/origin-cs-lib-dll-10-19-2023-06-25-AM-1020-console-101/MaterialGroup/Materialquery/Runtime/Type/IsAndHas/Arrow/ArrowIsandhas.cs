using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void ArrowRuntimeIsandhas(Char Character_LEFT, Char Character_RIGHT, Boolean answer_INVERT_should)
        {
            if (ArrowRuntimeCore(Character_LEFT, Character_RIGHT))
            {
                if (answer_INVERT_should)
                {
                    HasArrow = true;
                }
                else
                {
                    IsArrow = true;
                }
            }
            else
            {
                return;
            }
        }
    }
}
