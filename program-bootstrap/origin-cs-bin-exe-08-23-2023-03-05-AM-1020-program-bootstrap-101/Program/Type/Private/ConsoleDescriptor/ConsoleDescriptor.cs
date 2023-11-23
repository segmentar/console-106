using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        private String ConsoleDescriptor()
        {
            String stringResult = default;

            var join = String.Join('\n'.ToString(), new String[] {

                    String.Empty,
                    String.Empty + '\t' + $"This is called `{ImmutableOneFirst.ProgramName}`" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + "Write `escape` to run and exit" + ' ' + '.',
                    String.Empty,
                    String.Empty + '\t' + ",,,,,",
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.HasEscapeCharacter) + ':' + ' ' + ArchitectureOneFirst.HasEscapeCharacter,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.EscapeCharacter) + ':' + ' ' + (ArchitectureOneFirst.EscapeCharacter.Equals(default) is true ? String.Empty : ArchitectureOneFirst.EscapeCharacter.ToString()),
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.HasNativeString) + ':' + ' ' + ArchitectureOneFirst.HasNativeString,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.NativeString) + ':' + ' ' + ArchitectureOneFirst.NativeString,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.HasInputDirectory) + ':' + ' ' + ArchitectureOneFirst.HasInputDirectory,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.InputDirectory) + ':' + ' ' + ArchitectureOneFirst.InputDirectory,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.HasOutputDirectory) + ':' + ' ' + ArchitectureOneFirst.HasOutputDirectory,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureOneFirst.OutputDirectory) + ':' + ' ' + ArchitectureOneFirst.OutputDirectory,
                    String.Empty,
                    String.Empty + '\t' + ",,,,,",
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureTwoSecond.ApplicationName) + ':' + ' ' + ArchitectureTwoSecond.ApplicationName,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureTwoSecond.ApplicationVersion) + ':' + ' ' + ArchitectureTwoSecond.ApplicationVersion,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureTwoSecond.ApplicationType) + ':' + ' ' + ArchitectureTwoSecond.ApplicationType,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureTwoSecond.StudioType) + ':' + ' ' + ArchitectureTwoSecond.StudioType,
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureTwoSecond.ApplicationType) + ' ' + $"{{ {String.Join(", ", Enum.GetNames(typeof(ProgramCode.ApplicationType)))} }}",
                    String.Empty,
                    String.Empty + '\t' + '\t' + nameof(ArchitectureTwoSecond.StudioType) + ' ' + $"{{ {String.Join(", ", Enum.GetNames(typeof(ProgramCode.StudioType)))} }}",
                    String.Empty,
                    String.Empty + '\t' + ",,,,,",
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + "ac" + ' ' + "add-classification" + ' ' + "<classification-name>" + ' ' + "<classification-namespace>" + ' ' + "<classification-static>" + ' ' + "<classification-runtime>" + ' ' + "<classification-measure>",
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + "am" + ' ' + "add-modulation" + ' ' + "<modulation-name>" + ' ' + "<modulation-namespace>" + ' ' + "<modulation-count>" + ' ' + "<modulation-action>",
                    String.Empty,
                    String.Empty + '\t' + '~' + ' ' + "ai" + ' ' + "add-icon" + ' ' + "<icon-name>" + ' ' + "<icon-seed>" + ' ' + "<icon-count>" + ' ' + "<icon-fore-color>" + ' ' + "<icon-back-clor>" + ' ' + "<icon-fore-ratio>" + ' ' + "<icon-back-ratio>",
                    String.Empty,
                    String.Empty + '\t' + ",,,,,",
                    String.Empty,
                    String.Empty + '\t' + "Prompt" + ':' + ' ',
                    String.Empty,
                    String.Empty + '\t' + ArchitectureTwoSecond.ClassStringBuilder,
                    String.Empty,
                    String.Empty + '\t' + ArchitectureTwoSecond.ModuleStringBuilger,
                    String.Empty,
                    String.Empty + '\t' + ArchitectureTwoSecond.IconStringBuilder
                });

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
