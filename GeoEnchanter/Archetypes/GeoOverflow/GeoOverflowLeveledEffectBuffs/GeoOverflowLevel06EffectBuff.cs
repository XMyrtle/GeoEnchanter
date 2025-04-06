using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel06EffectBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel06EffectBuff";
        public static void Configure()
        {
            var Buff = BuffConfigurator.New(name: BuffName, guid: Guids.GeoOverflowLevel06EffectBuff);

            Buff.AddFacts(facts: [Guids.GeoOverflowLevel06WisConAbility,
                                  Guids.GeoOverflowLevel06WisDexAbility]);

            Buff.AddToFlags(flags: [Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.HiddenInUi,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.StayOnDeath,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.RemoveOnRest]);

            Buff.SetIsClassFeature(true);
            Buff.SetStacking(Kingmaker.UnitLogic.Buffs.Blueprints.StackingType.Replace);
            Buff.SetTickEachSecond(false);
            Buff.SetFrequency(Kingmaker.UnitLogic.Mechanics.DurationRate.Rounds);
            Buff.Configure();
        }

    }

}