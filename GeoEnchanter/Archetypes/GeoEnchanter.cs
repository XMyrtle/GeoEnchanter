using GeoEnchanter.Util;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using Kingmaker.EntitySystem.Stats;

namespace Archetypes
{
    public class GeoEnchanterArchetype
    {

        private static readonly string ArchetypeName = "GeoEnchanter";

        public static void Configure()
        {

            var Archetype = ArchetypeConfigurator.New(ArchetypeName, Guids.GeoEnchanterArchetype, clazz: CharacterClassRefs.KineticistClass.ToString());

            Archetype.SetLocalizedName("GeoEnchanter_Name");
            Archetype.SetLocalizedDescription("GeoEnchanter_Desc");
            Archetype.SetReplaceSpellbook(Guids.GeoEnchanterSpellBook);
            Archetype.SetOverrideAttributeRecommendations(true);
            Archetype.SetRecommendedAttributes(StatType.Dexterity,
                                               StatType.Wisdom);
            Archetype.SetReplaceClassSkills(true);
            Archetype.AddToClassSkills([StatType.SkillMobility,
                                        StatType.SkillPersuasion,
                                        StatType.SkillStealth,
                                        StatType.SkillThievery,
                                        StatType.SkillUseMagicDevice,
                                        StatType.SkillPerception,
                                        StatType.SkillThievery,
                                        StatType.SkillKnowledgeArcana,
                                        StatType.SkillKnowledgeWorld,
                                        StatType.SkillLoreNature,
                                        StatType.SkillLoreReligion]);
            Archetype.SetAddSkillPoints(4);
            Archetype.SetReplaceStartingEquipment(true);
            Archetype.SetStartingItems();
            Archetype.SetIsArcaneCaster(true);

            Archetype.AddToAddFeatures(1, Guids.KineticFist1D4Feature,
                                          Guids.GeoBurnFeature,
                                          Guids.WhildSensesUnlock,
                                          Guids.GeoOverflowProgression,
                                          Guids.GeoEnchanterProficiencies,
                                          Guids.WisdomOfMind);

            Archetype.AddToAddFeatures(3, Guids.GeoOverflowBonusFeature,
                                          FeatureRefs.SkilledKineticistFeature.ToString());

            Archetype.AddToAddFeatures(5, FeatureRefs.BrewPotions.ToString());

            Archetype.AddToAddFeatures(7, Guids.KineticFist2D4Feature,
                                          Guids.WrackBloodMetalFeature,
                                          FeatureRefs.SkillFocusPhysique.ToString());

            Archetype.AddToAddFeatures(9, FeatureRefs.SkillFocusAcrobatics.ToString());
            Archetype.AddToAddFeatures(11, FeatureRefs.SkillFocusKnowledgeWorld.ToString());
            Archetype.AddToAddFeatures(13, FeatureRefs.SkillFocusKnowledgeArcana.ToString());

            Archetype.AddToAddFeatures(15, Guids.KineticFist4D4Feature,
                                           FeatureRefs.SkillFocusLoreNature.ToString());

            Archetype.AddToAddFeatures(17, FeatureRefs.SkillFocusLoreReligion.ToString());
            Archetype.AddToAddFeatures(19, FeatureRefs.SkillFocusUseMagicDevice.ToString());

            Archetype.AddToRemoveFeatures(1, FeatureRefs.BurnFeature.ToString(),
                                             ProgressionRefs.ElementalOverflowProgression.ToString(),
                                             FeatureRefs.KineticistProficiencies.ToString());

            Archetype.AddToRemoveFeatures(3, FeatureRefs.ElementalOverflowBonusFeature.ToString());


            Archetype.Configure();
        }
    }
}
