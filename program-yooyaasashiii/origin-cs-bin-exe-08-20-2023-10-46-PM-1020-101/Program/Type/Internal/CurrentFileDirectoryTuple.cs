using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal partial class Program
    {
        internal Tuple<String, String> CurrentFileDirectoryTuple()
        {
            Tuple<String, String> tupleResult = default;

            String currentFile, currentDirectory;

            currentFile = Assembly.GetExecutingAssembly().Location;

            currentDirectory = Path.GetDirectoryName(currentFile);

            tupleResult = new Tuple<String, String>(currentFile, currentDirectory);

            return tupleResult;
        }
    }
}
