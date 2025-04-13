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
            ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel16WisDexConAbility)
            .SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon)
            .SetDisplayName("GeoOverflow16_Name")
            .SetDescription("GeoOverflow16WisDexCon_Desc")
            .SetGroup(ActivatableAbilityGroup.ElementalOverflow)
            .SetBuff(buff: Guids.GeoOverflowLevel16WisDexConBuff)
            .SetDeactivateImmediately(true)
            .SetActivationType(AbilityActivationType.WithUnitCommand)
            .SetActivateWithUnitCommand(Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free)
            .Configure();
        }

    }

}