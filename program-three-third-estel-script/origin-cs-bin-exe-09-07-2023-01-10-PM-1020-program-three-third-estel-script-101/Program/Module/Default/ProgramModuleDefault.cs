using Core;

namespace Core
{
	using System;

	public partial struct ProgramModule
	{
		public static ProgramModule ProgramModuleDefault()
		{
			Program program;

			program = Program.MakeProgramDefaultSurface();

			program.SetupConsole();

			ProgramModule module;

			module = new ProgramModule();

			module.Program = program;

			module = ProgramModuleFunctionOne(module);

			module = ProgramModuleFunctionTwo(module);

			return module;
		}
	}
}