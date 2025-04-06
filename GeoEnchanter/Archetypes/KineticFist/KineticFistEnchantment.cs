using BlueprintCore.Blueprints.Configurators.Items.Ecnchantments;
using GeoEnchanter.Util;
using Kingmaker.EntitySystem.Stats;

namespace GeoEnchanter.KineticFist
{
    class KineticFistEnchantment
    {
        private static readonly string EnchantmentName = "KineticFistEnchament";
        public static void Configure()
        {
            var Enchantment = WeaponEnchantmentConfigurator.New(EnchantmentName, Guids.KineticFistEnchantment);
            Enchantment.AddWeaponDamageStatReplacement(stat: StatType.Wisdom);
            Enchantment.Configure();
        }
    }

}