using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;
using Kingmaker.UnitLogic.Commands.Base;

namespace GeoEnchanter.MetalGutWrenching
{
    class MetalGutWrenchingInfusionAbility

    {
        private static readonly string AbilityName = "MetalGutWrenchingInfusionAbility";
        public static void Configure()
        {
            ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.MetalGutWrenchingInfusionAbility)
            .SetDisplayName("MetalGutWrenching_Name")
            .SetDescription("MetalGutWrenching_Desc")
            .SetIcon(Icons.GeoKineticistIconRef.MetalGutWrenching)
            .SetBuff(Guids.MetalGutWrenchingInfusionBuff)
            .SetGroup(ActivatableAbilityGroup.SubstanceInfusion)
            .SetDeactivateImmediately(true)
            .SetDoNotTurnOffOnRest(true)
            .SetActivateWithUnitCommand(UnitCommand.CommandType.Free)
            .SetActivateOnUnitAction(AbilityActivateOnUnitActionType.Attack)
            .Configure();
        }

    }

}