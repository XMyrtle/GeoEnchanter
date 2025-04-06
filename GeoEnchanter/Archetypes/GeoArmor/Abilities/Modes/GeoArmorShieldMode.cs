using BlueprintCore.Blueprints.Configurators.UnitLogic.ActivatableAbilities;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.ActivatableAbilities;
using Kingmaker.UnitLogic.Commands.Base;


namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorShieldMode
    {
        private static readonly string AbilityName = "GeoArmorShieldMode";
        public static void Configure()
        {
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoArmorShieldMode);
            Ability.SetBuff(Guids.GeoArmorShieldBuff);
            Ability.SetGroup(ActivatableAbilityGroup.ShroudOfWaterMode);

            Ability.SetDoNotTurnOffOnRest(true);
            Ability.SetDeactivateImmediately(true);
            Ability.SetIsOnByDefault(true);
            Ability.SetActivationType(AbilityActivationType.WithUnitCommand);
            Ability.SetActivateWithUnitCommand(UnitCommand.CommandType.Standard);


            Ability.SetIcon(icon: Icons.GeoKineticistIconRef.GeoArmorShield);
            Ability.SetDisplayName("GeoArmorArmor_Name");
            Ability.SetDescription("GeoArmor_Desc");
            Ability.Configure();
        }

    }

}