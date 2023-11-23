using Core;

namespace Core
{
    using System;

    public partial class ProgramModuleFunctionFirst
    {
        public String CurrentFile;

        public String CurrentFolder;

        public String WorkingDirectory;

        public ProgramModuleFunctionFirst(String currentFile, String currentFolder, String workingDirectory)
        {
            this.CurrentFile = currentFile;

            this.CurrentFolder = currentFolder;

            this.WorkingDirectory = workingDirectory;

            return;
        }

        ~ProgramModuleFunctionFirst()
        {
            return;
        }
    }
}
