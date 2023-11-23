using Core;

namespace Core
{
    using System;

    using System.Threading;
    using System.Threading.Tasks;

    public partial class Scope
    {
        public static Task ScopeMainTask()
        {
            Task taskResult = default;

            Task task;

            task = new Task(ScopeMainAction());

            taskResult = task;

            return taskResult;
        }
    }
}
