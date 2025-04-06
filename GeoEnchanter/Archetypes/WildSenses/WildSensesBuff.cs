using BlueprintCore.Blueprints.CustomConfigurators.UnitLogic.Buffs;
using BlueprintCore.Blueprints.References;
using BlueprintCore.Utils.Types;
using GeoEnchanter.Util;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.Enums;

namespace GeoEnchanter.WildSenses
{
    public class WildSensesBuff
    {
        private static readonly string BuffName = "WildSensesBuff";
        public static void Configure()
        {
            // var ContextRank = ;
            var Buff = BuffConfigurator.New(BuffName, Guids.WhildSensesBuff);
            Buff.SetDisplayName("WildSenses_Name");
            Buff.SetDescription("WildSenses_Desc");
            Buff.AddContextRankConfig(ContextRankConfigs.StatBonus(StatType.Wisdom));
            Buff.AddContextStatBonus(stat: StatType.AC, value: ContextValues.Rank(), descriptor: ModifierDescriptor.UntypedStackable);
            Buff.AddRecalculateOnStatChange(stat: StatType.Wisdom);
            Buff.AddToFlags(flags: [Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.HiddenInUi, Kingmaker.UnitLogic.Buffs.Blueprints.BlueprintBuff.Flags.StayOnDeath]);
            Buff.SetIcon(icon: Icons.GeoKineticistIconRef.WildWhisper);
            Buff.Configure();
        }

    }

}