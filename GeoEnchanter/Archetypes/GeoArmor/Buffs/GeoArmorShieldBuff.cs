using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorShieldBuff
    {
        private static readonly string BuffName = "GeoArmorShieldBuff";
        public static void Configure()
        {
            var Buff = BuffConfigurator.New(name: BuffName, guid: Guids.GeoArmorShieldBuff);

            Buff.AddFacts(facts: [Guids.GeoArmorShieldEffectFeature]);
            Buff.SetDisplayName("GeoArmorShield_Name");
            Buff.SetDescription("GeoArmor_Desc");
            Buff.SetIcon(Icons.GeoKineticistIconRef.GeoArmorShield);
            Buff.SetIsClassFeature(true);
            Buff.AddToFlags([BlueprintBuff.Flags.StayOnDeath]);
            Buff.SetStacking(StackingType.Replace);
            Buff.Configure();

        }


    }

}