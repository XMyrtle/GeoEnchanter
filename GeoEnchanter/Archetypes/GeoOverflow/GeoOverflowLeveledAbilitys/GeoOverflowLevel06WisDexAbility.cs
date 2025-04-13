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
            ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel06WisDexAbility)
            .SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisDex)
            .SetDisplayName("GeoOverflow06_Name")
            .SetDescription("GeoOverflow06WisDex_Desc")
            .SetGroup(ActivatableAbilityGroup.ElementalOverflow)
            .SetBuff(buff: Guids.GeoOverflowLevel06WisDexBuff)
            .SetDeactivateImmediately(true)
            .SetActivationType(AbilityActivationType.WithUnitCommand)
            .SetActivateWithUnitCommand(Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free)
            .Configure();
        }

    }

}