using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.AVEx;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Abilities;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Assets;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;
using Kingmaker.ResourceLinks;
using Kingmaker.RuleSystem;
using Kingmaker.RuleSystem.Rules.Damage;
using Kingmaker.UnitLogic.Abilities;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Abilities.Components.Base;
using Kingmaker.UnitLogic.Class.Kineticist;
using Kingmaker.UnitLogic.Mechanics;
using Kingmaker.UnitLogic.Mechanics.Components;
using Kingmaker.UnitLogic.Mechanics.Properties;

namespace GeoEnchanter.WrackBlood
{
    class WrackBloodMetalAbility
    {
        private static readonly string AbilityName = "WrackBloodMetalAbility";
        public static void Configure()
        {
            var WrackMetalAbility = GetAbility(name: AbilityName, guid: Guids.WrackBloodMetalAbility);
            var MetalBlastBase = AbilityConfigurator.For(AbilityRefs.MetalBlastBase);
            MetalBlastBase.RemoveComponents(c =>
            {
                if (c is AbilityVariants PreReq)
                    return true;
                return false;
            });
            MetalBlastBase.AddComponent(new AbilityVariants
            {
                name = "$AbilityVariants$30020fdd-0bc3-406f-8db5-a14406ad3ac8",
                m_Flags = 0,
                m_Variants = [  BlueprintTool.GetRef<BlueprintAbilityReference>("665cfd3718c4f284d80538d85a2791c9"),//MetalBlastAbility
                                BlueprintTool.GetRef<BlueprintAbilityReference>("44804ca6ba7d495439cc9d5ad6d6cfcf"),//DeadlyEarthMetalBlastAbility
                                BlueprintTool.GetRef<BlueprintAbilityReference>("d88c351a3425ee64f80e2fb836a8acf7"),//ExtendedRangeMetalBlastAbility
                                BlueprintTool.GetRef<BlueprintAbilityReference>("3cf0a759bc612264fb9b03aa2f90b24b"),//FragmentationMetalBlastAbility
                                BlueprintTool.GetRef<BlueprintAbilityReference>("ff829a11544db914d89761c676397ef8"),//SpindleMetalBlastAbility
                                BlueprintTool.GetRef<BlueprintAbilityReference>("6551795d81a0e744ebc5785c1264b788"),//WallMetalBlastAbility
                                BlueprintTool.GetRef<BlueprintAbilityReference>("9cef404da5745314b88f49c1ee9fbab1"),//MetalBlastBladeDamage
                                BlueprintTool.GetRef<BlueprintAbilityReference>("7707d4b8ed864757bf019dc86286df7b"),//ExplodingArrowsMetalBlastAbility
                                BlueprintTool.GetRef<BlueprintAbilityReference>(Guids.WrackBloodMetalAbility)]
            });

            WrackMetalAbility.Configure();
            MetalBlastBase.Configure();

        }

