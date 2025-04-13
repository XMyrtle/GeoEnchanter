using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;

namespace Ability.Overflow
{
    class GeoOverflowLevel16WisConDexAbility
    {
        private static readonly string AbilityName = "GeoOverflowLevel16WisConDexAbility";
        public static void Configure()
        {
            ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel16WisConDexAbility)
            .SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon)
            .SetDisplayName("GeoOverflow16_Name")
            .SetDescription("GeoOverflow16WisConDex_Desc")
            .SetGroup(ActivatableAbilityGroup.ElementalOverflow)
            .SetBuff(buff: Guids.GeoOverflowLevel16WisConDexBuff)
            .SetDeactivateImmediately(true)
            .SetActivationType(AbilityActivationType.WithUnitCommand)
            .SetActivateWithUnitCommand(Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free)
            .Configure();
        }

    }

}