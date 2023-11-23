using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class ScopeMainWindow : Form,
Scope.IScopeCentralorder,
Scope.IScopeStyleorder,
Scope.IScopeEventorder
    {
        public ScopeMainWindow()
        {
            CentralOrder();

            return;
        }

        ~ScopeMainWindow()
        {
            return;
        }

        public void CentralOrder()
        {
            StyleOrder();

            EventOrder();

            return;
        }

        public void EventOrder()
        {
            KeyDown += ScopeDisplay.HandleKeyDown;

            return;
        }

        public void StyleOrder()
        {
            var Icon_PATH = Scope.SolidStudio(ScopeCode.StudioPath.Studio2D, "Resource-Icon-Icon.png");

            var Background_PATH = Scope.SolidStudio(ScopeCode.StudioPath.Studio2D, "Resource-Background-Background.png");

            using (Bitmap bitmap = new Bitmap(Icon_PATH))
            {
                Icon icon;
                
                icon = Icon.FromHandle(bitmap.GetHicon());

                this.Icon = icon;
            }

            this.FormBorderStyle = FormBorderStyle.None;

            this.BackgroundImage = Image.FromFile(Background_PATH);

            this.BackgroundImageLayout = ImageLayout.Stretch;

            return;
        }
    }
}
