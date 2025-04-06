using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils;
using GeoEnchanter.Util;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;


namespace GeoEnchanter.Patches

{
    public class GeoEnchanterNoPicks
    {
        public static void Configure()
        {
            string[] NoPicksArr = [ProgressionRefs.ElementalFocusAir_0.ToString(),
                                   ProgressionRefs.ElementalFocusWater_0.ToString(),
                                   ProgressionRefs.ElementalFocusFire_0.ToString(),
                                   ProgressionRefs.SecondaryElementAir.ToString(),
                                   ProgressionRefs.SecondaryElementWater.ToString(),
                                   ProgressionRefs.SecondaryElementFire.ToString(),
                                   ProgressionRefs.ElectricBlastProgression.ToString(),
                                   ProgressionRefs.ColdBlastProgression.ToString(),
                                   FeatureRefs.SkilledKineticistFeature.ToString(),
                                   FeatureRefs.BrewPotions.ToString(),
                                   FeatureRefs.SkillFocusPhysique.ToString(),
                                   FeatureRefs.SkillFocusAcrobatics.ToString(),
                                   FeatureRefs.SkillFocusKnowledgeWorld.ToString(),
                                   FeatureRefs.SkillFocusKnowledgeArcana.ToString(),
                                   FeatureRefs.SkillFocusLoreNature.ToString(),
                                   FeatureRefs.SkillFocusLoreReligion.ToString(),
                                   FeatureRefs.SkillFocusUseMagicDevice.ToString()];

            foreach (var RefString in NoPicksArr)
            {
                FeatureConfigurator.For(RefString)
                .AddPrerequisiteNoArchetype(archetype: Guids.GeoEnchanterArchetype, characterClass: CharacterClassRefs.KineticistClass.ToString())
                .Configure();
            }
        }

    }

}