        private static AbilityKineticist.DamageInfo DamageInfo()
        {
            return new AbilityKineticist.DamageInfo()
            {
                Value = new ContextDiceValue
                {
                    DiceType = DiceType.D6,
                    DiceCountValue = new ContextValue
                    {
                        ValueType = ContextValueType.Rank,
                        Value = 0,
                        ValueRank = AbilityRankType.DamageDice,
                        ValueShared = AbilitySharedValue.Damage,
                        Property = UnitProperty.None,
                        m_CustomProperty = null,
                        m_AbilityParameter = AbilityParameterType.Level,
                        PropertyName = ContextPropertyName.Value1
                    },
                    BonusValue = new ContextValue
                    {
                        ValueType = ContextValueType.Shared,
                        Value = 0,
                        ValueRank = AbilityRankType.Default,
                        ValueShared = AbilitySharedValue.Damage,
                        Property = UnitProperty.None,
                        m_CustomProperty = null,
                        m_AbilityParameter = AbilityParameterType.Level,
                        PropertyName = ContextPropertyName.Value1
                    }
                },
                Type = new DamageTypeDescription
                {
                    Type = DamageType.Direct,
                    Common = new DamageTypeDescription.CommomData
                    {
                        Reality = 0,
                        Alignment = 0,
                        Precision = false
                    },
                    Physical = new DamageTypeDescription.PhysicalData
                    {
                        Material = 0,
                        Form = Kingmaker.Enums.Damage.PhysicalDamageForm.Bludgeoning,
                        Enhancement = 0,
                        EnhancementTotal = 0
                    }
                },
                Half = true,
                UseWeaponDamageModifiers = false
            };
        }
        private static AbilityConfigurator GetAbility(string name, string guid)
        {
            return AbilityConfigurator.New(name: name, guid: guid)
                                    .AddAbilityKineticist(amount: 1,
                                         cachedDamageInfo: [DamageInfo(), DamageInfo()])
            .AddContextRankConfig(ContextRankConfigs.FeatureRank(feature: FeatureRefs.KineticBlastFeature.ToString(),
                                                      type: AbilityRankType.DamageDice,
                                                      max: 20,
                                                      min: 0))
            .AddAbilityShowIfCasterHasFact(unitFact: Guids.WrackBloodMetalFeature)
            .AddContextRankConfig(ContextRankConfigs.CustomProperty(property: UnitPropertyRefs.KineticistMainStatProperty.ToString(),
                                                                            type: AbilityRankType.DamageBonus,
                                                                            max: 20,
                                                                            min: 0))
            .AddContextCalculateSharedValue(modifier: 1,
                                                   value: ContextDice.Value(diceType: DiceType.One,
                                                                            diceCount: new ContextValue
                                                                            {
                                                                                ValueType = ContextValueType.Rank,
                                                                                Value = 0,
                                                                                ValueRank = AbilityRankType.DamageDice,
                                                                                ValueShared = AbilitySharedValue.Damage,
                                                                                Property = UnitProperty.None,
                                                                                m_CustomProperty = null,
                                                                                m_AbilityParameter = AbilityParameterType.Level,
                                                                                PropertyName = ContextPropertyName.Value1
                                                                            },
                                                                            bonus: new ContextValue
                                                                            {
                                                                                ValueType = ContextValueType.Rank,
                                                                                Value = 0,
                                                                                ValueRank = AbilityRankType.DamageBonus,
                                                                                ValueShared = AbilitySharedValue.Damage,
                                                                                Property = UnitProperty.None,
                                                                                m_CustomProperty = null,
                                                                                m_AbilityParameter = AbilityParameterType.Level,
                                                                                PropertyName = ContextPropertyName.Value1
                                                                            }),
                                                   valueType: AbilitySharedValue.Damage)
            .AddAbilitySpawnFx(prefabLink: "f05669a0767b0274a9921c300c7b6568",
                                      time: AbilitySpawnFxTime.OnPrecastStart,
                                      anchor: AbilitySpawnFxAnchor.Caster,
                                      orientationMode: AbilitySpawnFxOrientation.Copy)
            .AddAbilitySpawnFx(prefabLink: "5ea38033000de784d94808ca9e3ff655",
                                      time: AbilitySpawnFxTime.OnStart,
                                      anchor: AbilitySpawnFxAnchor.Caster,
                                      orientationMode: AbilitySpawnFxOrientation.Copy)
            .AddContextCalculateAbilityParamsBasedOnClass(characterClass: CharacterClassRefs.KineticistClass.ToString(),
                                                                 statType: StatType.Wisdom,
                                                                 useKineticistMainStat: true)
            .AddSpellDescriptorComponent(descriptor: new SpellDescriptorWrapper { m_IntValue = 2199023255552 })
            .AddAbilityEffectRunAction(actions: ActionsBuilder.New()
                                                      .SpawnFx("0ca25545193a70b4ab0b757c4c9318e7")
                                                      .SavingThrow(type: SavingThrowType.Fortitude,
                                                                   onResult: ActionsBuilder.New()
                                                                            .ConditionalSaved(succeed: ActionsBuilder.New()
                                                                                                      .DealDamage(halfIfSaved: true,
                                                                                                                    damageType: new DamageTypeDescription
                                                                                                                    {
                                                                                                                        Type = DamageType.Direct,
                                                                                                                        Common = new DamageTypeDescription.CommomData { Reality = 0, Alignment = 0, Precision = false },
                                                                                                                        Physical = new DamageTypeDescription.PhysicalData { Material = 0, Form = Kingmaker.Enums.Damage.PhysicalDamageForm.Bludgeoning, Enhancement = 0, EnhancementTotal = 0 },
                                                                                                                        Energy = Kingmaker.Enums.Damage.DamageEnergyType.Fire
                                                                                                                    },
                                                                                                                    value: ContextDice.Value(diceType: DiceType.D6,
                                                                                                                                             diceCount: new ContextValue
                                                                                                                                             {
                                                                                                                                                 ValueType = ContextValueType.Rank,
                                                                                                                                                 Value = 0,
                                                                                                                                                 ValueRank = AbilityRankType.DamageDice,
                                                                                                                                                 ValueShared = AbilitySharedValue.Damage,
                                                                                                                                                 Property = UnitProperty.None,
                                                                                                                                                 m_CustomProperty = null,
                                                                                                                                                 m_AbilityParameter = AbilityParameterType.Level,
                                                                                                                                                 PropertyName = ContextPropertyName.Value1

                                                                                                                                             }, bonus: new ContextValue
                                                                                                                                             {
                                                                                                                                                 ValueType = ContextValueType.Shared,
                                                                                                                                                 Value = 0,
                                                                                                                                                 ValueRank = AbilityRankType.Default,
                                                                                                                                                 ValueShared = AbilitySharedValue.Damage,
                                                                                                                                                 Property = UnitProperty.None,
                                                                                                                                                 m_CustomProperty = null,
                                                                                                                                                 m_AbilityParameter = AbilityParameterType.Level,
                                                                                                                                                 PropertyName = ContextPropertyName.Value1

                                                                                                                                             }
                                                                                                                                        ),
                                                                                                                    half: true,
                                                                                                                    resultSharedValue: AbilitySharedValue.Damage,
                                                                                                                    criticalSharedValue: AbilitySharedValue.Damage),
                                                                                                    failed: ActionsBuilder.New()
                                                                                                      .DealDamage(halfIfSaved: false,
                                                                                                                    damageType: new DamageTypeDescription
                                                                                                                    {
                                                                                                                        Type = DamageType.Direct,
                                                                                                                        Common = new DamageTypeDescription.CommomData { Reality = 0, Alignment = 0, Precision = false },
                                                                                                                        Physical = new DamageTypeDescription.PhysicalData { Material = 0, Form = Kingmaker.Enums.Damage.PhysicalDamageForm.Bludgeoning, Enhancement = 0, EnhancementTotal = 0 },
                                                                                                                        Energy = Kingmaker.Enums.Damage.DamageEnergyType.Fire
                                                                                                                    },
                                                                                                                    value: ContextDice.Value(diceType: DiceType.D6,
                                                                                                                                   diceCount: new ContextValue
                                                                                                                                   {
                                                                                                                                       ValueType = ContextValueType.Rank,
                                                                                                                                       Value = 0,
                                                                                                                                       ValueRank = AbilityRankType.DamageDice,
                                                                                                                                       ValueShared = AbilitySharedValue.Damage,
                                                                                                                                       Property = UnitProperty.None,
                                                                                                                                       m_CustomProperty = null,
                                                                                                                                       m_AbilityParameter = AbilityParameterType.Level,
                                                                                                                                       PropertyName = ContextPropertyName.Value1

                                                                                                                                   }, bonus: new ContextValue
                                                                                                                                   {
                                                                                                                                       ValueType = ContextValueType.Shared,
                                                                                                                                       Value = 0,
                                                                                                                                       ValueRank = AbilityRankType.Default,
                                                                                                                                       ValueShared = AbilitySharedValue.Damage,
                                                                                                                                       Property = UnitProperty.None,
                                                                                                                                       m_CustomProperty = null,
                                                                                                                                       m_AbilityParameter = AbilityParameterType.Level,
                                                                                                                                       PropertyName = ContextPropertyName.Value1

                                                                                                                                   }),
                                                                                                                    half: true,
                                                                                                                    resultSharedValue: AbilitySharedValue.Damage,
                                                                                                                    criticalSharedValue: AbilitySharedValue.Damage))))
            .SetDisplayName("MetalWrack_Name")
            .SetDescription("MetalWrack_Desc")
            .SetIcon(Icons.GeoKineticistIconRef.MetalWrack)
            .SetType(AbilityType.Special)
            .SetRange(AbilityRange.Medium)
            .SetCanTargetPoint(false)
            .SetCanTargetEnemies(true)
            .SetCanTargetFriends(false)
            .SetCanTargetSelf(false)
            .SetShouldTurnToTarget(true)
            .SetEffectOnAlly(AbilityEffectOnUnit.None)
            .SetEffectOnEnemy(AbilityEffectOnUnit.Harmful)
            .SetAvailableMetamagic(Metamagic.Empower,
                                   Metamagic.Maximize,
                                   Metamagic.Quicken,
                                   Metamagic.Heighten)
            .SetParent(AbilityRefs.MetalBlastBase.ToString())
            .SetResourceAssetIds([ "705bc7676de67a4449986d9c69876486",
                                          "e05061bbc743af545b923c88662c9e65",
                                          "50829fe2ce054984693b038e9754ca63",
                                          "d5783b16259745d43b3a7fae2bba5ff7",
                                          "d5783b16259745d43b3a7fae2bba5ff7",
                                          "4868d391e387f2742b1ffa2f59602abe"]);
        }
    }

}