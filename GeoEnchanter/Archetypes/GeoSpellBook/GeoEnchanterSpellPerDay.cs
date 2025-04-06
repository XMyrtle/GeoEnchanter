using System;
using BlueprintCore.Blueprints.Configurators.Classes.Spells;
using GeoEnchanter.Util;
using Kingmaker.Blueprints.Classes.Spells;

namespace Archetypes.GeoEnchanter.SpellBook
{
    class GeoEnchanterSpellPerDay
    {
        private static readonly string TableName = "GeoEnchanterSpellPerDay";
        public static void Configure()
        {
            var Table = SpellsTableConfigurator.New(name: TableName, guid: Guids.GeoEnchanterSpellPerDay);
            SpellsLevelEntry[] Levels =
            [
             /*00*/  new SpellsLevelEntry { Count = [] },
             /*01*/  new SpellsLevelEntry { Count = [0, 1] },
             /*02*/  new SpellsLevelEntry { Count = [0, 2] },
             /*03*/  new SpellsLevelEntry { Count = [0, 3] },
             /*04*/  new SpellsLevelEntry { Count = [0, 3, 1] },
             /*05*/  new SpellsLevelEntry { Count = [0, 4, 2] },
             /*06*/  new SpellsLevelEntry { Count = [0, 4, 3] },
             /*07*/  new SpellsLevelEntry { Count = [0, 4, 3, 1] },
             /*08*/  new SpellsLevelEntry { Count = [0, 4, 4, 2] },
             /*09*/  new SpellsLevelEntry { Count = [0, 5, 4, 3] },
             /*10*/  new SpellsLevelEntry { Count = [0, 5, 4, 3, 1] },
             /*11*/  new SpellsLevelEntry { Count = [0, 5, 4, 4, 2] },
             /*12*/  new SpellsLevelEntry { Count = [0, 5, 5, 4, 3] },
             /*13*/  new SpellsLevelEntry { Count = [0, 5, 5, 4, 3, 1] },
             /*14*/  new SpellsLevelEntry { Count = [0, 6, 5, 4, 4, 2] },
             /*15*/  new SpellsLevelEntry { Count = [0, 6, 5, 5, 4, 3] },
             /*16*/  new SpellsLevelEntry { Count = [0, 6, 5, 5, 4, 3, 1] },
             /*17*/  new SpellsLevelEntry { Count = [0, 6, 6, 5, 4, 4, 2] },
             /*18*/  new SpellsLevelEntry { Count = [0, 6, 6, 5, 5, 4, 3] },
             /*19*/  new SpellsLevelEntry { Count = [0, 6, 6, 5, 5, 5, 4] },
             /*20*/  new SpellsLevelEntry { Count = [0, 7, 6, 6, 5, 5, 5] },
             /*21*/  new SpellsLevelEntry { Count = [0, 7, 6, 6, 5, 5, 5, 1] },
             /*22*/  new SpellsLevelEntry { Count = [0, 7, 6, 6, 5, 5, 5, 2] },
             /*23*/  new SpellsLevelEntry { Count = [0, 7, 6, 6, 6, 5, 5, 3] },
             /*24*/  new SpellsLevelEntry { Count = [0, 7, 7, 6, 6, 6, 5, 3, 1] },
             /*25*/  new SpellsLevelEntry { Count = [0, 7, 7, 6, 6, 6, 5, 4, 2] },
             /*26*/  new SpellsLevelEntry { Count = [0, 7, 7, 7, 6, 6, 6, 4, 3] },
             /*27*/  new SpellsLevelEntry { Count = [0, 8, 7, 7, 6, 6, 6, 4, 3, 1] },
             /*28*/  new SpellsLevelEntry { Count = [0, 8, 7, 7, 6, 6, 6, 4, 3, 2] },
             /*29*/  new SpellsLevelEntry { Count = [0, 8, 7, 7, 7, 6, 6, 5, 3, 3] },
             /*30*/  new SpellsLevelEntry { Count = [0, 8, 7, 7, 7, 6, 6, 5, 4, 3] },
             /*31*/  new SpellsLevelEntry { Count = [0, 8, 8, 7, 7, 7, 6, 5, 5, 4] },
             /*32*/  new SpellsLevelEntry { Count = [0, 8, 8, 8, 7, 7, 6, 5, 5, 5] },
             /*33*/  new SpellsLevelEntry { Count = [0, 8, 8, 8, 7, 7, 7, 5, 5, 5] },
             /*34*/  new SpellsLevelEntry { Count = [0, 8, 8, 8, 7, 7, 7, 6, 5, 5] },
             /*35*/  new SpellsLevelEntry { Count = [0, 9, 8, 8, 7, 7, 7, 6, 5, 5] },
             /*36*/  new SpellsLevelEntry { Count = [0, 9, 8, 8, 7, 7, 7, 6, 5, 5] },
             /*37*/  new SpellsLevelEntry { Count = [0, 9, 8, 8, 7, 7, 7, 6, 5, 5] },
             /*38*/  new SpellsLevelEntry { Count = [0, 9, 8, 8, 7, 7, 7, 6, 5, 5] },
             /*39*/  new SpellsLevelEntry { Count = [0, 9, 8, 8, 7, 7, 7, 6, 5, 5] },
             /*40*/  new SpellsLevelEntry { Count = [0, 9, 8, 8, 7, 7, 7, 6, 5, 5] },
            ];
            Table.SetLevels(Levels);
            Table.Configure();
        }
    }
}