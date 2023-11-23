using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopearch
    {
        public static void Sentence()
        {
            try
            {
                Boolean shouldReturnCheck;

                shouldReturnCheck = MaterialqueryValue.Data.Runtime.QueryType.Equals(MaterialqueryCode.QueryType.Sentence) is false;

                if (shouldReturnCheck is true)
                {
                    return;
                }
                else
                    "false".ToString();

                foreach (Materialchain materialchain in Template.Data.MeasureValidate.MaterialchainArrayList)
                {
                    Boolean isReferenceCheck, shouldContinueContiniousCheck;

                    isReferenceCheck = Object.ReferenceEquals(materialchain, MaterialchainValue) is true;

                    shouldContinueContiniousCheck = isReferenceCheck is true;

                    if (shouldContinueContiniousCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    Boolean isEqualCheck;

                    isEqualCheck = materialchain.Materialinfo.Name.Equals(MaterialqueryValue.Data.IdentityName) is true;

                    shouldContinueContiniousCheck = isEqualCheck is false;

                    if (shouldContinueContiniousCheck is true)
                    {
                        continue;
                    }
                    else
                        "false".ToString();

                    var list = new ArrayList(MaterialqueryIsolateArray);

                    var index = list.IndexOf(MaterialqueryValue);

                    list.RemoveAt(index);

                    list.InsertRange(index, materialchain.MaterialqueryIsolateArray);

                    var array = list.ToArray(typeof(Materialquery));

                    var reflect = (Materialquery[])(array as Array);

                    MaterialqueryIsolateArray = reflect;

                    LinkedList = new LinkedList<Materialquery>(MaterialqueryIsolateArray);

                    LinkedListPointer = LinkedListPointer - 1;

                    continue;
                }

                Template.Data.MeasureValidate.ValidateMaterialquery[MaterialqueryValue] = true;

                if (ShouldLog is true)
                {
                    ConsoleLJS.Log(false, $"found sentence [{MaterialqueryValue.Data.IdentityName.StringValue}]");
                }
                else
                    "false".ToString();

            } catch (Exception exception)
            {
                ScopearchFatal.Action(new ScopearchFatalSentence().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
