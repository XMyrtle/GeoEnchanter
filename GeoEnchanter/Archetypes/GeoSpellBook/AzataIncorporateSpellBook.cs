using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.Configurators.Classes.Spells;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Spells;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;

namespace Azata

{
    class AzataIncorporateSpellBook
    {
        private static readonly string FeatureName = "AzataIncorporateSpellBook";
        public static void Configure()
        {
            FeatureSelectMythicSpellbookConfigurator.New(name: FeatureName, guid: Guids.AzataIncorporateSpellBook)
            .SetDisplayName("AzataIncorporate_Name")
            .SetDescription("AzataIncorporate_Desc")
            .SetRanks(1)
            .SetIsClassFeature(true)
            .SetAllowedSpellbooks([Guids.GeoEnchanterSpellBook,
                                   "df2830dc44844428962a8fad63ac3777",
                                   "ded25cd4-f77e-4b4e-8576-eb02b868b98c"])
            .SetMythicSpellList(SpellListRefs.AzataMythicSpelllist.ToString())
            .SetSpellKnownForSpontaneous(SpellsTableRefs.MythicSpontaneousSpellsKnownTable.ToString())
            .Configure();

            ProgressionConfigurator.For(ProgressionRefs.AzataProgression)
            .AddToLevelEntry(level: 1, [Guids.AzataIncorporateSpellBook])
            .Configure();

            SpellListConfigurator.For(SpellListRefs.AzataMythicSpelllist)
            .SetIsMythic(true)
            .Configure();




        }

    }

}