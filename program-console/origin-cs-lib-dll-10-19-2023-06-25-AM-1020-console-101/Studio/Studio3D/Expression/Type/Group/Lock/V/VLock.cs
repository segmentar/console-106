using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void VLock(String String_VALUE)
        {
            View();

            Lock(String_VALUE);

            return;
        }
    }
}
