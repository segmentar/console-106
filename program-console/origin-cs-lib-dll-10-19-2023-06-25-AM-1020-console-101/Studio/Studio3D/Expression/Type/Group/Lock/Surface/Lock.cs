using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Lock(String String_VALUE)
        {
            LastLock = ILock(String_VALUE);

            return;
        }
    }
}
