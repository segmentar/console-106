using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void Unlock(String String_VALUE)
        {
            LastLock = IUnlock(String_VALUE);

            return;
        }
    }
}
