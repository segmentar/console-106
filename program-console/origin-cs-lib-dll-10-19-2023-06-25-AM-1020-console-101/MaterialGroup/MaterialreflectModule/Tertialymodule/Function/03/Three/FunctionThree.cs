using Core;

namespace Core
{
    using System;

    public partial struct MaterialreflectTertiarymodule
    {
        public static MaterialreflectTertiarymodule FunctionThree(MaterialreflectTertiarymodule module)
        {
            var sort = Materialquery.FunctionSortrankSetSurface(module.Second.Function.MaterialqueryArray);

            var indexer = 0;

            foreach (Materialquery materialquery in sort)
            {
                sort[indexer] = new Materialquery(materialquery.Data);

                indexer = indexer + 1;

                continue;
            }

            var isolate = Materialquery.FunctionIsolatelayerSetSurface(sort, 1);

            Materialinfo materialinfo;

            materialinfo = Materialinfo.MakeMaterialinfoDefaultSurface(module.Materialreflect.Material.HeaderSubstring, module.Materialreflect.Material.FooterSubstring, module.Materialreflect.EscapeCharacterArray);

            Materialchain materialchain;

            materialchain = new Materialchain(materialinfo, sort, isolate);

            var function = new FunctionThirty(materialchain);

            FunctionThird third;

            third = new FunctionThird(function);

            module.Third = third;

            return module;
        }
    }
}
