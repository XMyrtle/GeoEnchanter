using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace GeoEnchanter.MetalGutWrenching
{
    class MetalGutWrenchingFeature

    {
        private static readonly string FeatureName = "MetalGutWrenchingFeature";
        public static void Configure()
        {
            FeatureConfigurator.New(name: FeatureName, guid: Guids.MetalGutWrenchingFeature)
            .AddFacts([Guids.MetalGutWrenchingInfusionFeature])
            .SetDisplayName("MetalGutWrenching_Name")
            .SetDescription("MetalGutWrenching_Desc")
            .SetIcon(Icons.GeoKineticistIconRef.MetalGutWrenching)
            .Configure();
        }

    }

}