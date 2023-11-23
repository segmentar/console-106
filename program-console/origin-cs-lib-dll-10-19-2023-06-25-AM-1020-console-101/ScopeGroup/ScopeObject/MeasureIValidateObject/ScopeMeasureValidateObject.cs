using Core;

namespace Core
{
    using System;

    public partial struct ScopeMeasureValidate
    {
        [ScopeIntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(Scope) + ' ' + "::" + ' ' + nameof(ScopeMeasureValidate) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(MaterialchainArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{MaterialchainArrayList.Count}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ValidateMaterialchain) + ':' + ' ' + ". . ." + ' ' + $"<{ValidateMaterialchain.Count}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ValidateMaterialquery) + ':' + ' ' + ". . ." + ' ' + $"<{ValidateMaterialquery.Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(MaterialchainArrayList) + ':',
                String.Empty + String.Join('\n'.ToString(), MaterialchainArrayList.ToArray()),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ValidateMaterialchain) + ':',
                String.Empty + String.Join('\n'.ToString(), ValidateMaterialchain),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ValidateMaterialquery) + ':',
                String.Empty + String.Join('\n'.ToString(), ValidateMaterialquery)
            });
        }
    }
}
