using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void FilePrimaryIteration()
        {
            LocalLineCheck();

            GlobalLineCheck();

            MaterialHeaderCheck();

            MaterialFooterCheck();

            MaterialValidateCheck();

            return;
        }
    }
}
