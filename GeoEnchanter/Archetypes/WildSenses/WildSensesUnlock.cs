

using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace GeoEnchanter.WildSenses
{
    public class WildSensesUnlock
    {
        private static readonly string FeatureName = "WildSensesUnlock";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(FeatureName, Guids.WhildSensesUnlock);
            Feature.SetDisplayName("WildSenses_Name");
            Feature.SetDescription("WildSenses_Desc");

            Feature.AddMonkNoArmorFeatureUnlock(Guids.WhildSensesFeature);
            Feature.SetHideInUI(false);
            Feature.SetIcon(icon: Icons.GeoKineticistIconRef.WildWhisper);
            Feature.Configure();
        }
    }

}

