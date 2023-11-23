using Core;

using Core.DimensionTwoSecondSecondaryII.Scope;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class ScopeDisplay : Form,
Scope.IScopeExposable<ScopeDisplay>, 
Scope.IScopeCentralorder,
Scope.IScopeStyleorder, 
Scope.IScopeEventorder,
Scope.IScopeControlorder
    {
        public static ScopeDisplay Instance;

        public ScopeDisplay()
        {
            ExposeInstance();

            CentralOrder();

            return;
        }

        ~ScopeDisplay()
        {
            CleanInstance();

            return;
        }

        public ScopeDisplay ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public ScopeDisplay CleanInstance()
        {
            Instance = null;

            return this;
        }

        public void CentralOrder()
        {
            StyleOrder();

            EventOrder();

            ControlOrder();

            return;
        }

        public void StyleOrder()
        {
            this.FormBorderStyle = ScopeDisplayImmutable.FormBorderStyle;

            this.StartPosition = ScopeDisplayImmutable.FormStartPosition;

            this.Text = ScopeDisplayImmutable.Text;

            this.ShowIcon = ScopeDisplayImmutable.ShowIcon;

            this.KeyPreview = ScopeDisplayImmutable.KeyPreview;

            this.ShowInTaskbar = ScopeDisplayImmutable.ShowInTaskBar;

            this.Select();

            return;
        }
        public void EventOrder()
        {
            this.KeyDown += HandleKeyDown;

            return;
        }

        public void ControlOrder()
        {
            ScopeTextBox scopeTextBox;

            scopeTextBox = new ScopeTextBox();

            this.Controls.Add(scopeTextBox);

            return;
        }
    }
}
