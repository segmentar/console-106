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

			ConsoleLJS.Bundle(true);

			return;
		}

		internal static void Procedure()
		{
			ProgramPolicy.ProgramDebugPolicy = true;

			ProgramPolicy.ProgramInfoPolicy = true;

			return;
		}

		internal static void Manual()
		{
			ProgramModule programModule = ProgramModule.ProgramModuleAction(true, true, true);

			return;
		}

		internal static void Raise()
		{
			if (ProgramPolicy.ProgramInfoPolicy is true)
			{
				ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(Program)}Info", ProgramPolicy.ProgramArrayList.ToArray());
			}
			else
				"false".ToString();

			return;
		}

		internal static void Bundle()
		{
#if DEBUG
			Procedure();
#endif
			Manual();
#if DEBUG
			Raise();
#endif
			return;
		}

		static Program()
		{
			return;
		}
	}
}