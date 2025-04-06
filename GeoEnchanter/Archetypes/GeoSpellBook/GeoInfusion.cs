using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.UnitLogic.FactLogic;

namespace Archetypes.GeoEnchanter.SpellBook
{
    class GeoInfusion
    {
        private static readonly string FeatureName = "GeoInfusion";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(name: FeatureName, guid: Guids.GeoInfusion);

            Feature.AddPrerequisiteArchetypeLevel(archetype: Guids.GeoEnchanterArchetype,
                                                  characterClass: CharacterClassRefs.KineticistClass.ToString(),
                                                  group: Prerequisite.GroupType.All,
                                                  hideInUI: false,
                                                  level: 6);

            Feature.AddMechanicsFeature(AddMechanicsFeature.MechanicsFeatureType.Infusion);
            Feature.SetIcon(FeatureRefs.Infusion.Reference.Get().Icon);
            Feature.SetGroups(FeatureGroup.KineticWildTalent);

            Feature.SetDisplayName("GeoInfusion_Name");
            Feature.SetDescription("GeoInfusion_Desc");
            Feature.Configure();
        }

    }
}