using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel11WisConBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel11WisConBuff";

        public static void Configure()
        {
            var DescriptorType = Kingmaker.Enums.ModifierDescriptor.Polymorph;
            var Buff = BuffConfigurator.New(name: BuffName, Guids.GeoOverflowLevel11WisConBuff);

            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Wisdom,
                                  descriptor: DescriptorType,
                                  value: 4);
            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Constitution,
                              descriptor: DescriptorType,
                              value: 2);
            Buff.AddPolymorphBonuses();
            Buff.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon);
            Buff.SetDisplayName("GeoOverflow11_Name");
            Buff.SetDescription("GeoOverflow11WisCon_Desc");
            Buff.AddToFlags(flags: [/*BlueprintBuff.Flags.HiddenInUi,*/
                                    BlueprintBuff.Flags.StayOnDeath]);
            Buff.Configure();
        }

    }

}