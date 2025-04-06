using System;
using BlueprintCore.Blueprints.Configurators.Classes;
using BlueprintCore.Blueprints.Configurators.Classes.Spells;
using BlueprintCore.Blueprints.CustomConfigurators.Classes;
using BlueprintCore.Blueprints.References;
using GeoEnchanter.Util;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.EntitySystem.Stats;

namespace Archetypes.GeoEnchanter.SpellBook
{
    class GeoEnchanterSpellBook
    {
        private static readonly string BookName = "GeoEnchanterSpellBook";
        public static void Configure()
        {
            SpellbookConfigurator.New(name: BookName, guid: Guids.GeoEnchanterSpellBook)
            .CopyFrom(SpellbookRefs.AlchemistSpellbook)
            .AddComponent(new IsAlchemistSpellbook() { m_Flags = 0, m_PrototypeLink = null, name = "$IsAlchemistSpellbook$26f39df4-f772-476b-b87a-85815064de59" })
            .SetName("GeoEnchanterSpellBook_Name")
            .SetIsMythic(false)
            .SetSpellsPerDay(Guids.GeoEnchanterSpellPerDay)
            .SetSpellsKnown(null)
            .SetSpellSlots(Guids.GeoEnchanterSpellPerDay)
            .SetSpellList(Guids.GeoEnchanterSpellList)
            .SetCharacterClass(characterClass: CharacterClassRefs.KineticistClass.ToString())
            .SetCastingAttribute(StatType.Wisdom)
            .SetSpontaneous(true)
            .SetSpellsPerLevel(2)
            .SetAllSpellsKnown(false)
            .SetCantripsType(CantripsType.Cantrips)
            .SetCanCopyScrolls(true)
            .SetIsArcane(true)
            .SetIsArcanist(false)
            .SetHasSpecialSpellList(false)
            .SetSpecialSpellListName(null)
            .Configure();

            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.AngelIncorporateSpellbook.ToString())
            .AddToAllowedSpellbooks(Guids.GeoEnchanterSpellBook)
            .Configure();
            FeatureSelectMythicSpellbookConfigurator.For(FeatureSelectMythicSpellbookRefs.LichIncorporateSpellbookFeature.ToString())
            .AddToAllowedSpellbooks(Guids.GeoEnchanterSpellBook)
            .Configure();
        }

    }

}