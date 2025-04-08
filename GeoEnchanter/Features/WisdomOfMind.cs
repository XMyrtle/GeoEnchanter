using System.Reflection;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.RuleSystem.Rules;

namespace Features
{
    class WisdomOfMind
    {
        private static readonly string FeatureName = "WisdomOfMind";
        public static void Configure()
        {
            // ModifierDescriptorHelper.DefaultStackingDescriptors.Add(ModifierDescriptor.Inherent);

            FeatureConfigurator.New(name: FeatureName, guid: Guids.WisdomOfMind)
            .AddRecalculateOnStatChange(stat: StatType.Intelligence)
            .AddRecalculateOnStatChange(stat: StatType.Wisdom)
            .AddRecalculateOnStatChange(stat: StatType.Charisma)
            .AddContextRankConfig(component: ContextRankConfigs.StatBonus(StatType.Wisdom)
                                            .WithHalfMoreProgression())
            .AddContextStatBonus(stat: StatType.Intelligence,
                                 value: ContextValues.Rank(),
                                 descriptor: ModifierDescriptor.Competence)

            .AddContextStatBonus(stat: StatType.Charisma,
                                 value: ContextValues.Rank(),
                                 descriptor: ModifierDescriptor.Competence)
            .SetDisplayName("WisdomOfMind_Name")
            .SetDescription("WisdomOfMind_Desc")
            .SetHideInUI(false)
            .Configure();
        }

    }

}
