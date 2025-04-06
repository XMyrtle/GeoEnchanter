using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;

namespace Progression.GeoOverflow
{
    class Progression
    {
        private static readonly string ProgressionName = "GeoOverflowProgression";
        public static void Configure()
        {
            var Progression = ProgressionConfigurator.New(ProgressionName, Guids.GeoOverflowProgression);

            Progression.SetHideInUI(true);
            Progression.SetHideInCharacterSheetAndLevelUp(true);
            Progression.SetHideNotAvailibleInUI(false);
            Progression.SetAllowNonContextActions(false);
            Progression.SetRanks(1);
            Progression.SetReapplyOnLevelUp(true);
            Progression.SetIsClassFeature(true);
            Progression.AddToClasses(CharacterClassRefs.KineticistClass.ToString());

            Progression.AddToLevelEntry(3, [Guids.GeoOverflowBonusFeature]);
            Progression.AddToLevelEntry(6, [Guids.GeoOverflowEffectFeature]);

            Progression.Configure();

        }

    }

}