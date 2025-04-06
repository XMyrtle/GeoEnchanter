using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel11WisDexBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel11WisDexBuff";

        public static void Configure()
        {
            var DescriptorType = Kingmaker.Enums.ModifierDescriptor.Polymorph;
            var Buff = BuffConfigurator.New(name: BuffName, Guids.GeoOverflowLevel11WisDexBuff);

            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Wisdom,
                                  descriptor: DescriptorType,
                                  value: 4);
            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Dexterity,
                              descriptor: DescriptorType,
                              value: 2);
            Buff.AddPolymorphBonuses();
            Buff.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisDex);
            Buff.SetDisplayName("GeoOverflow11_Name");
            Buff.SetDescription("GeoOverflow11WisDex_Desc");
            Buff.AddToFlags(flags: [/*BlueprintBuff.Flags.HiddenInUi,*/
                                    BlueprintBuff.Flags.StayOnDeath]);
            Buff.Configure();
        }

    }

}