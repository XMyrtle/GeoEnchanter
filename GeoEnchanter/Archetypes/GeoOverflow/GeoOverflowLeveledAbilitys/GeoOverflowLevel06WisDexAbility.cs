using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;

namespace Ability.Overflow
{
    class GeoOverflowLevel06WisDexAbility
    {
        private static readonly string AbilityName = "GeoOverflowLevel06WisDexAbility";
        public static void Configure()
        {
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel06WisDexAbility);
            Ability.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisDex);
            Ability.SetDisplayName("GeoOverflow06_Name");
            Ability.SetDescription("GeoOverflow06WisDex_Desc");
            Ability.SetGroup(ActivatableAbilityGroup.ElementalOverflow);
            Ability.SetBuff(buff: Guids.GeoOverflowLevel06WisDexBuff);
            Ability.SetDeactivateImmediately(true);
            Ability.SetActivationType(AbilityActivationType.WithUnitCommand);
            Ability.SetActivateWithUnitCommand(Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free);
            Ability.Configure();
        }

    }

}