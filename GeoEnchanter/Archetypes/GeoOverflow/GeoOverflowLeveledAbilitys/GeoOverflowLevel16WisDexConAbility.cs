using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;

namespace Ability.Overflow
{
    class GeoOverflowLevel16WisDexConAbility
    {
        private static readonly string AbilityName = "GeoOverflowLevel16WisDexConAbility";
        public static void Configure()
        {
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel16WisDexConAbility);
            Ability.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisDex);
            Ability.SetDisplayName("GeoOverflow16_Name");
            Ability.SetDescription("GeoOverflow16WisDexCon_Desc");
            Ability.SetGroup(ActivatableAbilityGroup.ElementalOverflow);
            Ability.SetBuff(buff: Guids.GeoOverflowLevel16WisDexConBuff);
            Ability.Configure();
        }

    }

}