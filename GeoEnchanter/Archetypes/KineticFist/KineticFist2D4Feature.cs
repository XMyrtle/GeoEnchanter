
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace GeoEnchanter.KineticFist
{
    public class KineticFist2D4Feature
    {
        private static readonly string FeatureName = "KineticFist2D4Feature";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(FeatureName, Guids.KineticFist2D4Feature);
            Feature.AddEmptyHandWeaponOverride(isMonkUnarmedStrike: true, isPermanent: true, weapon: Guids.KineticFist2D4Weapon);
            Feature.SetHideInUI(true);
            Feature.SetDisplayName("KineticFist_Name");
            Feature.SetDescription("KineticFist_Desc");
            Feature.SetIcon(Icons.GeoKineticistIconRef.KineticFist);
            Feature.Configure();
        }
    }

}