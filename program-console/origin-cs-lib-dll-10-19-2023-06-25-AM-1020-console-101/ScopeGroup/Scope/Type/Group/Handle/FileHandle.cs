using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void FileHandle()
        {
            try
            {
                AskFileCategory();

                GetFileCategory();

                IterationbeforeFileCategory();

                Frame();

                IterationafterFileCategory();

            } catch (Exception exception)
            {
                ScopeFatal.Action(new ScopeFatalLoopFileHandle().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
