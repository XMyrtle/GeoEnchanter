using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel16WisDexConBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel16WisDexConBuff";

        public static void Configure()
        {
            var DescriptorType = Kingmaker.Enums.ModifierDescriptor.Polymorph;
            var Buff = BuffConfigurator.New(name: BuffName, Guids.GeoOverflowLevel16WisDexConBuff);

            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Wisdom,
                                  descriptor: DescriptorType,
                                  value: 6);
            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Dexterity,
                              descriptor: DescriptorType,
                              value: 4);
            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Constitution,
                              descriptor: DescriptorType,
                              value: 2);

            Buff.AddPolymorphBonuses();
            Buff.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisDex);
            Buff.SetDisplayName("GeoOverflow16_Name");
            Buff.SetDescription("GeoOverflow16WisCon_Desc");
            Buff.AddToFlags(flags: [/*BlueprintBuff.Flags.HiddenInUi,*/
                                    BlueprintBuff.Flags.StayOnDeath]);
            Buff.Configure();
        }

    }

}