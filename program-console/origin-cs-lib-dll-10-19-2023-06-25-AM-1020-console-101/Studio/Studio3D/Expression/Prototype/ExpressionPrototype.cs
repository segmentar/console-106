using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public Expression(ExpressionStringSafe stringIdentity, Object objectIdentity, Boolean answer_DEBUG_is)
        {
            this.StringIdentity = stringIdentity;

            this.ObjectIdentity = objectIdentity;

            if (answer_DEBUG_is is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
