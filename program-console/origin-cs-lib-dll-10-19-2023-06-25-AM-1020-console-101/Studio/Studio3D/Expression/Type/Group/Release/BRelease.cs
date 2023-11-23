using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void BRelease()
        {
            BindList.Clear();

            return;
        }
    }
}
