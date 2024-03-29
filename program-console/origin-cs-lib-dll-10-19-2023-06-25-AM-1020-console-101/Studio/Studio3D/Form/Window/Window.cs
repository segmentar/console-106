﻿using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    using System.Drawing;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Window : Form, IExposable<Window>, ICentralOrder, IAssignOrder, IBindOrder, IStyleOrder, IControlOrder
    {
        public static Window Instance;

        public static Point InstanceLocation;

        public static Size InstanceSize;

        public Window()
        {
            ExposeInstance();

            CentralOrder();

            return;
        }

        ~Window()
        {
            CleanInstance();

            return;
        }

        public Window ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public Window CleanInstance()
        {
            Instance = null;

            return this;
        }

        public void CentralOrder()
        {
            AssignOrder();

            BindOrder();

            StyleOrder();

            ControlOrder();

            return;
        }
        public void AssignOrder()
        {
            Single widthf, heightf;

            widthf = Screen.PrimaryScreen.Bounds.Width / 1.50F;

            heightf = Screen.PrimaryScreen.WorkingArea.Height / 1.50F;

            Int32 width, height;

            width = Convert.ToInt32(widthf);

            height = Convert.ToInt32(heightf);

            Size size;

            size = new Size(width, height);

            Single xf, yf;

            xf = Screen.PrimaryScreen.Bounds.Width / 2.00F - widthf / 2.00F;

            yf = Screen.PrimaryScreen.Bounds.Height / 2.00F - heightf / 2.00F;

            Int32 x, y;

            x = Convert.ToInt32(xf);

            y = Convert.ToInt32(yf);

            Point point;

            point = new Point(x, y);

            InstanceSize = size;

            InstanceLocation = point;

            return;
        }

        public void BindOrder()
        {
            Location = InstanceLocation;

            Size = InstanceSize;

            return;
        }

        public void StyleOrder()
        { 
            ShowIcon = ImmutableConsoleLJOneFirst.ShowIcon;

            Opacity = ImmutableConsoleLJOneFirst.Opacity;

            Text = ImmutableConsoleLJOneFirst.Text;

            StartPosition = FormStartPosition.Manual;

            return;
        }

        public void ControlOrder()
        {
            Controls.Add(new Command().ExposeInstance());

            Controls.Add(new Prompt().ExposeInstance());

            return;
        }
    }
}
