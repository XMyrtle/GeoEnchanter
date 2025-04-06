using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorArmorBuff
    {
        private static readonly string BuffName = "GeoArmorArmorBuff";
        public static void Configure()
        {
            var Buff = BuffConfigurator.New(name: BuffName, guid: Guids.GeoArmorArmorBuff);

            Buff.AddFacts(facts: [Guids.GeoArmorArmorEffectFeature]);
            Buff.SetDisplayName("GeoArmorArmor_Name");
            Buff.SetDescription("GeoArmor_Desc");
            Buff.SetIcon(Icons.GeoKineticistIconRef.GeoArmorArmor);
            Buff.SetIsClassFeature(true);
            Buff.AddToFlags([BlueprintBuff.Flags.StayOnDeath]);
            Buff.SetStacking(StackingType.Replace);
            Buff.Configure();

        }


    }

}