
using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.Mechanics;

namespace Archetypes.GeoEnchanter.GeoOverflow;

class GeoOverflowLevel00EffectBuff
{
    private static readonly string BuffName = "GeoOverflowLevel00EffectBuff";
    public static void Configure()
    {
        var Buff = BuffConfigurator.New(name: BuffName, guid: Guids.GeoOverflowLevel00EffectBuff);


        Buff.AddFactContextActions(activated: ActionsBuilder.New()
                                            .RemoveBuff(buff: Guids.GeoOverflowLevel06EffectBuff, removeRank: false, toCaster: false)
                                            .RemoveBuff(buff: Guids.GeoOverflowLevel11EffectBuff, removeRank: false, toCaster: false)
                                            .RemoveBuff(buff: Guids.GeoOverflowLevel16EffectBuff, removeRank: false, toCaster: false));

        Buff.AddToFlags(flags: [BlueprintBuff.Flags.HiddenInUi,
                                BlueprintBuff.Flags.StayOnDeath,
                                BlueprintBuff.Flags.RemoveOnRest]);

        Buff.SetIsClassFeature(true);
        Buff.SetStacking(StackingType.Replace);
        Buff.SetTickEachSecond(false);
        Buff.SetFrequency(DurationRate.Rounds);
        Buff.Configure();

    }

}