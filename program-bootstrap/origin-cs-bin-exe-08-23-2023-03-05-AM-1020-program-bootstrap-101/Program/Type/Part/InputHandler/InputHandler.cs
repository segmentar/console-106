using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static void InputHandler(String[] array_SPLIT, String item_LOWER, Int32 item_LENGTH, Boolean answer_LENGTH_has)
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = answer_LENGTH_has.Equals(false) is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var oth = array_SPLIT[0];

            var lower = oth.ToLower();

            foreach (Tuple<String, String> tuple in ProgramInputNameValueContainer__NAME_VALUE(array_SPLIT))
            {
                String name, value;

                name = tuple.Item1;

                value = tuple.Item2;

                ProgramBindNameValueVoid(name, value);

                continue;
            }

            Boolean isClassificationCheck, isModulationCheck, isIconCheck;

            isClassificationCheck = (lower.Equals("ac") || lower.Equals("add-classification")) is true;

            isModulationCheck = (lower.Equals("am") || lower.Equals("add-modulation")) is true;

            isIconCheck = (lower.Equals("ai") || lower.Equals("add-icon")) is true;

            if (isClassificationCheck is true)
            {
                var first = array_SPLIT[0];

                var second = array_SPLIT[1];

                var third = array_SPLIT[2];

                var fourth = array_SPLIT[3];

                String classificationCall, classificationName, classificationNamespace, classificationStatic;

                classificationCall = first;

                classificationName = second;

                classificationNamespace = third;

                classificationStatic = fourth;

                Specialize.ValueAddClassification(classificationName, classificationNamespace, classificationStatic);
            }
            else
                "false".ToString();

            if (isModulationCheck is true)
            {
                var first = array_SPLIT[0];

                var second = array_SPLIT[1];

                var third = array_SPLIT[2];

                var fourth = array_SPLIT[3];

                String modulationCall, modulationName, modulationNamespace, modulationCount;

                modulationCall = first;

                modulationName = second;

                modulationNamespace = third;

                modulationCount = fourth;

                Specialize.ValueAddModulation(modulationName, modulationNamespace, modulationCount);
            }
            else
                "false".ToString();

            if (isIconCheck is true)
            {
                var first = array_SPLIT[0];

                var second = array_SPLIT[1];

                var third = array_SPLIT[2];

                var fourth = array_SPLIT[3];

                var fifth = array_SPLIT[4];

                var sixth = array_SPLIT[5];

                var seventh = array_SPLIT[6];

                var eighth = array_SPLIT[7];

                String iconCall, iconName, iconSeed, iconCount, iconBackColor, iconForeColor, iconBackRatio, iconForeRatio;

                iconCall = first;

                iconName = second;

                iconSeed = third;

                iconCount = fourth;

                iconBackColor = fifth;

                iconForeColor = sixth;

                iconBackRatio = seventh;

                iconForeRatio = eighth;

                Specialize.ValueAddIcon(iconName, iconSeed, iconCount, iconBackColor, iconForeColor, iconBackRatio, iconForeRatio);
            }
            else
                "false".ToString();

            return;
        }
    }
}
