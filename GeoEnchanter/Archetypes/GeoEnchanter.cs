using GeoEnchanter.Util;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using Kingmaker.EntitySystem.Stats;
using BlueprintCore.Blueprints.Configurators.Classes;

namespace Archetypes
{
    public class GeoEnchanterArchetype
    {

        private static readonly string ArchetypeName = "GeoEnchanter";

        public static void Configure()
        {

            ArchetypeConfigurator.New(ArchetypeName, Guids.GeoEnchanterArchetype, clazz: CharacterClassRefs.KineticistClass.ToString())
            .SetLocalizedName("GeoEnchanter_Name")
            .SetLocalizedDescription("GeoEnchanter_Desc")
            .SetReplaceSpellbook(Guids.GeoEnchanterSpellBook)
            .SetOverrideAttributeRecommendations(true)
            .SetRecommendedAttributes(StatType.Dexterity,
                                      StatType.Wisdom)
            .SetReplaceClassSkills(true)
            .AddToClassSkills([StatType.SkillMobility,
                               StatType.SkillPersuasion,
                               StatType.SkillStealth,
                               StatType.SkillThievery,
                               StatType.SkillUseMagicDevice,
                               StatType.SkillPerception,
                               StatType.SkillThievery,
                               StatType.SkillKnowledgeArcana,
                               StatType.SkillKnowledgeWorld,
                               StatType.SkillLoreNature,
                               StatType.SkillLoreReligion])
            .SetAddSkillPoints(4)
            .SetReplaceStartingEquipment(true)
            .SetStartingItems()
            .SetIsArcaneCaster(true)
            .AddToAddFeatures(1, Guids.KineticFist1D4Feature,
                                 Guids.GeoBurnFeature,
                                 Guids.WhildSensesUnlock,
                                 Guids.GeoOverflowProgression,
                                 Guids.GeoEnchanterProficiencies,
                                 Guids.WisdomOfMind)
            .AddToAddFeatures(3, Guids.GeoOverflowBonusFeature,
                                 FeatureRefs.SkilledKineticistFeature.ToString())
            .AddToAddFeatures(5, FeatureRefs.BrewPotions.ToString())
            .AddToAddFeatures(7, Guids.KineticFist2D4Feature,
                                 Guids.WrackBloodMetalFeature,
                                 FeatureRefs.SkillFocusPhysique.ToString())
            .AddToAddFeatures(9, FeatureRefs.SkillFocusAcrobatics.ToString())
            .AddToAddFeatures(11, FeatureRefs.SkillFocusKnowledgeWorld.ToString())
            .AddToAddFeatures(13, FeatureRefs.SkillFocusKnowledgeArcana.ToString())

            .AddToAddFeatures(15, Guids.KineticFist4D4Feature,
                                 FeatureRefs.SkillFocusLoreNature.ToString())
            .AddToAddFeatures(17, FeatureRefs.SkillFocusLoreReligion.ToString())
            .AddToAddFeatures(19, FeatureRefs.SkillFocusUseMagicDevice.ToString())
            .AddToRemoveFeatures(1, FeatureRefs.BurnFeature.ToString(),
                                    ProgressionRefs.ElementalOverflowProgression.ToString(),
                                    FeatureRefs.KineticistProficiencies.ToString())
            .AddToRemoveFeatures(3, FeatureRefs.ElementalOverflowBonusFeature.ToString())
            .Configure();

            ProgressionConfigurator.For(ProgressionRefs.KineticistProgression)
            .AddToUIGroups([Guids.WisdomOfMind,
                            FeatureRefs.SkilledKineticistFeature.ToString(),
                            FeatureRefs.BrewPotions.ToString(),
                            FeatureRefs.SkillFocusPhysique.ToString(),
                            FeatureRefs.SkillFocusAcrobatics.ToString(),
                            FeatureRefs.SkillFocusKnowledgeWorld.ToString(),
                            FeatureRefs.SkillFocusKnowledgeArcana.ToString(),
                            FeatureRefs.SkillFocusLoreNature.ToString(),
                            FeatureRefs.SkillFocusLoreReligion.ToString(),
                            FeatureRefs.SkillFocusUseMagicDevice.ToString()])
            .Configure();
        }
    }
}
