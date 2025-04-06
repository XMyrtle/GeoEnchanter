using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace GeoEnchanter.WrackBlood
{
    class WrackBloodMetalFeature
    {
        private static readonly string FeatureName = "WrackBloodMetalFeature";
        public static void Configure()
        {
            FeatureConfigurator.New(name: FeatureName, guid: Guids.WrackBloodMetalFeature)
            .SetDisplayName("MetalWrack_Name")
            .SetDescription("MetalWrack_Desc")
            .SetIcon(Icons.GeoKineticistIconRef.MetalWrack)
            .Configure();
        }
    }

}