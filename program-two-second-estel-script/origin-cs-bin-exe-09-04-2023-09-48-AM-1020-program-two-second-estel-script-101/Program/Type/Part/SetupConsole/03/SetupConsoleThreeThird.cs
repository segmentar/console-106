using Core;

namespace Core
{
	using System;

	internal partial class Program
	{
		internal void SetupConsoleThreeThird(String[] split, String lower, Boolean haslength)
		{
            foreach (Tuple<String, String> tuple in ProgramSplitNameValueContainerSurface<Tuple<String, String>>(split))
            {
                String name, value;

                name = tuple.Item1;

                value = tuple.Item2;

                var boolean_match__EQUAL_THAN = (value == String.Empty);

                Boolean isEmptyCheck, isEmptyNotCheck;

                isEmptyCheck = boolean_match__EQUAL_THAN is true;

                isEmptyNotCheck = isEmptyCheck is false;

                var reflect_STRING = default(String);

                var reflect_CHARACTER = default(Char);

                reflect_STRING = value;

                try
                {
                    reflect_CHARACTER = reflect_STRING[0];

                } catch (Exception exception)
                {
                    exception.ToString();
                }

                switch (name)
                {
                    case nameof(ArchitecturePageOneFirst.EscapeCharacter):
                        Specialize.SetEscapeCharacter(reflect_CHARACTER, isEmptyNotCheck);
                        break;

                    case nameof(ArchitecturePageOneFirst.NativeString):
                        Specialize.SetNativeString(reflect_STRING, isEmptyNotCheck);
                        break;

                    case nameof(ArchitecturePageOneFirst.InputDirectory):
                        Specialize.SetInputDirectory(reflect_STRING, isEmptyNotCheck);
                        break;

                    case nameof(ArchitecturePageOneFirst.OutputDirectory):
                        Specialize.SetOutputDirectory(reflect_STRING, isEmptyNotCheck);
                        break;

                    case nameof(ArchitecturePageTwoSecond.Extension):
                        ArchitecturePageTwoSecond.Extension = reflect_STRING;
                        break;

                    default:
                        break;
                }

                continue;
            }

            return;
		}
	}
}