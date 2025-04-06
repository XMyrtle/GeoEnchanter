using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.RuleSystem;
using Kingmaker.UnitLogic.Abilities;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.UnitLogic.Mechanics;
using Kingmaker.UnitLogic.Mechanics.Components;
using Kingmaker.UnitLogic.Mechanics.Properties;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorShieldEffectFeature
    {
        private static readonly string FeatureName = "GeoArmorShieldEffectFeature";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(name: FeatureName, guid: Guids.GeoArmorShieldEffectFeature);

            Feature.AddContextRankConfig(ClassRank());
            Feature.AddRecalculateOnFactsChange(Guids.GeoArmorUpgradeFeature);
            Feature.AddComponent(Shroud(Guids.GeoArmorUpgradeFeature));
            Feature.AddComponent(ContextCalculateSharedValue());

            Feature.SetDisplayName("GeoArmorShield_Name");
            Feature.SetDescription("GeoArmor_Desc");
            Feature.SetIcon(Icons.GeoKineticistIconRef.GeoArmorShield);
            Feature.SetRanks(1);
            Feature.SetReapplyOnLevelUp(true);
            Feature.SetIsClassFeature(true);

            Feature.Configure();
        }
        private static ContextRankConfig ClassRank()
        {
            var ClassRank = ContextRankConfigs.ClassLevel(classes: [CharacterClassRefs.KineticistClass.ToString()],
                                                          type: AbilityRankType.Default,
                                                          min: 0,
                                                          max: 20);
            ClassRank.m_BaseValueType = ContextRankBaseValueType.ClassLevel;
            ClassRank.m_Progression = ContextRankProgression.DelayedStartPlusDivStep;
            ClassRank.m_StartLevel = 2;
            ClassRank.m_StepLevel = 4;
            return ClassRank;

        }
        private static ShroudOfWater Shroud(string UpgradeFeature)
        {
            var ShroudOfWaterComponent = new ShroudOfWater();
            ShroudOfWaterComponent.name = "$ShroudOfWater$b553c6cee8c64a54bfe80c1a5a6358f0";
            ShroudOfWaterComponent.Descriptor = ModifierDescriptor.Shield;
            ShroudOfWaterComponent.Stat = StatType.AC;
            ShroudOfWaterComponent.BaseValue = new ContextValue
            {
                ValueType = ContextValueType.Shared,
                Value = 0,
                ValueRank = AbilityRankType.Default,
                ValueShared = AbilitySharedValue.Damage,
                Property = UnitProperty.None,
                m_CustomProperty = null
            };
            ShroudOfWaterComponent.m_UpgradeFeature = BlueprintTool.GetRef<BlueprintFeatureReference>(UpgradeFeature);
            return ShroudOfWaterComponent;
        }

        private static ContextCalculateSharedValue ContextCalculateSharedValue()
        {
            var ContextCalculateSharedValue = new ContextCalculateSharedValue
            {
                ValueType = AbilitySharedValue.Damage,
                Value = new ContextDiceValue
                {

                    DiceType = DiceType.One,
                    DiceCountValue = new ContextValue
                    {
                        ValueType = ContextValueType.Rank,
                        Value = 0,
                        ValueRank = AbilityRankType.Default,
                        ValueShared = AbilitySharedValue.Damage,
                        Property = UnitProperty.None,
                        m_CustomProperty = null
                    },
                    BonusValue = new ContextValue
                    {
                        ValueType = ContextValueType.Simple,
                        Value = 1,
                        ValueRank = AbilityRankType.Default,
                        ValueShared = AbilitySharedValue.Damage,
                        Property = UnitProperty.None,
                        m_CustomProperty = null
                    }
                },
                Modifier = 1
            };

            return ContextCalculateSharedValue;
        }
    }


}