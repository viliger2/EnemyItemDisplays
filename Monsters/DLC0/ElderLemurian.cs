using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.DLC0
{
    internal class ElderLemurian : ItemDisplaysBase
    {
        protected override string bodyName => "LemurianBruiserBody";

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.CritGlasses,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGlasses"),
                    "Head",
                    new Vector3(0F, 2.48657F, 0.28219F),
                    new Vector3(274.0505F, 182.2924F, 358.6325F),
                    new Vector3(5.37143F, -8.9606F, 3.70641F))));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Equipment.CommandMissile,
                ItemDisplays.LoadDisplay("DisplayMissileRack"),
                "Chest",
                new Vector3(0F, 1.81184F, 2.14752F),
                new Vector3(79.05093F, -0.00016F, -0.00021F),
                new Vector3(5.96821F, 5.96821F, 5.96821F)));

            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile,
                ItemDisplays.LoadDisplay("DisplayMissileLauncher"),
                "Chest",
                new Vector3(2.99517F, 3.48279F, 3.12278F),
                new Vector3(314.8465F, 189.9125F, 14.65636F),
                new Vector3(1F, 1F, 1F)));
        }
    }
}