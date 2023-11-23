using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void FileArrayHandle()
        {
            try
            {
                AskFileArrayCategory();

                GetFileArrayCategory();

                IterationbeforeFileArrayCategory();

                LoopFile();

                IterationafterFileArrayCategory();

            } catch (Exception exception)
            {
                ScopeFatal.Action(new ScopeFatalLoopFileArrayHandle().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
