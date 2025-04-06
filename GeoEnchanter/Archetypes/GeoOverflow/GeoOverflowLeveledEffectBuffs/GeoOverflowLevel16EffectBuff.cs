using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel16EffectBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel16EffectBuff";
        public static void Configure()
        {
            var Buff = BuffConfigurator.New(name: BuffName, guid: Guids.GeoOverflowLevel16EffectBuff);

            Buff.AddFacts(facts: [Guids.GeoOverflowLevel16WisConDexAbility,
                                  Guids.GeoOverflowLevel16WisDexConAbility]);

            Buff.AddToFlags(flags: [Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.HiddenInUi,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.StayOnDeath,
                                    Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.RemoveOnRest]);

            Buff.AddFactContextActions(activated: ActionsBuilder.New()
                                                 .RemoveBuff(buff: Guids.GeoOverflowLevel06EffectBuff, removeRank: false, toCaster: false)
                                                 .RemoveBuff(buff: Guids.GeoOverflowLevel11EffectBuff, removeRank: false, toCaster: false));

            Buff.SetIsClassFeature(true);
            Buff.SetStacking(Kingmaker.UnitLogic.Buffs.Blueprints.StackingType.Replace);
            Buff.SetTickEachSecond(false);
            Buff.SetFrequency(Kingmaker.UnitLogic.Mechanics.DurationRate.Rounds);
            Buff.Configure();
        }

    }

}