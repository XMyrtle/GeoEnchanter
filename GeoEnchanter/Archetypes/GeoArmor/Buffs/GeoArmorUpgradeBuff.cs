using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorUpgradeBuff
    {
        private static readonly string BuffName = "GeoArmorUpgradeBuff";
        public static void Configure()
        {
            var Buff = BuffConfigurator.New(name: BuffName, guid: Guids.GeoArmorUpgradeBuff);

            Buff.AddFacts([Guids.GeoArmorUpgradeFeature]);
            Buff.SetIcon(Icons.GeoKineticistIconRef.GeoArmor);
            Buff.SetDisplayName("GeoArmor_Name");
            Buff.SetDescription("GeoArmor_Desc");
            Buff.SetIsClassFeature(true);
            Buff.SetFlags([BlueprintBuff.Flags.HiddenInUi,
                           BlueprintBuff.Flags.StayOnDeath,
                           BlueprintBuff.Flags.RemoveOnRest]);
            Buff.SetStacking(StackingType.Stack);
            // Buff.SetRanks(0);
            Buff.Configure();
        }
    }

}