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
            ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel11WisConAbility)
            .SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon)
            .SetDisplayName("GeoOverflow11_Name")
            .SetDescription("GeoOverflow11WisCon_Desc")
            .SetGroup(ActivatableAbilityGroup.ElementalOverflow)
            .SetBuff(buff: Guids.GeoOverflowLevel11WisConBuff)
            .SetDeactivateImmediately(true)
            .SetActivationType(AbilityActivationType.WithUnitCommand)
            .SetActivateWithUnitCommand(Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free)
            .Configure();
        }

    }

}