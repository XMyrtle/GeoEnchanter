using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Abilities;
using GeoEnchanter.Util;
using Kingmaker.Visual.Animation.Kingmaker.Actions;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorUpgradeAbility
    {
        private static readonly string AbilityName = "GeoArmorUpgradeAbility";
        public static void Configure()
        {
            AbilityConfigurator.New(name: AbilityName, guid: Guids.GeoArmorUpgradeAbility)
            .AddAbilityResourceLogic(requiredResource: Guids.GeoArmorResource,
                                            amount: 1,
                                            costIsCustom: false,
                                            isSpendResource: true,
                                            resourceCostDecreasingFacts: null,
                                            resourceCostIncreasingFacts: null)
            .AddAbilityEffectRunAction(actions: ActionsBuilder.New()
                                              .ApplyBuffPermanent(buff: Guids.GeoArmorUpgradeBuff,
                                                                  asChild: true))
            .AddAbilityAcceptBurnOnCast(1)
            .SetCanTargetEnemies(false)
            .SetCanTargetFriends(false)
            .SetCanTargetPoint(false)
            .SetCanTargetSelf(true)
            .SetAnimation(UnitAnimationActionCastSpell.CastAnimationStyle.SelfTouch)
            .SetDisplayName("GeoArmor_Name")
            .SetDescription("GeoArmor_Desc")
            .SetIcon(Icons.GeoKineticistIconRef.GeoArmor)
            .Configure();
        }

    }

}