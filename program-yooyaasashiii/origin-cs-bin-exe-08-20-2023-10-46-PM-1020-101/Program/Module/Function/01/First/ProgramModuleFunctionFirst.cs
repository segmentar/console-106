using Core;

namespace Core
{
    using System;

    internal partial class ProgramModuleFunctionFirst
    {
        internal String CurrentFile;

        internal String CurrentDirectory;

        internal ProgramModuleFunctionFirst(String currentFile, String currentDirectory)
        {
            this.CurrentFile = currentFile;

            this.CurrentDirectory = currentDirectory;

            return;
        }

        ~ProgramModuleFunctionFirst()
        {
            return;
        }
    }
}
