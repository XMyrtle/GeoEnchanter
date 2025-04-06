using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;

namespace Ability.Overflow
{
    class GeoOverflowLevel11WisConAbility
    {
        private static readonly string AbilityName = "GeoOverflowLevel11WisConAbility";
        public static void Configure()
        {
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel11WisConAbility);
            Ability.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon);
            Ability.SetDisplayName("GeoOverflow11_Name");
            Ability.SetDescription("GeoOverflow11WisDex_Desc");
            Ability.SetGroup(ActivatableAbilityGroup.ElementalOverflow);
            Ability.SetBuff(buff: Guids.GeoOverflowLevel11WisConBuff);
            Ability.Configure();
        }

    }

}