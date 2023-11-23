using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    internal static class Immutable
    {
        internal static readonly String WorkingDirectoryName = $"working-directory-{Path.GetRandomFileName()}";

        internal static readonly String ProgramName = Assembly.GetExecutingAssembly().GetName().Name;
    }
}
