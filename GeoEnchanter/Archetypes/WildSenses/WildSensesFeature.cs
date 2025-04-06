
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace GeoEnchanter.WildSenses
{
    public class WildSenses
    {
        private static readonly string FeatureName = "WhildSenses";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(FeatureName, Guids.WhildSensesFeature);
            Feature.SetDisplayName("WildSenses_Name");
            Feature.SetDescription("WildSenses_Desc");
            Feature.SetHideInUI(true);
            Feature.AddFacts(facts: [Guids.WhildSensesBuff]);
            Feature.SetIcon(icon: Icons.GeoKineticistIconRef.WildWhisper);
            Feature.Configure();
        }
    }
}