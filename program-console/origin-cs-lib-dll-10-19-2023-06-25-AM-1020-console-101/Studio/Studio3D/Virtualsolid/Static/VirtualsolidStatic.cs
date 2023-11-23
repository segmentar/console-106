using Core;

namespace Core
{
    using System;

    public partial class Virtualsolid
    {
        static Virtualsolid()
        {
            return;
        }

        public static void Procedure()
        {
            VirtualfilePolicy.VirtualFileDebugPolicy = true;

            VirtualfilePolicy.VirtualFileInfoPolicy = true;

            return;
        }

        public static void Manual()
        {
            return;
        }

        public static void Raise()
        {
            if (VirtualfilePolicy.VirtualFileInfoPolicy is true)
            {
                Virtualsolid.Render($"{VirtualsolidCode.RenderPath.Core_Info_Virtualfile}-{nameof(Virtualfile)}Info", VirtualfilePolicy.VirtaulFileArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        public static void Bundle()
        {
            Procedure();

            Manual();

            Raise();

            return;
        }
    }
}
