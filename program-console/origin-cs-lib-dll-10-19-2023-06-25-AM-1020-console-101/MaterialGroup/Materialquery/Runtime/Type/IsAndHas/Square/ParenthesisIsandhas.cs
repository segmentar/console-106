using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryRuntime
    {
        public void SquareRuntimeIsandhas(Char Character_LEFT, Char Character_RIGHT, Boolean answer_INVERT_should)
        {
            if (SquareRuntimeCore(Character_LEFT, Character_RIGHT))
            {
                if (answer_INVERT_should)
                {
                    HasSquare = true;
                }
                else
                {
                    IsSquare = true;
                }
            }
            else
            {
                return;
            }
        }
    }
}
