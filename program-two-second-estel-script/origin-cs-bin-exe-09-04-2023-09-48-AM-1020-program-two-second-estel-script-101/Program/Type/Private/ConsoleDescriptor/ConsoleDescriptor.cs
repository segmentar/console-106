using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private String ConsoleDescriptor()
        {
            String stringResult = default;

            var descriptor = String.Join('\n'.ToString(), new String[] { 
            
                String.Empty,
                String.Empty + '\t' + $"This is `{Immutable.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Write file extension to look for" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.HasEscapeCharacter) + ':' + ' ' + ArchitecturePageOneFirst.HasEscapeCharacter,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.EscapeCharacter) + ':' + ' ' + ArchitecturePageOneFirst.EscapeCharacter,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.HasNativeString) + ':' + ' ' + ArchitecturePageOneFirst.HasNativeString,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.NativeString) + ':' + ' ' + ArchitecturePageOneFirst.NativeString,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.HasInputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.HasInputDirectory,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.InputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.InputDirectory,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.HasOutputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.HasOutputDirectory,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageOneFirst.OutputDirectory) + ':' + ' ' + ArchitecturePageOneFirst.OutputDirectory,
                String.Empty,
                String.Empty + '\t' + '\t' + ' ' + nameof(ArchitecturePageTwoSecond.Extension) + ':' + ' ' + ArchitecturePageTwoSecond.Extension,
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty
            });

            stringResult = descriptor;

            return stringResult;
        }
    }
}
