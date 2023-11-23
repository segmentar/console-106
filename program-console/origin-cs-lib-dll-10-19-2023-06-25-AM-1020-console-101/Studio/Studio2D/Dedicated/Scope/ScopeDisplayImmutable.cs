using Core;

namespace Core.DimensionTwoSecondSecondaryII.Scope
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public static partial class ScopeDisplayImmutable
    {
        public readonly static FormBorderStyle FormBorderStyle;

        public readonly static FormStartPosition FormStartPosition;

        public readonly static String Text;

        public readonly static Boolean ShowIcon;

        public readonly static Boolean KeyPreview;

        public readonly static Boolean ShowInTaskBar;

        static ScopeDisplayImmutable()
        {
            FormBorderStyle = ScopeDisplayDefault.FormBorderStyleDefault;

            FormStartPosition = ScopeDisplayDefault.FormStartPositionDefault;

            Text = ScopeDisplayDefault.TextDefault;

            ShowIcon = ScopeDisplayDefault.ShowIconDefault;

            KeyPreview = ScopeDisplayDefault.KeyPreviewDefault;

            ShowInTaskBar = ScopeDisplayDefault.ShowInTaskBarDefault;

            return;
        } 
    }
}