using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public interface IScopeBindorder
        {
            void BindOrder();
        }
    }
}
