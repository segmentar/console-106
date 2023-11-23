using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ArgumentArray;

        internal static void Main(params String[] array_ARGUMENT)
        {
            ArgumentArray = array_ARGUMENT;

            Bundle();

            return;          
        }

        internal static void Procedure()
        {
            Policy.ProgramDebugPolicy = true;

            Policy.ProgramInfoPolicy = true;

            return;
        }

        internal static void Manual()
        {
            ProgramModule programModule = ProgramModule.ProgramModuleDefault();

            if (Policy.ProgramInfoPolicy is true)
            {
                foreach (Program program in Policy.ProgramArrayList)
                {
                    Console.Clear();

                    Console.Out.WriteLine(program);

                    Console.ReadKey(true);

                    continue;
                }
            }
            return;
        }

        internal static void Bundle()
        {
            Procedure();

            Manual();

            return;
        }

        static Program()
        {
            return;
        }
    }
}
