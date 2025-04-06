using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace GeoEnchanter.MetalGutWrenching
{
    class MetalGutWrenchingInfusionFeature

    {
        private static readonly string FeatureName = "MetalGutWrenchingInfusionFeature";
        public static void Configure()
        {
            FeatureConfigurator.New(name: FeatureName, guid: Guids.MetalGutWrenchingFeature)
            .AddFacts([Guids.MetalGutWrenchingInfusionAbility])
            .SetDisplayName("MetalGutWrenching_Name")
            .SetDescription("MetalGutWrenching_Desc")
            .SetIcon(Icons.GeoKineticistIconRef.MetalGutWrenching)
            .Configure();
        }

    }

}