using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;

namespace Buffs
{
    class GeoBurnBuff
    {
        private static readonly string BuffName = "GeoBurnBuff";
        public static void Configure()
        {
            var RankConfig = ContextRankConfigs.CustomProperty(property: UnitPropertyRefs.BurnNumberProperty.ToString(),
                                                                type: Kingmaker.Enums.AbilityRankType.Default);
            var Buff = BuffConfigurator.New(BuffName, Guids.GeoBurnBuff);


            Buff.AddContextRankConfig(RankConfig);
            Buff.AddContextStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.SaveWill,
                                     value: ContextValues.Rank(),
                                     descriptor: Kingmaker.Enums.ModifierDescriptor.UntypedStackable,
                                     multiplier: -1,
                                     minimal: -20);

            Buff.AddContextStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.SkillLoreNature,
                                     value: ContextValues.Rank(),
                                     descriptor: Kingmaker.Enums.ModifierDescriptor.UntypedStackable,
                                     multiplier: -1,
                                     minimal: -20);

            Buff.AddContextStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.SkillLoreReligion,
                                     value: ContextValues.Rank(),
                                     descriptor: Kingmaker.Enums.ModifierDescriptor.UntypedStackable,
                                     multiplier: -1,
                                     minimal: -20);

            Buff.AddContextStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.SkillPerception,
                                     value: ContextValues.Rank(),
                                     descriptor: Kingmaker.Enums.ModifierDescriptor.UntypedStackable,
                                     multiplier: -1,
                                     minimal: -20);

            Buff.AddToFlags(flags: [ Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.HiddenInUi,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.StayOnDeath,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.RemoveOnRest]);
            Buff.SetStacking(Kingmaker.UnitLogic.Buffs.Blueprints.StackingType.Replace);
            Buff.SetIsClassFeature(true);
            Buff.Configure();
        }

    }

}