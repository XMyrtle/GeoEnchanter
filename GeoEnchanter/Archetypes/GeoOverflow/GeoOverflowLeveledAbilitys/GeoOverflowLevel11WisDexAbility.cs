using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;

namespace Ability.Overflow
{
    class GeoOverflowLevel11WisDexAbility
    {
        private static readonly string AbilityName = "GeoOverflowLevel11WisDexAbility";
        public static void Configure()
        {
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel11WisDexAbility);
            Ability.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisDex);
            Ability.SetDisplayName("GeoOverflow11_Name");
            Ability.SetDescription("GeoOverflow11WisDex_Desc");
            Ability.SetGroup(ActivatableAbilityGroup.ElementalOverflow);
            Ability.SetBuff(buff: Guids.GeoOverflowLevel11WisDexBuff);
            Ability.Configure();
        }

    }

}