using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

using ArchitectureOneFirst = Core.DimensionTwoSecond.ArchitectureOneFirst;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String ConsoleDescriptor()
        {
            String stringResult = default;

            var line_feed = Convert.ToChar(10);

            var join = String.Join(line_feed.ToString(), new String[] {
            
                String.Empty,
                String.Empty + '\t' + $"This is `{ImmutableZeroTen.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.PathBootstrapOneFirst) + ':' + ' ' + ArchitectureOneFirst.PathBootstrapOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.PathBootstrapTwoSecond) + ':' + ' ' + ArchitectureOneFirst.PathBootstrapTwoSecond,
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.PathProgramOneFirst) + ':' + ' ' + ArchitectureOneFirst.PathProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.PathProgramTwoSecond) + ':' + ' ' + ArchitectureOneFirst.PathProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.InputPathProgramOneFirst) + ':' + ' ' + ArchitectureOneFirst.InputPathProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.InputPathProgramTwoSecond) + ':' + ' ' + ArchitectureOneFirst.InputPathProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.OutputPathProgramOneFirst) + ':' + ' ' + ArchitectureOneFirst.OutputPathProgramOneFirst,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.OutputPathProgramTwoSecond) + ':' + ' ' + ArchitectureOneFirst.OutputPathProgramTwoSecond,
                String.Empty,
                String.Empty + '\t' + ",,,,,",
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty
            });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
