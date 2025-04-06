using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.Enums;

namespace Archetypes.GeoEnchanter
{
    class GeoEnchanterProficiencies
    {
        private static readonly string FeatureName = "GeoEnchanterProficiencies";
        public static void cofigure()
        {
            FeatureConfigurator.New(name: FeatureName, guid: Guids.GeoEnchanterProficiencies)
            .AddFacts([ FeatureRefs.SimpleWeaponProficiency.ToString(),
                        FeatureRefs.RayCalculateFeature.ToString()])
            .AddProficiencies(weaponProficiencies: [WeaponCategory.KineticBlast])
            .SetDisplayName("GeoEnchanterProficiencies_Name")
            .SetDescription("GeoEnchanterProficiencies_Desc")
            .SetIsClassFeature(true)
            .Configure();
        }

    }

}