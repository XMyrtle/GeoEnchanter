using BlueprintCore.Blueprints.CustomConfigurators;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorResource
    {
        static string ResourceName = "GeoArmorResource";
        public static void Configure()
        {
            var Resource = AbilityResourceConfigurator.New(name: ResourceName, guid: Guids.GeoArmorResource);
            Resource.SetLocalizedName("GeoArmor_Name");
            Resource.SetLocalizedDescription("GeoArmor_Desc");
            Resource.SetMaxAmount(ResourceAmountBuilder.New(0)
                                                       .IncreaseByLevelStartPlusDivStep(classes: [CharacterClassRefs.KineticistClass.ToString()],
                                                                                        otherClassLevelsMultiplier: 0,
                                                                                        startingLevel: 2,
                                                                                        startingBonus: 2,
                                                                                        levelsPerStep: 8,
                                                                                        bonusPerStep: 1,
                                                                                        minBonus: 0))
                                                        .SetUseMax(false)
                                                        .SetMax(10)
                                                        .SetMin(0);
            Resource.Configure();
        }
    }
}