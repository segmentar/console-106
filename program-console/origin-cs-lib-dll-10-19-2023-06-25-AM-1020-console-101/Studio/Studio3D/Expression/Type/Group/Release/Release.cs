using Core;

namespace Core
{
    public partial class Expression
    {
        public void Release()
        {
            IRelease();

            return;
        }
    }
}