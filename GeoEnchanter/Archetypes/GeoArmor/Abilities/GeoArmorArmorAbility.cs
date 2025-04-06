using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Abilities;
using GeoEnchanter.Util;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.Visual.Animation.Kingmaker.Actions;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorArmorAbility
    {
        private static readonly string AbilityName = "GeoArmorArmorAbility";
        public static void Configure()
        {
            var Ability = AbilityConfigurator.New(name: AbilityName, guid: Guids.GeoArmorArmorAbility);
            Ability.AddAbilityResourceLogic(requiredResource: Guids.GeoArmorResource,
                                            amount: 1,
                                            costIsCustom: false,
                                            isSpendResource: true,
                                            resourceCostDecreasingFacts: null,
                                            resourceCostIncreasingFacts: null);
            Ability.AddAbilityEffectRunAction(actions: ActionsBuilder.New()
                                                     .ApplyBuffPermanent(buff: Guids.GeoArmorArmorBuff,
                                                                         asChild: true,
                                                                         isFromSpell: false,
                                                                         isNotDispelable: false,
                                                                         sameDuration: false,
                                                                         toCaster: false)
                                                    .AcceptBurn(value: 1));
            Ability.SetDisplayName("GeoArmorArmor_Name");
            Ability.SetDescription("GeoArmor_Desc");
            Ability.SetIcon(Icons.GeoKineticistIconRef.GeoArmorArmor);
            Ability.SetType(AbilityType.Supernatural);
            Ability.SetRange(AbilityRange.Personal);
            Ability.SetCustomRange(0);
            Ability.SetCanTargetSelf(true);

            // Ability.SetAnimation(UnitAnimationActionCastSpell.CastAnimationStyle.Self);
            // Ability.SetHasFastAnimation(true);

            Ability.Configure();

        }

    }
}