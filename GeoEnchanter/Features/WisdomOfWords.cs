using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;
using Kingmaker.Blueprints.Classes;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.UnitLogic.Buffs;
using Kingmaker.UnitLogic.FactLogic;

namespace Features
{
    class WisdomOfWords
    {
        private static readonly string FeatureName = "WisdomOfWords";
        public static void Configure()
        {
            FeatureConfigurator.New(name: FeatureName, guid: Guids.WisdomOfWords)
            .AddReplaceStatBaseAttribute(baseAttributeReplacement: StatType.Wisdom,
                                         replaceIfHigher: false,
                                         replaceMod: BonusMod.AsIs,
                                         targetStat: StatType.SkillPersuasion)
            .AddReplaceStatBaseAttribute(baseAttributeReplacement: StatType.Wisdom,
                                         replaceIfHigher: false,
                                         replaceMod: BonusMod.AsIs,
                                         targetStat: StatType.SkillUseMagicDevice)
            .SetDisplayName("WisdomOfWords_Name")
            .SetDescription("WisdomOfWords_Desc")
            .SetHideInUI(false)
            .Configure();
        }


    }
}
