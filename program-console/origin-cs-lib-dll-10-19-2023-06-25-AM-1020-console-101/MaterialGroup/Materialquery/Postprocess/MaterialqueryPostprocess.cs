using Core;

namespace Core
{
    using System;

    public partial class Materialquery
    {
        public Materialquery(MaterialqueryData data)
        {
            MaterialqueryRuntime runtime;

            Char parentLeft, parentRight;

            parentLeft = data.LeftCharacter.CharacterValue;

            parentRight = data.RightCharacter.CharacterValue;

            Char childLeft, childRight;

            childLeft = '\0';

            childRight = '\0';

            Boolean hasLengthCheck;

            hasLengthCheck = data.Measure.ChildArray.Length.Equals(0) is false;

            if (hasLengthCheck is true)
            {
                childLeft = data.Measure.ChildArray[0].Data.LeftCharacter.CharacterValue;

                childRight = data.Measure.ChildArray[0].Data.RightCharacter.CharacterValue;
            }
            else
                "false".ToString();
            
            runtime = new MaterialqueryRuntime();

            goto IsandhasParent;

            IsandhasParent:
            {
                runtime.ParenthesisRuntimeIsandhas(parentLeft, parentRight, false);

                runtime.SquareRuntimeIsandhas(parentLeft, parentRight, false);

                runtime.ArrowRuntimeIsandhas(parentLeft, parentRight, false);

                runtime.CurlyRuntimeIsandhas(parentLeft, parentRight, false);
            }

            goto IsandhasChild;

            IsandhasChild:
            {
                runtime.ParenthesisRuntimeIsandhas(childLeft, childRight, true);

                runtime.SquareRuntimeIsandhas(childLeft, childRight, true);

                runtime.ArrowRuntimeIsandhas(childLeft, childRight, true);

                runtime.CurlyRuntimeIsandhas(childLeft, childRight, true);
            }

            goto Both;

            Both:
            {
                runtime.RequireRuntimeBoth(hasLengthCheck);

                runtime.OptionRuntimeBoth(hasLengthCheck);

                runtime.AnyRuntimeBoth(hasLengthCheck);

                runtime.SomeRuntimeBoth(hasLengthCheck);

                runtime.SomeRuntimeBoth(hasLengthCheck);

                runtime.AnyRuntimeBoth(hasLengthCheck);

                runtime.SeparateRuntimeBoth(hasLengthCheck);

                runtime.SentenceRuntimeBoth(hasLengthCheck);

                runtime.ParagraphRuntimeBoth(hasLengthCheck);
            }

            runtime.QueryTypeRuntime();

            data.Runtime = runtime;

            this.Data = data;

            return;
        }
    }
}
