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
            //lemurian is now officially badass
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.CritGlasses,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "Head",
                    new Vector3(0.86758F, 2.5761F, -0.14513F),
                    new Vector3(303.3854F, 90F, 270F),
                    new Vector3(2.48779F, -6.50632F, 2.6538F)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "Head",
                    new Vector3(-0.85677F, 2.54469F, -0.14538F),
                    new Vector3(311.7196F, 270F, 90F),
                    new Vector3(2.48779F, -6.50632F, 2.6538F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile,
                ItemDisplays.LoadDisplay("DisplayMissileRack"),
                "Chest",
                new Vector3(0F, 1.06875F, 1.88626F),
                new Vector3(79.05093F, -0.00016F, -0.00021F),
                new Vector3(5.27486F, 5.27486F, 5.27486F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile,
                ItemDisplays.LoadDisplay("DisplayMissileLauncher"),
                "Chest",
                new Vector3(2.99517F, 3.48279F, 3.12278F),
                new Vector3(314.8465F, 189.9125F, 14.65636F),
                new Vector3(1F, 1F, 1F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                "Head",
                new Vector3(0.32657F, 0.6554F, -2.39174F),
                new Vector3(336.2278F, 175.6611F, 177.8167F),
                new Vector3(4.854F, 4.99656F, 4.99656F)));
        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> itemList, List<ItemDisplayRuleSet.NamedRuleGroup> equipmentList) { }
    }
}