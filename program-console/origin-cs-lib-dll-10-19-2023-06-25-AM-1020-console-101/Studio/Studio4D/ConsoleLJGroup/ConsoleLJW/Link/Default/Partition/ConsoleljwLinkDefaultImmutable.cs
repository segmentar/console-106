namespace Core
{
    using System;

    public partial class ConsoleLJWDefaultImmutableOneFirst
    {
        public static Boolean ShowIconDefault;

        public static Single OpacityDefault;

        public static String TextDefault;

        static ConsoleLJWDefaultImmutableOneFirst()
        {
            ShowIconDefault = false;

            OpacityDefault = 0.95F;

            TextDefault = nameof(ConsoleLJ);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ConsoleLJWDefaultImmutableTwoSecond
    {
        public static String TextDefault;

        public static Boolean MultilineDefault;

        public static Boolean AcceptTabDefault;

        public static Boolean ReadOnlyDefault;

        public static Boolean WordWrapDefault;

        public static ScrollBars ScrollBarsDefault;

        public static Color BackColorDefault;

        public static Color ForeColorDefault;

        public static FontFamily FontFamilyDefault;

        public static Single FontSizeDefault;

        public static FontStyle FontStyleDefault;

        static ConsoleLJWDefaultImmutableTwoSecond()
        {
            TextDefault = String.Empty;

            MultilineDefault = true;

            AcceptTabDefault = true;

            ReadOnlyDefault = true;

            WordWrapDefault = false;

            ScrollBarsDefault = ScrollBars.Both;

            BackColorDefault = Color.Blue;

            ForeColorDefault = Color.Yellow;

            FontFamilyDefault = new FontFamily("Consolas");

            FontSizeDefault = 12.00F;

            FontStyleDefault = FontStyle.Regular;

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Drawing;

    public partial class ConsoleLJWDefaultImmutableThreeThird
    {
        public static Color BackColorDefault;

        public static Color ForeColorDefault;

        public static FontFamily FontFamilyDefault;

        public static Single FontSizeDefault;

        public static FontStyle FontStyleDefault;

        static ConsoleLJWDefaultImmutableThreeThird()
        {
            BackColorDefault = Color.Black;

            ForeColorDefault = Color.GreenYellow;

            FontFamilyDefault = new FontFamily("Consolas");

            FontSizeDefault = 16.00F;

            FontStyleDefault = FontStyle.Regular;

            return;
        }
    }
}
