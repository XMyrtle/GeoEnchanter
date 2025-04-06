
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;

namespace GeoEnchanter.KineticFist
{
    public class KineticFist1D4Feature
    {
        private static readonly string FeatureName = "KineticFist1D4Feature";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(FeatureName, Guids.KineticFist1D4Feature);
            Feature.AddEmptyHandWeaponOverride(isMonkUnarmedStrike: true, isPermanent: true, weapon: Guids.KineticFist1D4Weapon);
            Feature.AddFacts(facts: [FeatureRefs.ImprovedUnarmedStrike.ToString()]);
            Feature.SetHideInUI(false);
            Feature.SetDisplayName("KineticFist_Name");
            Feature.SetDescription("KineticFist_Desc");
            Feature.SetIcon(Icons.GeoKineticistIconRef.KineticFist);
            Feature.Configure();
        }
    }

}