using HarmonyLib;
using System;
using UnityModManagerNet;
using JetBrains.Annotations;
using BlueprintCore.Utils;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.UnitLogic;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.UnitLogic.Class.LevelUp.Actions;
using Kingmaker.RuleSystem.Rules;
using Kingmaker.Enums;

namespace GeoEnchanter
{
    public static class Main
    {
        public static bool Enabled;
        private static readonly LogWrapper Logger = LogWrapper.Get("GeoEnchanter");

        public static bool Load(UnityModManager.ModEntry modEntry)
        {
            try
            {
                LogWrapper.EnableInternalVerboseLogs();
                modEntry.OnToggle = OnToggle;
                var harmony = new Harmony(modEntry.Info.Id);
                harmony.PatchAll();
                Logger.Info("Finished patching.");
            }
            catch (Exception e)
            {
                Logger.Error("Failed to patch", e);
            }
            return true;
        }

        public static bool OnToggle(UnityModManager.ModEntry modEntry, bool value)
        {
            Enabled = value;
            return true;
        }

        [HarmonyPatch(typeof(BlueprintsCache))]
        static class BlueprintsCaches_Patch
        {
            private static bool Initialized = false;

            [HarmonyPriority(Priority.First)]
            [HarmonyPatch(nameof(BlueprintsCache.Init)), HarmonyPostfix]
            static void Postfix()
            {
                try
                {
                    if (Initialized)
                    {
                        Logger.Info("GeoEnchanter: Already initialized blueprints cache.");
                        return;
                    }
                    Initialized = true;

                    Logger.Info("GeoEnchanter: Configuring Buffs.");
                    startBuffs();
                    Logger.Info("GeoEnchanter: Configuring Features.");
                    startFeatures();
                    Logger.Info("GeoEnchanter: Configuring Patches.");
                    startPatch();
                    Logger.Info("GeoEnchanter: Configuring Ability resourses.");
                    starAbilityResource();
                    Logger.Info("GeoEnchanter: Configuring Progressions.");
                    startProgression();
                    Logger.Info("GeoEnchanter: Configuring Archetypes.");
                    startArchetypes();
                }
                catch (Exception e)
                {
                    Logger.Error("GeoEnchanter: Failed to initialize.", e);
                }
            }
            static void startBuffs()
            {
                Buffs.GeoBurnBuff.Configure();
            }
            static void startFeatures()
            {
                WildSenses.WildSenses.Configure();
                WildSenses.WildSensesBuff.Configure();
                WildSenses.WildSensesUnlock.Configure();

                KineticFist.KineticFist1D4Feature.Configure();
                KineticFist.KineticFist2D4Feature.Configure();
                KineticFist.KineticFist4D4Feature.Configure();
                KineticFist.KineticFistEnchantment.Configure();
                Weapons.KineticFist1D4Weapon.Configure();
                Weapons.KineticFist2D4Weapon.Configure();
                Weapons.KineticFist4D4Weapon.Configure();

                Features.GeoBurn.Configure();

                Features.WisdomOfWords.Configure();
                Features.WisdomOfMind.Configure();
                WrackBlood.WrackBloodMetalAbility.Configure();
                WrackBlood.WrackBloodMetalFeature.Configure();

                Azata.AzataIncorporateSpellBook.Configure();
            }
            static void startArchetypes()
            {
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowEffectFeature.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowBonusFeature.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowEffectFeatureBuff.Configure();

                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel00EffectBuff.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel06EffectBuff.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel06WisConBuff.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel06WisDexBuff.Configure();

                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel11EffectBuff.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel11WisConBuff.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel11WisDexBuff.Configure();

                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel16EffectBuff.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel16WisConDexBuff.Configure();
                Archetypes.GeoEnchanter.GeoOverflow.GeoOverflowLevel16WisDexConBuff.Configure();

                Archetypes.GeoEnchanter.SpellBook.GeoEnchanterSpellBook.Configure();
                Archetypes.GeoEnchanter.SpellBook.GeoEnchanterSpellList.Configure();
                Archetypes.GeoEnchanter.SpellBook.GeoEnchanterSpellPerDay.Configure();
                Archetypes.GeoEnchanter.SpellBook.GeoInfusion.Configure();

                Archetypes.GeoEnchanter.GeoArmor.GeoArmorArmorAbility.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorArmorBuff.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorArmorEffectFeature.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorArmorMode.Configure();

                Archetypes.GeoEnchanter.GeoArmor.GeoArmorFeature.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorResource.Configure();

                Archetypes.GeoEnchanter.GeoArmor.GeoArmorShieldAbility.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorShieldBuff.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorShieldEffectFeature.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorShieldMode.Configure();

                Archetypes.GeoEnchanter.GeoArmor.GeoArmorUpgradeAbility.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorUpgradeBuff.Configure();
                Archetypes.GeoEnchanter.GeoArmor.GeoArmorUpgradeFeature.Configure();

                Archetypes.GeoEnchanter.GeoEnchanterProficiencies.cofigure();

                Archetypes.GeoEnchanterArchetype.Configure();

            }
            static void startPatch()
            {
                Patches.GeoEnchanterNoPicks.Configure();

                Patches.GeoEnchanterCanPicks.Configure();
            }
            static void starAbilityResource()
            {
                AbilityResources.GeoBurnResource.Configure();

                Ability.Overflow.GeoOverflowLevel06WisConAbility.Configure();
                Ability.Overflow.GeoOverflowLevel06WisDexAbility.Configure();
                Ability.Overflow.GeoOverflowLevel11WisConAbility.Configure();
                Ability.Overflow.GeoOverflowLevel11WisDexAbility.Configure();
                Ability.Overflow.GeoOverflowLevel16WisConDexAbility.Configure();
                Ability.Overflow.GeoOverflowLevel16WisDexConAbility.Configure();
            }
            static void startProgression()
            {
                Progression.GeoOverflow.Progression.Configure();
            }
        }
        [HarmonyPatch(typeof(LevelUpHelper))]
        static class LevelUpHelper_Patch
        {
            [HarmonyPatch(nameof(LevelUpHelper.GetIntelligenceSkillPoints)), HarmonyPrefix]
            static bool Prefix([NotNull] UnitDescriptor unit, int level, ref int __result)
            {
                static bool FilterIsRacialOrInherentOrSelfBonus(ModifiableValue.Modifier m) => m.ModDescriptor == ModifierDescriptor.Racial || m.ModDescriptor == ModifierDescriptor.Inherent || (m.ModDescriptor == ModifierDescriptor.Competence && !m.IsTempBuff() && m.ItemSource == null);
                int baseValue = unit.Stats.Intelligence.CalculateBaseValue(unit.Stats.Intelligence.BaseValue);
                int value = unit.Stats.Intelligence.ApplyModifiersFiltered(baseValue, FilterIsRacialOrInherentOrSelfBonus) / 2 - 5;
                int num = Math.Abs(value);
                int num2 = Math.Sign(value);
                if (level % 2 == 1)
                {
                    __result = (num + 1) / 2 * num2;
                    return false;
                }
                __result = num / 2 * num2;
                return false;
            }

        }
    }
}