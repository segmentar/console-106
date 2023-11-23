using Core;

using Core.DimensionTwoSecondSecondaryII.ConsoleLJ;

namespace Core
{
    using System;

    public partial class ConsoleLJ
    {

        [IntentionalShortMethod]
        private static String[] InteropDescriptor()
        {
            String[] arrayResult = default;

            var descriptor = new String[] {

                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.EscapeCharacter) + ':' + ' ' + ((ArchitectureConsoleLJOneFirst.EscapeCharacter == default) ? String.Empty : ArchitectureConsoleLJOneFirst.EscapeCharacter.ToString()),
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasEscapeCharacter) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasEscapeCharacter,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.TerminatorCharacter) + ':' + ' ' + ((ArchitectureConsoleLJOneFirst.TerminatorCharacter == default) ? String.Empty : ArchitectureConsoleLJOneFirst.TerminatorCharacter.ToString()),
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasTerminatorCharacter) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasTerminatorCharacter,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.NativeString) + ':' + ' ' + ArchitectureConsoleLJOneFirst.NativeString,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasNativeString) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasNativeString,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.SharedString) + ':' + ' ' + ArchitectureConsoleLJOneFirst.SharedString,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasSharedString) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasSharedString,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.InputDirectory) + ':' + ' ' + ArchitectureConsoleLJOneFirst.InputDirectory,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasInputDirectory) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasInputDirectory,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasValidInputDirectory) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasValidInputDirectory,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.OutputDirectory) + ':' + ' ' + ArchitectureConsoleLJOneFirst.OutputDirectory,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasOutputDirectory) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasOutputDirectory,
                String.Empty,
                String.Empty + '\t' + nameof(ArchitectureConsoleLJOneFirst.HasValidOutputDirectory) + ':' + ' ' + ArchitectureConsoleLJOneFirst.HasValidOutputDirectory,
                String.Empty,
                String.Empty + '\t' + ArchitectureConsoleLJOneFirst.AutoCommandStringBuilder.ToString(),
            };

            arrayResult = descriptor;

            return arrayResult;
        }
    }
}
