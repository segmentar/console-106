using Core;

namespace Core.DimensionTwoSecondSecondaryII.Scope
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public static partial class ScopeTextBoxImmutable
    {
        public readonly static Boolean WordWrap;

        public readonly static Boolean ReadOnly;

        public readonly static Boolean Multiline;

        public readonly static Color ForeColor;

        public readonly static Color BackColor;

        public readonly static DockStyle Dock;

        public readonly static Font Font;

        static ScopeTextBoxImmutable()
        {
            WordWrap = ScopeTextBoxDefault.WordWrapDefault;

            ReadOnly = ScopeTextBoxDefault.ReadOnlyDefault;

            Multiline = ScopeTextBoxDefault.MultilineDefault;

            ForeColor = ScopeTextBoxDefault.ForeColorDefault;

            BackColor = ScopeTextBoxDefault.BackColorDefault;

            Dock = ScopeTextBoxDefault.DockDefault;

            Font = ScopeTextBoxDefault.FontDefault;

            return;
        }
    }
}
