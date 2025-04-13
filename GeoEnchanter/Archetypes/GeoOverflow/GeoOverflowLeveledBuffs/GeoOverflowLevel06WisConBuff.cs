using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.Mechanics;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel06WisConBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel06WisConBuff";

        public static void Configure()
        {
            const Kingmaker.Enums.ModifierDescriptor DescriptorType = Kingmaker.Enums.ModifierDescriptor.Alchemical;

            BuffConfigurator.New(name: BuffName, Guids.GeoOverflowLevel06WisConBuff)
            .AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Wisdom,
                                  descriptor: DescriptorType,
                                  value: 2)
            .AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Constitution,
                              descriptor: DescriptorType,
                              value: 2)
            .AddPolymorphBonuses()
            .SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon)
            .SetDisplayName("GeoOverflow06_Name")
            .SetDescription("GeoOverflow06WisCon_Desc")
            .SetIsClassFeature(true)
            .AddToFlags(flags: [/*BlueprintBuff.Flags.HiddenInUi,*/
                                BlueprintBuff.Flags.StayOnDeath])
            .SetRanks(0)
            .SetStacking(StackingType.Replace)
            .SetTickEachSecond(false)
            .SetFrequency(DurationRate.Rounds)
            .Configure();
        }

    }

}