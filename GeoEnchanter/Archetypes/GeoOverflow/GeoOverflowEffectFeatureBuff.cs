using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Conditions.Builder;
using BlueprintCore.Conditions.Builder.ContextEx;
using BlueprintCore.Utils;
using BlueprintCore.Utils.Assets;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;
using Kingmaker.Enums;
using Kingmaker.UnitLogic.Abilities;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.Mechanics;
using Kingmaker.UnitLogic.Mechanics.Components;
using Kingmaker.UnitLogic.Mechanics.Properties;
using UniRx;


namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowEffectFeatureBuff
    {
        private static readonly string BuffName = "GeoOverflowEffectFeatureBuff";
        public static void Configure()
        {
            var Buff = BuffConfigurator.New(BuffName, Guids.GeoOverflowEffectFeatureBuff);

            var ClassRank = ContextRankConfigs.ClassLevel(classes: [CharacterClassRefs.KineticistClass.ToString()],
                                                                    type: AbilityRankType.Default,
                                                                    min: 0,
                                                                    max: 20);
            ClassRank.m_BaseValueType = ContextRankBaseValueType.ClassLevel;
            ClassRank.m_Progression = ContextRankProgression.AsIs;

            var FortificationValue = ContextValues.Rank();
            FortificationValue.ValueType = ContextValueType.Rank;
            FortificationValue.Value = 0;
            FortificationValue.ValueRank = AbilityRankType.StatBonus;
            FortificationValue.ValueShared = AbilitySharedValue.Damage;
            FortificationValue.Property = UnitProperty.None;

            var BurnRank = ContextRankConfigs.CustomProperty(property: UnitPropertyRefs.BurnNumberProperty.ToString(),
                                                             type: AbilityRankType.StatBonus,
                                                             min: 0,
                                                             max: 20);
            BurnRank.m_UseMax = false;
            BurnRank.m_UseMin = false;
            BurnRank.m_StartLevel = 0;
            BurnRank.m_StepLevel = 5;
            BurnRank.m_BaseValueType = ContextRankBaseValueType.CustomProperty;
            BurnRank.m_Progression = ContextRankProgression.MultiplyByModifier;

            var ActivatedActions = ActionsBuilder.New();

            ActivatedActions.ChangeSharedValueTo(setValue: SetDamageValue(),
                                                 sharedValue: AbilitySharedValue.Damage);
            ActivatedActions.ChangeSharedValueTo(setValue: SetHealValue(),
                                                 sharedValue: AbilitySharedValue.Heal);

            ActivatedActions.Conditional(conditions: ConditionsBuilder.New()
                                                    .SharedValueHigher(higherOrEqual: 7,
                                                                       inverted: false,
                                                                       negate: false,
                                                                       sharedValue: AbilitySharedValue.Damage)
                                                    .SharedValueHigher(higherOrEqual: 16,
                                                                       inverted: false,
                                                                       negate: false,
                                                                       sharedValue: AbilitySharedValue.Heal)
                                                    .HasFact(fact: Guids.GeoOverflowLevel16EffectBuff,
                                                            negate: true),
                                        ifTrue: ActionsBuilder.New()
                                              .ApplyBuffPermanent(buff: Guids.GeoOverflowLevel16EffectBuff),

                                        ifFalse: ActionsBuilder.New()
                                                .Conditional(conditions: ConditionsBuilder.New()
                                                                        .SharedValueHigher(higherOrEqual: 5,
                                                                                           inverted: false,
                                                                                           negate: false,
                                                                                           sharedValue: AbilitySharedValue.Damage)
                                                                        .SharedValueHigher(higherOrEqual: 11,
                                                                                           inverted: false,
                                                                                           negate: false,
                                                                                           sharedValue: AbilitySharedValue.Heal)
                                                                        .HasFact(fact: Guids.GeoOverflowLevel11EffectBuff,
                                                                                 negate: true)
                                                                        .HasFact(fact: Guids.GeoOverflowLevel16EffectBuff,
                                                                                 negate: true),
                                                             ifTrue: ActionsBuilder.New()
                                                                    .ApplyBuffPermanent(buff: Guids.GeoOverflowLevel11EffectBuff),
                                                             ifFalse: ActionsBuilder.New()
                                                                     .Conditional(conditions: ConditionsBuilder.New()
                                                                                            .SharedValueHigher(higherOrEqual: 3,
                                                                                                               inverted: false,
                                                                                                               negate: false,
                                                                                                               sharedValue: AbilitySharedValue.Damage)
                                                                                            .HasFact(fact: Guids.GeoOverflowLevel06EffectBuff,
                                                                                                     negate: true)
                                                                                            .HasFact(fact: Guids.GeoOverflowLevel11EffectBuff,
                                                                                                     negate: true)
                                                                                            .HasFact(fact: Guids.GeoOverflowLevel16EffectBuff,
                                                                                                     negate: true),
                                                                                    ifTrue: ActionsBuilder.New()
                                                                                           .ApplyBuffPermanent(buff: Guids.GeoOverflowLevel06EffectBuff),
                                                                                    ifFalse: ActionsBuilder.New()
                                                                                            .Conditional(conditions: ConditionsBuilder.New()
                                                                                                                    .SharedValueHigher(higherOrEqual: 2,
                                                                                                                                        inverted: false,
                                                                                                                                        negate: true,
                                                                                                                                        sharedValue: AbilitySharedValue.Damage),
                                                                                                        ifTrue: ActionsBuilder.New()
                                                                                                              .ApplyBuffPermanent(buff: Guids.GeoOverflowLevel00EffectBuff)))));


            Buff.AddFactContextActions(activated: ActivatedActions,
                                       deactivated: null,
                                       newRound: null,
                                       dispose: ActivatedActions);


            Buff.AddContextRankConfig(ClassRank);
            Buff.AddFortification(useContextValue: true,
                                   value: FortificationValue);
            Buff.AddContextRankConfig(BurnRank);



            Buff.SetIsClassFeature(true);

            Buff.AddToFlags(flags: [BlueprintBuff.Flags.HiddenInUi,
                                    BlueprintBuff.Flags.RemoveOnRest,
                                    BlueprintBuff.Flags.StayOnDeath]);
            Buff.SetStacking(StackingType.Replace);
            // Buff.SetRanks(1);
            Buff.SetTickEachSecond(false);
            Buff.SetFrequency(DurationRate.Rounds);
            Buff.SetAllowNonContextActions(false);
            // Buff.SetFxOnStart(null);
            // Buff.SetFxOnRemove(null);
            Buff.Configure();
        }

        private static ContextValue SetDamageValue()
        {
            var ContextValue = ContextValues.CustomProperty(UnitPropertyRefs.BurnNumberProperty.ToString());
            ContextValue.ValueType = ContextValueType.CasterCustomProperty;
            ContextValue.Value = 0;
            ContextValue.ValueRank = AbilityRankType.Default;
            ContextValue.ValueShared = AbilitySharedValue.Damage;
            ContextValue.Property = UnitProperty.None;

            return ContextValue;
        }
        private static ContextValue SetHealValue()
        {
            var ContextValue = ContextValues.CustomProperty(UnitPropertyRefs.BurnNumberProperty.ToString());
            ContextValue.ValueType = ContextValueType.Rank;
            ContextValue.Value = 0;
            ContextValue.ValueRank = AbilityRankType.Default;
            ContextValue.ValueShared = AbilitySharedValue.Damage;
            ContextValue.Property = UnitProperty.None;
            return ContextValue;
        }
    }
}