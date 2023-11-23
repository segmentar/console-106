using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ScopeDisplayDefault
    {
        public static FormBorderStyle FormBorderStyleDefault;

        public static FormStartPosition FormStartPositionDefault;

        public static String TextDefault;

        public static Boolean ShowIconDefault;

        public static Boolean KeyPreviewDefault;

        public static Boolean ShowInTaskBarDefault;

        static ScopeDisplayDefault()
        {
            FormBorderStyleDefault = FormBorderStyle.None;

            FormStartPositionDefault = FormStartPosition.Manual;

            TextDefault = String.Empty;

            ShowIconDefault = false;

            KeyPreviewDefault = true;

            ShowInTaskBarDefault = false;

            return;
        }
    }
}
