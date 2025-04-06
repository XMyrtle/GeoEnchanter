using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;

namespace Archetypes.GeoEnchanter.GeoArmor
{

    class GeoArmorFeature
    {
        private static readonly string FeatureName = "GeoArmorFeature";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(name: FeatureName, guid: Guids.GeoArmorFeature);

            Feature.AddFacts([Guids.GeoArmorArmorMode ,
                              Guids.GeoArmorShieldMode  ]);
            Feature.AddPrerequisiteArchetypeLevel(archetype: Guids.GeoEnchanterArchetype,
                                                  characterClass: CharacterClassRefs.KineticistClass.ToString(),
                                                  group: Prerequisite.GroupType.Any,
                                                  hideInUI: true,
                                                  level: 1);

            Feature.AddAbilityResources(amount: 0,
                                        resource: Guids.GeoArmorResource,
                                        restoreAmount: true,
                                        restoreOnLevelUp: false,
                                        useThisAsResource: false);
            Feature.AddSavesFixerFactReplacer(oldFacts: [Guids.GeoArmorArmorAbility,
                                                         Guids.GeoArmorShieldAbility],
                                              newFacts: [Guids.GeoArmorUpgradeAbility]);
            Feature.AddPrerequisiteArchetypeLevel(archetype: Guids.GeoEnchanterArchetype, characterClass: CharacterClassRefs.KineticistClass.ToString(), level: 8);

            Feature.SetDisplayName("GeoArmor_Name");
            Feature.SetDescription("GeoArmor_Desc");
            Feature.SetRanks(1);
            Feature.SetIsClassFeature(true);
            Feature.Configure();

        }

    }

}