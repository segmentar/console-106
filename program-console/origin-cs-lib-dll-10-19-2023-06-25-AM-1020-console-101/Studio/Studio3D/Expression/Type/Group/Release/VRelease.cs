using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void VRelease()
        {
            Release();

            View();

            return;
        }
    }
}
