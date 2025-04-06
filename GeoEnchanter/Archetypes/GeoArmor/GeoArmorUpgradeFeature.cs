using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace Archetypes.GeoEnchanter.GeoArmor
{
    class GeoArmorUpgradeFeature
    {
        private static readonly string FeatureName = "GeoArmorUpgradeFeature";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(name: FeatureName, guid: Guids.GeoArmorUpgradeFeature);

            Feature.SetDisplayName("GeoArmor_Name");
            Feature.SetDescription("GeoArmor_Desc");
            Feature.SetIcon(Icons.GeoKineticistIconRef.GeoArmor);
            Feature.SetHideInUI(true);

            Feature.SetHideInCharacterSheetAndLevelUp(false);
            Feature.SetHideNotAvailibleInUI(false);
            Feature.SetRanks(20);
            Feature.SetReapplyOnLevelUp(false);
            Feature.SetIsClassFeature(true);

            Feature.Configure();
        }


    }

}