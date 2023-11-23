using Core;

namespace Core
{
    using System;

    public partial class Host
    {
        public static void ProcessFileArray(String[] File_ARRAY, Boolean answer_GUI_should, Boolean answer_TRY_CATCH_is)
        {
            var array = HostIgnoreSetSurface(File_ARRAY, "package");

            if (answer_TRY_CATCH_is)
            {
                try
                {
                    Scope.ProcessFileArray(array, answer_GUI_should);
                }
                catch (Exception exception)
                {
                    ConsoleLJS.Log(false, exception);
                }
            }
            else
            {
                Scope.ProcessFileArray(array, answer_GUI_should);
            }

            return;
        }
    }
}
