using BlueprintCore.Blueprints.CustomConfigurators;
using GeoEnchanter.Util;

namespace AbilityResources
{
    public class GeoBurnResource
    {
        private static readonly string ResourceName = "GeoBurnResource";
        public static void Configure()
        {
            var MaxAmount = ResourceAmountBuilder.New(2);
            var AbilityResource = AbilityResourceConfigurator.New(ResourceName, Guids.GeoBurnResource);

            AbilityResource.SetMin(0);
            AbilityResource.SetMax(20);
            MaxAmount.IncreaseByStat(Kingmaker.EntitySystem.Stats.StatType.Wisdom);
            AbilityResource.SetMaxAmount(MaxAmount);

            AbilityResource.Configure();
        }

    }

}