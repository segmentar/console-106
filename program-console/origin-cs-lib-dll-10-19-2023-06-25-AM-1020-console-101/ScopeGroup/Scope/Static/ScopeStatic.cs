using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        static Scope()
        {
            return;
        }

        public static void Procedure(Boolean MaterialHas__ANSWER, Boolean MaterialreflectHas__ANSWER)
        {
            if (MaterialHas__ANSWER is true)
            {
                Material.Procedure();
            }
            else
                "false".ToString();

            if (MaterialreflectHas__ANSWER is true)
            {
                Materialreflect.Procedure();
            }
            else
                "false".ToString();

            ScopefilePolicy.ScopefileDebugPolicy = true;

            ScopefilePolicy.ScopefileInfoPolicy = true;

            return;
        }

        public static void Manual(Boolean HostIs__ANSWER)
        {
            if (HostIs__ANSWER is true)
            {
                Host.Manual();
            }
            else
                "false".ToString();

            return;
        }

        public static void Raise(Boolean MaterialHas__ANSWER, Boolean MaterialreflectHas__ANSWER)
        {
            if (MaterialHas__ANSWER is true)
            {
                Material.Raise();
            }
            else
                "false".ToString();

            if (MaterialreflectHas__ANSWER is true)
            {
                Materialreflect.Raise();
            }
            else
                "false".ToString();

            if (ScopefilePolicy.ScopefileInfoPolicy is true)
            {
                Render($"{ScopeCode.RenderPath.Core_Scope_Info}-{nameof(Scopefile)}Info", ScopefilePolicy.ScopefileArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
            Hostlocalline.Bundle();

            return;
        }
    }
}
