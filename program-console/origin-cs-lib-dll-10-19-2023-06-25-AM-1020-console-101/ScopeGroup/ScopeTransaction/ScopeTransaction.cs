using Core;

namespace Core
{
    using System;

    public partial class ScopeTransaction
    {
        public String Filename;

        public String[] WindowArray;

        public ScopeTransaction(String filename, String[] windowArray)
        {
            this.Filename = filename;

            this.WindowArray = windowArray;

            return;
        }

        ~ScopeTransaction()
        {
            return;
        }
    }
}
