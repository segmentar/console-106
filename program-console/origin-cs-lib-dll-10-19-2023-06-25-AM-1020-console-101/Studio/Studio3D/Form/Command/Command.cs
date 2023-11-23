using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Command : TextBox, IExposable<Command>, ICentralOrder, IStyleOrder, IEventOrder, ITimeOrder
    {
        public static Command Instance;

        public Command()
        {
            ExposeInstance();

            CentralOrder();

            return;
        }

        ~Command()
        {
            CleanInstance();

            return;
        }

        public Command ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public Command CleanInstance()
        {
            Instance = null;

            return this;
        }

        public void CentralOrder()
        {
            StyleOrder();

            EventOrder();

            TimeOrder();

            return;
        }

        public void StyleOrder()
        {
            Text = ImmutableConsoleLJTwoSecond.Text;

            Multiline = ImmutableConsoleLJTwoSecond.Multiline;

            AcceptsTab = ImmutableConsoleLJTwoSecond.AcceptTab;

            ReadOnly = ImmutableConsoleLJTwoSecond.ReadOnly;

            WordWrap = ImmutableConsoleLJTwoSecond.WordWrap;

            ScrollBars = ImmutableConsoleLJTwoSecond.ScrollBars;

            BackColor = ImmutableConsoleLJTwoSecond.BackColor;

            ForeColor = ImmutableConsoleLJTwoSecond.ForeColor;

            Font = new Font(ImmutableConsoleLJTwoSecond.FontFamily, ImmutableConsoleLJTwoSecond.FontSize, ImmutableConsoleLJTwoSecond.FontStyle);

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

        public void EventOrder()
        {
            KeyDown += Window.RedirectKeyDown;

            return;
        }
    }
}
