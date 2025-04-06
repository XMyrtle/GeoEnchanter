using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;


namespace Features
{
    class WisdomOfMind
    {
        private static readonly string FeatureName = "WisdomOfMind";
        public static void Configure()
        {
            FeatureConfigurator.New(name: FeatureName, guid: Guids.WisdomOfMind)
            .AddRecalculateOnStatChange(stat: StatType.Intelligence)
            .AddRecalculateOnStatChange(stat: StatType.Wisdom)
            .AddRecalculateOnStatChange(stat: StatType.Charisma)
            .AddContextRankConfig(component: ContextRankConfigs.StatBonus(StatType.Wisdom)
                                            .WithHalfMoreProgression())
            .AddContextStatBonus(stat: StatType.Intelligence,
                                 value: ContextValues.Rank(),
                                 descriptor: ModifierDescriptor.Inherent)
            .AddContextStatBonus(stat: StatType.Charisma,
                                 value: ContextValues.Rank(),
                                 descriptor: ModifierDescriptor.Inherent)
            .SetDisplayName("WisdomOfMind_Name")
            .SetDescription("WisdomOfMind_Desc")
            .SetHideInUI(false)
            .Configure();
        }


    }
}
