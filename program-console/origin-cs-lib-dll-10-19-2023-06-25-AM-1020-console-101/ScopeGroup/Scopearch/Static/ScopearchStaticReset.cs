using Core;

namespace Core
{
    using System;

    public partial class Scopearch
    {
        public static void Reset()
        {
            try
            {
                Template = ScopeTemplate.ForgeScopeTemplate();

                ScopearchPrimaryDo();

                Scope.Template = Template;

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalReset().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
