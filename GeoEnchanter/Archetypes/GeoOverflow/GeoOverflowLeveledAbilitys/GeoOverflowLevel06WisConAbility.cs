using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;

namespace Ability.Overflow
{
    class GeoOverflowLevel06WisConAbility
    {
        private static readonly string AbilityName = "GeoOverflowLevel06WisConAbility";
        public static void Configure()
        {
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel06WisConAbility);
            Ability.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon);
            Ability.SetDisplayName("GeoOverflow06_Name");
            Ability.SetDescription("GeoOverflow06WisCon_Desc");
            Ability.SetGroup(ActivatableAbilityGroup.ElementalOverflow);
            Ability.SetBuff(buff: Guids.GeoOverflowLevel06WisConBuff);
            Ability.SetDeactivateImmediately(true);
            Ability.SetActivationType(AbilityActivationType.WithUnitCommand);
            Ability.SetActivateWithUnitCommand(Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free);
            Ability.Configure();
        }

    }

}