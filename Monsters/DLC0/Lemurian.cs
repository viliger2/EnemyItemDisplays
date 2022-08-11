using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.DLC0
{
    public class Lemurian : ItemDisplaysBase
    {
        protected override string bodyName => "LemurianBody";

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(
                RoR2Content.Items.CritGlasses,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "Head",
                    new Vector3(0.68134F, 2.60111F, -0.14507F),
                    new Vector3(303.3854F, 90F, 270F),
                    new Vector3(2.48779F, -6.50632F, 2.6538F)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "Head",
                    new Vector3(-0.74922F, 2.60201F, -0.14517F),
                    new Vector3(311.7196F, 270F, 90F),
                    new Vector3(2.48779F, -6.50632F, 2.6538F))));
        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> itemList, List<ItemDisplayRuleSet.NamedRuleGroup> equipmentList) { }
    }
}