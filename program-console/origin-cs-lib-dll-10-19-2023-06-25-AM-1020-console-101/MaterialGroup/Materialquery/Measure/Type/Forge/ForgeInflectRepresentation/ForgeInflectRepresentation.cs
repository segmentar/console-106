using Core;

namespace Core
{
    using System;

    public partial struct MaterialqueryMeasure
    {
        public String ForgeInflectRepresentation(Int32 Inflect_INTEGER)
        {
            String stringResult = default;

            Boolean shouldDisplayCheck;

            shouldDisplayCheck = (Inflect_INTEGER == 0) is true;

            var Parent_VALUE = String.Empty;

            var ChildArray__ARRAY = new String[ChildArray.Length];

            if (shouldDisplayCheck is true)
            {
                var zee = (Inflect_INTEGER + 1);

                Boolean hasParentCheck;

                hasParentCheck = (Parent == default) is false;

                if (hasParentCheck is true)
                {
                    Parent_VALUE = Parent.ToString(zee);
                }
                else
                    "false".ToString();

                var indexer = 0;

                foreach (Materialquery Materialquery_VALUE in ChildArray)
                {
                    ChildArray__ARRAY[indexer] = Materialquery_VALUE.ToString(zee);

                    indexer = indexer + 1;

                    continue;
                }
            }
            else
                "false".ToString();

            var descriptor = new String[] {

                String.Empty + nameof(Materialquery) + ' ' + "::" + ' ' + nameof(MaterialqueryMeasure) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Parent) + ':' + ' ' + ". . ." + ' ' + $"<{Parent == default}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ChildArray) + ':' + ' ' + ". . ." + ' ' + $"<{ChildArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Parent) + ':',
                String.Empty + Parent_VALUE,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ChildArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ChildArray__ARRAY)
            };

            var Entity_LINE_FEED = Convert.ToChar(10);

            var join = String.Join(Entity_LINE_FEED.ToString(), descriptor);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
