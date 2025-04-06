using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.Mechanics;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowLevel06WisDexBuff
    {
        private static readonly string BuffName = "GeoOverflowLevel06WisDexBuff";

        public static void Configure()
        {
            var DescriptorType = Kingmaker.Enums.ModifierDescriptor.Polymorph;
            var Buff = BuffConfigurator.New(name: BuffName, Guids.GeoOverflowLevel06WisDexBuff);

            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Wisdom,
                                  descriptor: DescriptorType,
                                  value: 2);
            Buff.AddStatBonus(stat: Kingmaker.EntitySystem.Stats.StatType.Dexterity,
                              descriptor: DescriptorType,
                              value: 2);
            Buff.AddPolymorphBonuses();
            Buff.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisDex);
            Buff.SetDisplayName("GeoOverflow06_Name");
            Buff.SetDescription("GeoOverflow06WisDex_Desc");
            Buff.SetIsClassFeature(true);
            Buff.AddToFlags(flags: [/*BlueprintBuff.Flags.HiddenInUi,*/
                                    BlueprintBuff.Flags.StayOnDeath]);
            Buff.SetRanks(0);
            Buff.SetStacking(StackingType.Replace);
            Buff.SetTickEachSecond(false);
            Buff.SetFrequency(DurationRate.Rounds);

            Buff.Configure();
        }

    }

}