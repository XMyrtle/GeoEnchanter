using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.UnitLogic.Mechanics.Components;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowBonusFeature
    {
        private static readonly string FeatureName = "GeoOverflowBonusFeature";
        public static void Configure()
        {
            FeatureConfigurator.New(name: FeatureName, Guids.GeoOverflowBonusFeature)
            .AddKineticistElementalOverflow(bonus: ContextValues.Rank(),
                                            elementalEngine: false,
                                            firesFury: FeatureRefs.FiresFuryFeature.ToString(),
                                            ignoreBurn: false)
            .AddComponent(ClassRank())
            .AddRecalculateOnStatChange(stat: StatType.DamageNonLethal)
            .SetDisplayName("GeoOverflow_Name")
            .SetDescription("GeoOverflow_Desc")

            .Configure();
        }
        private static ContextRankConfig ClassRank()
        {
            return new ContextRankConfig
            {
                m_Type = AbilityRankType.Default,
                m_BaseValueType = ContextRankBaseValueType.ClassLevel,
                m_Feature = null,
                m_FeatureList = [],
                m_Stat = Kingmaker.EntitySystem.Stats.StatType.Unknown,
                m_SpecificModifier = ModifierDescriptor.None,
                m_Buff = null,
                m_Progression = ContextRankProgression.DivStep,
                m_CustomProgression = [],
                m_StartLevel = 0,
                m_StepLevel = 3,
                m_UseMin = false,
                m_Min = 0,
                m_UseMax = false,
                m_Max = 0,
                m_ExceptClasses = false,
                Archetype = null,
                m_AdditionalArchetypes = [],
                m_Class = [BlueprintTool.GetRef<BlueprintCharacterClassReference>("42a455d9ec1ad924d889272429eb8391")],
                m_CustomProperty = BlueprintTool.GetRef<BlueprintUnitPropertyReference>("02c5943c77717974cb7fa1b7c0dc51f8"),
                m_CustomPropertyList = [],

            };
        }

    }

}