using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.DLC1
{
    //geep and gip have the same armature, so we can inherit the same item displays
    //TODO: simply pass on itemdisplayruleset instead of rebuilding item displays
    public class Gip : Gup
    {
        protected override string bodyName => "GipBody";
    }

    public class Geep : Gup
    {
        protected override string bodyName => "GeepBody";
    }

    public class Gup : ItemDisplaysBase
    {
        protected override string bodyName => "GupBody";

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses,
                ItemDisplays.LoadDisplay("DisplayGlasses"),
                "MainBody3",
                new Vector3(0.01005F, -0.24246F, 0.92598F),
                new Vector3(0F, 0F, 0F),
                new Vector3(1.50575F, -2.26222F, 0.92272F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                "MainBody3",
                new Vector3(-0.07243F, 0.73686F, 0.07802F),
                new Vector3(313.2768F, 359.8946F, 5.00042F),
                new Vector3(0.46741F, 0.48114F, 0.48114F)));
        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> itemList, List<ItemDisplayRuleSet.NamedRuleGroup> equipmentList) { }
    }
}