using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ProgramModule
    {
		public static ProgramModule ProgramModuleAction(Boolean interop, Boolean free, Boolean explorer)
		{
			if (interop is true)
			{
				try
				{
                    Interop.Lenf01IL();

                    Interop.Linf02IL();

                    Interop.Extf03IL();

					Interop.Natf04IL();

					Interop.Reff05IL();

					if (ArchitecturePageOneFirst.HasLinger is true)
					{
						Interop.Debf06IL();
					}
					else
						"false".ToString();

                } catch (Exception exception)
				{
					exception.ToString();

					Console.Clear();

					Console.Out.WriteLine(exception);

					Console.In.ReadLine();
				}
			}
			else
				"false".ToString();

			if (free is true)
			{
                Program.Free();
            }
			else
				"false".ToString();

            ProgramModule module;

            module = ProgramModuleDefault();

			if (explorer is true)
			{
                Program.Explorer(Directory.GetCurrentDirectory(), 1);
            }
			else
				"false".ToString();

            return module;
		}
	}
}