using Core;

namespace Core
{
    using System;

    public partial class Contribute
    {
        public void TabulationA(String[] array_SPLIT)
        {
            var second = array_SPLIT[1];

            var third = array_SPLIT[2];

            var fourth = array_SPLIT[3];

            var fifth = array_SPLIT[4];

            var sixth = array_SPLIT[5];

            var Entity_DASH = Convert.ToChar(45);

            var position = third.IndexOf(Entity_DASH);

            var aoth = third.Length;

            var start = (position + Entity_DASH.ToString().Length);

            var difference = (aoth - start);

            var sub = third.Substring(start, difference);

            var parse = Int32.Parse(sub);

            String stringIndexer, stringIndexerSafe;

            stringIndexer = second;

            stringIndexerSafe = ConsoleLJS.SafeString(stringIndexer);

            ContributeStringSafe contributeStringSafeIndexer;

            contributeStringSafeIndexer = new ContributeStringSafe();

            contributeStringSafeIndexer.StringValue = stringIndexer;

            contributeStringSafeIndexer.StringValueSafe = stringIndexerSafe;

            String stringType, stringTypeSafe;

            stringType = fourth;

            stringTypeSafe = ConsoleLJS.SafeString(stringType);

            var Entity_COLON = Convert.ToChar(58);

            var format = fifth.Trim(Entity_COLON);

            String stringName, stringNameSafe;

            stringName = format;

            stringNameSafe = ConsoleLJS.SafeString(stringName);

            String stringValue, stringValueSafe;

            stringValue = sixth;

            stringValueSafe = ConsoleLJS.SafeString(stringValue);

            ContributeStringSafe contributeStringSafeType, contributeStringSafeName, contributeStringSafeValue;

            contributeStringSafeType = new ContributeStringSafe();

            contributeStringSafeType.StringValue = stringType;

            contributeStringSafeType.StringValueSafe = stringTypeSafe;

            contributeStringSafeName = new ContributeStringSafe();

            contributeStringSafeName.StringValue = stringName;

            contributeStringSafeName.StringValueSafe = stringNameSafe;

            contributeStringSafeValue = new ContributeStringSafe();

            contributeStringSafeValue.StringValue = stringValue;

            contributeStringSafeValue.StringValueSafe = stringValueSafe;

            Indexer = contributeStringSafeIndexer;

            Ordinal = parse;

            Type = contributeStringSafeType;

            Name = contributeStringSafeName;

            Value = contributeStringSafeValue;

            return;
        }
    }
}
