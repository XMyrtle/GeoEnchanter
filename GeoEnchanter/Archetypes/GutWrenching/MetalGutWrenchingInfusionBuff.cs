using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;
using Kingmaker.UnitLogic.Commands.Base;

namespace GeoEnchanter.MetalGutWrenching
{
    class MetalGutWrenchingInfusionBuff

    {
        private static readonly string BuffName = "MetalGutWrenchingInfusionBuff";
        public static void Configure()
        {
            ActivatableAbilityConfigurator.New(name: BuffName, guid: Guids.MetalGutWrenchingInfusionBuff)
            .SetDisplayName("MetalGutWrenching_Name")
            .SetDescription("MetalGutWrenching_Desc")
            .SetIcon(Icons.GeoKineticistIconRef.MetalGutWrenching)

            .Configure();
        }

    }

}