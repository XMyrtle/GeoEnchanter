
using BlueprintCore.Blueprints.References;
using Kingmaker.RuleSystem;
using BlueprintCore.Blueprints.Configurators.Items.Weapons;
using GeoEnchanter.Util;
using Kingmaker.Enums;

namespace Weapons
{

    public class KineticFist2D4Weapon
    {
        private static readonly string WeaponName = "KineticFist2D4Weapon";
        public static void Configure()
        {
            ItemWeaponConfigurator.New(WeaponName, Guids.KineticFist2D4Weapon)
            .CopyFrom(ItemWeaponRefs.Unarmed1d6)
            .SetSpendCharges(true)
            .SetCharges(1)
            .SetCasterLevel(1)
            .SetSpellLevel(1)
            .SetDC(1)
            .SetType(WeaponTypeRefs.Unarmed.ToString())
            .SetSize(Size.Medium)
            .SetOverrideDamageDice(true)
            .SetDamageDice(new DiceFormula
            {
                m_Rolls = 2,
                m_Dice = DiceType.D4
            })
            .SetOverrideDamageType(false)
            .SetEnchantments(Guids.KineticFistEnchantment)
            .SetIcon(Icons.GeoKineticistIconRef.KineticFist)
            .Configure();

        }
    }
}