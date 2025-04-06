
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.CustomConfigurators.Classes.Selection;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.Blueprints.Classes.Prerequisites;

namespace GeoEnchanter.Patches
{
    static class GeoEnchanterCanPicks
    {
        public static void Configure()
        {
            FeatureConfigurator.For(FeatureRefs.KineticHealerFeature)
            .SetKineticHealer()
            .Configure();

            FeatureConfigurator.For(FeatureRefs.KineticRevificationFeature)
            .SetKineticRevivification()
            .Configure();

            FeatureSelectionConfigurator.For(FeatureSelectionRefs.ExpandedDefense)
            .SetAllFeatures([FeatureRefs.ShroudOfWater.ToString(),
                                            FeatureRefs.SearingFlesh.ToString(),
                                            FeatureRefs.FleshOfStoneFeature.ToString(),
                                            FeatureRefs.EnvelopingWinds.ToString(),
                                            Guids.GeoArmorFeature])
            .AddToFeatureSelection(Guids.GeoArmorFeature)
            .Configure();

            FeatureSelectionConfigurator.For(FeatureSelectionRefs.WildTalentSelection)
            .AddToFeatureSelection(Guids.GeoInfusion)
            .Configure();


            FeatureSelectionConfigurator.For(FeatureSelectionRefs.ExtraWildTalentSelection)
            .AddToFeatureSelection(Guids.GeoInfusion)
            .Configure();
        }

        private static FeatureConfigurator SetKineticHealer(this FeatureConfigurator Configurator)
        {
            return Configurator.RemoveComponents(c =>
            {
                if (c is PrerequisiteFeaturesFromList PreReq)
                    return true;
                return false;
            })
            .AddPrerequisiteFeaturesFromList(group: Prerequisite.GroupType.Any,
                                                          features: [ProgressionRefs.ElementalFocusWater_0.ToString(),
                                                                     ProgressionRefs.SecondaryElementWater.ToString(),
                                                                     ProgressionRefs.ThirdElementWater.ToString(),
                                                                     ProgressionRefs.KineticKnightElementalFocusWater.ToString()])
            .AddPrerequisiteArchetypeLevel(archetype: Guids.GeoEnchanterArchetype,
                                                        characterClass: CharacterClassRefs.KineticistClass.ToString(),
                                                        group: Prerequisite.GroupType.Any,
                                                        hideInUI: false,
                                                        level: 1);

        }

        private static FeatureConfigurator SetKineticRevivification(this FeatureConfigurator Configurator)
        {
            return Configurator.EditComponent((PrerequisiteFeaturesFromList C) => { C.Group = Prerequisite.GroupType.Any; })
                   .AddPrerequisiteArchetypeLevel(archetype: Guids.GeoEnchanterArchetype,
                                                  characterClass: CharacterClassRefs.KineticistClass.ToString(),
                                                  group: Prerequisite.GroupType.Any,
                                                  level: 12);
        }
    }
}