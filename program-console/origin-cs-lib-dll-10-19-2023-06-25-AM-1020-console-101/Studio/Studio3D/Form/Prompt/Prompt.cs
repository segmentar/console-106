using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Prompt : TextBox, IExposable<Prompt>, ICentralOrder, IStyleOrder, ITimeOrder
    {
        public static Prompt Instance;

        public Prompt()
        {
            ExposeInstance();

            CentralOrder();

            return;
        }

        ~Prompt()
        {
            CleanInstance();

            return;
        }

        public Prompt ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public Prompt CleanInstance()
        {
            Instance = null;

            return this;
        }

        public void CentralOrder()
        {
            StyleOrder();

            TimeOrder();

            return;
        }

        public void StyleOrder()
        {
            BackColor = ImmutableConsoleLJThreeThird.BackColor;

            ForeColor = ImmutableConsoleLJThreeThird.ForeColor;

            Font = new Font(ImmutableConsoleLJThreeThird.FontFamily, ImmutableConsoleLJThreeThird.FontSize, ImmutableConsoleLJThreeThird.FontStyle);

            return;
        }

        public void TimeOrder()
        {
            Timer timer;

            timer = new Timer();

            timer.Tick += TickCentral;

            timer.Start();

            return;
        }
    }
}
