using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    using System.Drawing;

    public partial class ScopeDisplayContext : ApplicationContext,
Scope.IScopeExposable<ScopeDisplayContext>
    {
        public static ScopeDisplayContext Instance;

        public ScopeDisplayContext() : base(new ScopeMainWindow())
        {
            ExposeInstance();

            var RowWidth_Onefirst = (Screen.PrimaryScreen.Bounds.Width / 3);

            var RowHeight_Onefirst = ((Screen.PrimaryScreen.WorkingArea.Height / 3) * 0);

            var RowWidth_Twosecond = (Screen.PrimaryScreen.Bounds.Width / 3);

            var RowHeight_Twosecond = ((Screen.PrimaryScreen.WorkingArea.Height / 3) * 1);

            var RowWidth_Threethird = (Screen.PrimaryScreen.Bounds.Width / 3);

            var RowHeight_Threethird = ((Screen.PrimaryScreen.WorkingArea.Height / 3) * 2);

            ScopeDisplay
                scopeDisplayOnefirst,
                scopeDisplayTwosecond,
                scopeDisplayThreethird,
                scopeDisplayFourfourth,
                scopeDisplayFivefifth,
                scopeDisplaySixsixth,
                scopeDisplaySevenseventh,
                scopeDisplayEighteighth,
                scopeDisplayNineninth
                ;

            scopeDisplayOnefirst = new ScopeDisplay();

            scopeDisplayOnefirst.Location = new Point((RowWidth_Onefirst * 0), RowHeight_Onefirst);

            scopeDisplayOnefirst.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplayTwosecond = new ScopeDisplay();

            scopeDisplayTwosecond.Location = new Point((RowWidth_Onefirst * 1), RowHeight_Onefirst);

            scopeDisplayTwosecond.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplayThreethird = new ScopeDisplay();

            scopeDisplayThreethird.Location = new Point((RowWidth_Onefirst * 2), RowHeight_Onefirst);

            scopeDisplayThreethird.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplayFourfourth = new ScopeDisplay();

            scopeDisplayFourfourth.Location = new Point((RowWidth_Twosecond * 0), RowHeight_Twosecond);

            scopeDisplayFourfourth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplayFivefifth = new ScopeDisplay();

            scopeDisplayFivefifth.Location = new Point((RowWidth_Twosecond * 1), RowHeight_Twosecond);

            scopeDisplayFivefifth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplaySixsixth = new ScopeDisplay();

            scopeDisplaySixsixth.Location = new Point((RowWidth_Twosecond * 2), RowHeight_Twosecond);

            scopeDisplaySixsixth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplaySevenseventh = new ScopeDisplay();

            scopeDisplaySevenseventh.Location = new Point((RowWidth_Threethird * 0), RowHeight_Threethird);

            scopeDisplaySevenseventh.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplayEighteighth = new ScopeDisplay();

            scopeDisplayEighteighth.Location = new Point((RowWidth_Threethird * 1), RowHeight_Threethird);

            scopeDisplayEighteighth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            scopeDisplayNineninth = new ScopeDisplay();

            scopeDisplayNineninth.Location = new Point((RowWidth_Threethird * 2), RowHeight_Threethird);

            scopeDisplayNineninth.Size = new Size(RowWidth_Onefirst, (Screen.PrimaryScreen.WorkingArea.Height / 3));

            ScopeDisplayArrayList.Add(scopeDisplayOnefirst);

            ScopeDisplayArrayList.Add(scopeDisplayTwosecond);

            ScopeDisplayArrayList.Add(scopeDisplayThreethird);

            ScopeDisplayArrayList.Add(scopeDisplayFourfourth);

            ScopeDisplayArrayList.Add(scopeDisplayFivefifth);

            ScopeDisplayArrayList.Add(scopeDisplaySixsixth);

            ScopeDisplayArrayList.Add(scopeDisplaySevenseventh);

            ScopeDisplayArrayList.Add(scopeDisplayEighteighth);

            ScopeDisplayArrayList.Add(scopeDisplayNineninth);

            return;
        }

        ~ScopeDisplayContext()
        {
            CleanInstance();

            return;
        }

        public ScopeDisplayContext ExposeInstance()
        {
            Instance = this;

            return this;
        }

        public ScopeDisplayContext CleanInstance()
        {
            Instance = null;

            return this;
        }
    }
}
