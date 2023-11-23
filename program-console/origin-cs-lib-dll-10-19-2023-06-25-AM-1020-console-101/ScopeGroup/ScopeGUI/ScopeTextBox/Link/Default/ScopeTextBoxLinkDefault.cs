using Core;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ScopeTextBoxDefault
    {
        public static Boolean WordWrapDefault;

        public static Boolean ReadOnlyDefault;

        public static Boolean MultilineDefault;

        public static Color ForeColorDefault;

        public static Color BackColorDefault;

        public static DockStyle DockDefault;

        public static Font FontDefault;

        static ScopeTextBoxDefault()
        {
            WordWrapDefault = true;

            ReadOnlyDefault = true;

            MultilineDefault = true;

            ForeColorDefault = Color.Yellow;

            BackColorDefault = Color.Black;

            DockDefault = DockStyle.Fill;

            FontDefault = new Font("Consolas", 10.00F, FontStyle.Bold);

            return;
        }
    }
}