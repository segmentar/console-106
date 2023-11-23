using Core;

namespace Core
{
    using System;

    public partial class ScopeTextBox
    {
        public String TextProperty
        { 
            get {

                return Text;
            }
            set {

                var Entity_LINE_FEED = Convert.ToChar(10);

                var Entity_CARRIAGE_RETURN = Convert.ToChar(13);

                var separator = new Char[] { Entity_LINE_FEED, Entity_CARRIAGE_RETURN };

                var split = value.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                var Entity_NEW_LINE = String.Concat(Entity_CARRIAGE_RETURN, Entity_LINE_FEED);

                var join = String.Join(Entity_NEW_LINE, split);

                var result = join;

                Text = result;
            }
        }
    }
}
