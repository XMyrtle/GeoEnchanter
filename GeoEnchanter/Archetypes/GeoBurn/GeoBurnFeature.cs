using BlueprintCore.Actions.Builder;
using BlueprintCore.Actions.Builder.ContextEx;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;

namespace Features
{
    public class GeoBurn
    {
        private static readonly string FeatureName = "GeoBurnFeature";
        public static void Configure()
        {
            var Feature = FeatureConfigurator.New(FeatureName, Guids.GeoBurnFeature);
            Feature.SetHideInUI(false);
            Feature.SetDisplayName("GeoBurn_Name");
            Feature.SetDescription("GeoBurn_Desc");

            Feature.AddAbilityResources(resource: Guids.GeoBurnResource);
            Feature.AddKineticistPart(clazz: CharacterClassRefs.KineticistClass.ToString(),
                                      mainStat: Kingmaker.EntitySystem.Stats.StatType.Wisdom,
                                      maxBurn: Guids.GeoBurnResource,
                                      maxBurnPerRound: AbilityResourceRefs.BurnPerRoundResource.ToString(),
                                      gatherPowerAbility: AbilityRefs.GatherPower.ToString(),
                                      gatherPowerIncreaseFeature: FeatureRefs.GatherPowerFeature.ToString(),
                                      gatherPowerBuff1: BuffRefs.GatherPowerBuffI.ToString(),
                                      gatherPowerBuff2: BuffRefs.GatherPowerBuffII.ToString(),
                                      gatherPowerBuff3: BuffRefs.GatherPowerBuffIII.ToString(),
                                      bladeActivatedBuff: BuffRefs.KineticBladeEnableBuff.ToString(),
                                      blasts: [ AbilityRefs.AirBlastBase.ToString(),
                                                AbilityRefs.BlizzardBlastBase.ToString(),
                                                AbilityRefs.BlueFlameBlastBase.ToString(),
                                                AbilityRefs.ChargedWaterBlastBase.ToString(),
                                                AbilityRefs.ColdBlastBase.ToString(),
                                                AbilityRefs.EarthBlastBase.ToString(),
                                                AbilityRefs.ElectricBlastBase.ToString(),
                                                AbilityRefs.FireBlastBase.ToString(),
                                                AbilityRefs.IceBlastBase.ToString(),
                                                AbilityRefs.MagmaBlastBase.ToString(),
                                                AbilityRefs.MetalBlastBase.ToString(),
                                                AbilityRefs.MudBlastBase.ToString(),
                                                AbilityRefs.PlasmaBlastBase.ToString(),
                                                AbilityRefs.SandstormBlastBase.ToString(),
                                                AbilityRefs.SteamBlastBase.ToString(),
                                                AbilityRefs.ThunderstormBlastBase.ToString(),
                                                AbilityRefs.WaterBlastBase.ToString()]);
            Feature.AddAbilityResources(useThisAsResource: false,
                                        resource: AbilityResourceRefs.BurnPerRoundResource.ToString(),
                                        amount: 0,
                                        restoreAmount: false,
                                        restoreOnLevelUp: true);

            Feature.AddKineticistBurnValueChangedTrigger(action: ActionsBuilder.New()
                                                                .ApplyBuffPermanent(Guids.GeoBurnBuff));

            Feature.Configure();
        }

    }

}