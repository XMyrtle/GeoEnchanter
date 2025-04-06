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
            var Ability = ActivatableAbilityConfigurator.New(name: AbilityName, guid: Guids.GeoOverflowLevel16WisConDexAbility);
            Ability.SetIcon(Icons.GeoKineticistIconRef.GeoOverflowWisCon);
            Ability.SetDisplayName("GeoOverflow16_Name");
            Ability.SetDescription("GeoOverflow16WisConDex_Desc");
            Ability.SetGroup(ActivatableAbilityGroup.ElementalOverflow);
            Ability.SetBuff(buff: Guids.GeoOverflowLevel16WisConDexBuff);
            Ability.Configure();
        }

    }

}