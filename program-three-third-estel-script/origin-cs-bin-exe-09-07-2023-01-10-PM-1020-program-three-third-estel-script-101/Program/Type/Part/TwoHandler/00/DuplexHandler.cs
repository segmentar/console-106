using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void DuplexHandler(String[] split)
        {
            var boolean_safe__EQUAL_OR_MORE_THAN = (split.Length >= 2);

            Boolean shouldReturn;

            shouldReturn = boolean_safe__EQUAL_OR_MORE_THAN is false;

            if (boolean_safe__EQUAL_OR_MORE_THAN is false)
            {
                return;
            }
            else
                "false".ToString();

            var first = split[0];

            var second = split[1];

            String name, value;

            name = first;

            value = second;

            switch (name)
            {
                case nameof(ArchitectureOneFirst.PathProgramOneFirst):
                    ArchitectureOneFirst.PathProgramOneFirst = value;
                    break;

                case nameof(ArchitectureOneFirst.PathProgramTwoSecond):
                    ArchitectureOneFirst.PathProgramTwoSecond = value;
                    break;

                case nameof(ArchitectureOneFirst.InputPathProgramOneFirst):
                    ArchitectureOneFirst.InputPathProgramOneFirst = value;
                    break;

                case nameof(ArchitectureOneFirst.InputPathProgramTwoSecond):
                    ArchitectureOneFirst.InputPathProgramTwoSecond = value;
                    break;

                case nameof(ArchitectureOneFirst.OutputPathProgramOneFirst):
                    ArchitectureOneFirst.OutputPathProgramOneFirst = value;
                    break;

                case nameof(ArchitectureOneFirst.OutputPathProgramTwoSecond):
                    ArchitectureOneFirst.OutputPathProgramTwoSecond = value;
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
