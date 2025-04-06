using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using GeoEnchanter.Util;

namespace Archetypes.GeoEnchanter.GeoOverflow
{
    class GeoOverflowEffectFeature
    {
        private static readonly string FeatureName = "GeoOverflowEffectFeature";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(FeatureName, Guids.GeoOverflowEffectFeature);

            Feature.AddKineticistBurnValueChangedTrigger(action: ActionsBuilder.New().ApplyBuffPermanent(buff: Guids.GeoOverflowEffectFeatureBuff, asChild: true));
            Feature.AddFacts([Guids.GeoOverflowEffectFeatureBuff]);
            Feature.SetHideInUI(true);
            Feature.SetHideInCharacterSheetAndLevelUp(true);
            Feature.SetReapplyOnLevelUp(true);
            Feature.SetIsClassFeature(true);
            Feature.Configure();
        }

    }

}