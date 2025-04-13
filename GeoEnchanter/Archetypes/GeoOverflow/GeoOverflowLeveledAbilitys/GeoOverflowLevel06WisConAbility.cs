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
            ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel06WisConAbility)
            .SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon)
            .SetDisplayName("GeoOverflow06_Name")
            .SetDescription("GeoOverflow06WisCon_Desc")
            .SetGroup(ActivatableAbilityGroup.ElementalOverflow)
            .SetBuff(buff: Guids.GeoOverflowLevel06WisConBuff)
            .SetDeactivateImmediately(true)
            .SetActivationType(AbilityActivationType.WithUnitCommand)
            .SetActivateWithUnitCommand(Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free)
            .Configure();
        }

    }

}