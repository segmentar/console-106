using Core;

namespace Core
{
    using System;

    public partial class Expression
    {
        public void IView(Expression Expression_VALUE)
        {
            ViewList.Add(Expression_VALUE);

            return;
        }
    }
}
