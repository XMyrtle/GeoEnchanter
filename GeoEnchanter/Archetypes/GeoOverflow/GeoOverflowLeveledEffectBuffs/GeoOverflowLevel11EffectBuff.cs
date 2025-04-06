using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel11EffectBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel11EffectBuff";
        public static void Configure()
        {
            var Buff = BuffConfigurator.New(name: BuffName, guid: Guids.GeoOverflowLevel11EffectBuff);

            Buff.AddFacts(facts: [Guids.GeoOverflowLevel11WisConAbility,
                                  Guids.GeoOverflowLevel11WisDexAbility]);

            Buff.AddToFlags(flags: [Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.HiddenInUi,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.StayOnDeath,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.RemoveOnRest]);

            Buff.AddFactContextActions(activated: ActionsBuilder.New()
                                                 .RemoveBuff(buff: Guids.GeoOverflowLevel06EffectBuff, removeRank: false, toCaster: false));

            Buff.SetIsClassFeature(true);
            Buff.SetStacking(Kingmaker.UnitLogic.Buffs.Blueprints.StackingType.Replace);
            Buff.SetTickEachSecond(false);
            Buff.SetFrequency(Kingmaker.UnitLogic.Mechanics.DurationRate.Rounds);

            Buff.Configure();
        }

    }

}