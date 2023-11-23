using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void ProcessFileArray(String[] File_ARRAY, Boolean answer_GUI_should)
        {
            try
            {
                Procedure(true, true);

                Manual(true);

                MeasureRuntime();

                SetFileArray(File_ARRAY);

                SetPrimaryWait(1000);

                SetSecondaryWait(20);

                SetShouldGUI(answer_GUI_should);

                Run();

                ResetFilePointer();

                LoopFileArray();

                Exit();

            } catch (Exception exception)
            {
                ScopeFatal.Action(new ScopeFatalProcessFileArray().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
