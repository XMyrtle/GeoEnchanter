using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;
using Kingmaker.UnitLogic.Commands.Base;


namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorArmorMode
    {
        private static readonly string AbilityName = "GeoArmorArmorMode";
        public static void Configure()
        {
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoArmorArmorMode);

            Ability.SetBuff(Guids.GeoArmorArmorBuff);
            Ability.SetGroup(ActivatableAbilityGroup.ShroudOfWaterMode);

            Ability.SetDoNotTurnOffOnRest(true);
            Ability.SetDeactivateImmediately(true);
            Ability.SetActivationType(AbilityActivationType.WithUnitCommand);
            Ability.SetActivateWithUnitCommand(UnitCommand.CommandType.Standard);


            Ability.SetIcon(icon: Icons.GeoKineticistIconRef.GeoArmorArmor);
            Ability.SetDisplayName("GeoArmorArmor_Name");
            Ability.SetDescription("GeoArmor_Desc");
            Ability.Configure();
        }

    }

}