using RoR2;
using System.Collections.Generic;
using UnityEngine;

/* for custom copy format in keb's helper
{childName},
                {localPos}, 
                {localAngles},
                {localScale})
*/

namespace EnemyItemDisplays
{
    internal class BeetleGuard : ItemDisplaysBase
    {
        protected override string bodyName => "BeetleGuardBody";
        protected override Dictionary<string, string> NewChildLocatorEntries => new Dictionary<string, string>
        {
            { "Chest", "BeetleGuardArmature/ROOT/base/chest"}
        };
            
        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",//ITEM ADDED
                "HandL",
                new Vector3(-0.06025F, 0.66693F, 0.56345F),
                new Vector3(76.43118F, 50.16331F, 243.4129F),
                new Vector3(1F, 1F, 1F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",//ITEM ADDED
                "HandR",
                new Vector3(0.90448F, -2.24972F, 0.57388F),
                new Vector3(81.9503F, 180.0001F, 114.2604F),
                new Vector3(5.0423F, 5.0423F, 5.0423F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",//ITEM ADDED
                "HandL",
                new Vector3(0.18486F, -1.40367F, 1.49373F),
                new Vector3(352.4805F, 356.7237F, 203.6263F),
                new Vector3(2.29821F, 2.29821F, 2.29821F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",//ITEM ADDED
                "HandL",
                new Vector3(0.17838F, 3.21629F, 0.49846F),
                new Vector3(48.68543F, 33.1923F, 34.9691F),
                new Vector3(0.63598F, 0.63598F, 0.63598F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",//ITEM ADDED
                "HandR",
                new Vector3(1.05513F, -2.27994F, -0.75585F),
                new Vector3(283.4737F, -0.00001F, 304.81F),
                new Vector3(0.47936F, 0.47936F, 0.47936F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",//ITEM ADDED
                "FootL",
                new Vector3(0.11026F, -2.81744F, 0.23457F),
                new Vector3(54.48954F, 276.3395F, 253.9968F),
                new Vector3(0.22453F, 0.22453F, 0.22453F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",//ITEM ADDED
               "HandR",
                new Vector3(1.07887F, -1.14391F, -0.4547F),
                new Vector3(316.4285F, 8.03533F, 277.4492F),
                new Vector3(4.59384F, 4.59384F, 4.59384F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",//ITEM ADDED
                "HandR",
                new Vector3(0.93854F, -2.91885F, -0.41424F),
                new Vector3(0F, 0F, 254.4941F),
                new Vector3(1F, 1F, 1F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",//ITEM ADDED
                "Head",
                new Vector3(0.01668F, 1.22063F, -1.29563F),
                new Vector3(327.452F, 180F, 0F),
                new Vector3(2.25327F, 2.25327F, 2.25327F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",//ITEM ADDED
                "HandR",
                new Vector3(0.11531F, 0.43398F, -0.22972F),
                new Vector3(79.43044F, 180F, 180F),
                new Vector3(-6.04731F, -6.04731F, -6.04731F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee", //ITEM ADDED
                "HandR",
                new Vector3(-0.44244F, 2.59331F, 0.21867F),
                new Vector3(321.2516F, 307.7869F, 108.5926F),
                new Vector3(2.50297F, 2.50297F, 2.50297F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",//ITEM ADDED
                "HandL",
                new Vector3(1.24193F, -1.63193F, 0.46112F),
                new Vector3(0F, 0F, 0F),
                new Vector3(0.3803F, 0.3803F, 0.3803F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHit, "DisplayTriTip",//ITEM ADDED
                "FootL",
                new Vector3(0.01312F, -2.06405F, 0.30473F),
                new Vector3(70.70885F, 57.23246F, 92.81148F),
                new Vector3(1F, 1F, 1F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",//ITEM ADDED
                "HandL",
                new Vector3(-0.2237F, 2.15057F, -0.14677F),
                new Vector3(0F, 295.3702F, 0F),
                new Vector3(3.31863F, 3.31863F, 3.31863F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Tooth,
            //    ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothNecklaceDecal"),
            //        "Head",
            //        new Vector3(2, 2, 2),
            //        new Vector3(0, 0, 0),
            //        new Vector3(1, 1, 1)),
            //    ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
            //        "Head",
            //        new Vector3(2, 2, 2),
            //        new Vector3(0, 0, 0),
            //        new Vector3(1, 1, 1)),
            //    ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
            //        "Head",
            //        new Vector3(2, 2, 2),
            //        new Vector3(0, 0, 0),
            //        new Vector3(1, 1, 1)),
            //    ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
            //        "Head",
            //        new Vector3(2, 2, 2),
            //        new Vector3(0, 0, 0),
            //        new Vector3(1, 1, 1)),
            //    ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
            //        "Head",
            //        new Vector3(2, 2, 2),
            //        new Vector3(0, 0, 0),
            //        new Vector3(1, 1, 1)),
            //    ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
            //        "Head",
            //        new Vector3(2, 2, 2),
            //        new Vector3(0, 0, 0),
            //        new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",//ITEM ADDED
                "HandL",
                new Vector3(1.02832F, -2.69804F, 0.14114F),
                new Vector3(0F, 0F, 342.5509F),
                new Vector3(1.43994F, 1.43994F, 1.43994F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Hoof, "DisplayHoof",//ITEM ADDED
                "FootL",
                new Vector3(-0.07036F, -0.46265F, -0.09927F),
                new Vector3(82.64526F, 30.87533F, 346.6072F),
                new Vector3(0.33146F, 0.33146F, 0.33146F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",//ITEM ADDED
                "Head",
                new Vector3(-0.0857F, 0.28754F, 1.34275F),
                new Vector3(274.9202F, 272.8375F, 262.2434F),
                new Vector3(2.1509F, 2.1509F, 2.1509F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",//ITEM ADDED
                "HandL",
                new Vector3(0.58264F, -2.01244F, -0.49661F),
                new Vector3(1.03884F, 94.07609F, 165.7258F),
                new Vector3(1F, 1F, 1F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",//ITEM ADDED
                "HandL",
                new Vector3(0.48574F, -0.32447F, 1.13641F),
                new Vector3(352.7169F, 45.36266F, 1.93217F),
                new Vector3(1F, 1F, 1F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Feather, "DisplayFeather",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",//ITEM ADDED
                "HandL",
                new Vector3(-0.0113F, 1.26895F, -0.09944F),
                new Vector3(90F, 0F, 0F),
                new Vector3(6.60014F, 6.60014F, 6.60014F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",//ITEM ADDED
                "FootR",
                new Vector3(-0.42269F, -2.92595F, 0.00448F),
                new Vector3(11.73557F, 180F, 180F),
                new Vector3(1.53846F, 1.53846F, 1.53846F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",//ITEM ADDED
                "Head",
                new Vector3(0.14451F, 0.15254F, -0.65131F),
                new Vector3(300.646F, 183.0527F, 352.7496F),
                new Vector3(2.56758F, 2.56758F, 2.56758F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",//ITEM ADDED
                "HandR",
                new Vector3(-0.0113F, 1.26895F, -0.09944F),
                new Vector3(90F, 0F, 0F),
                new Vector3(6.60014F, 6.60014F, 6.60014F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.FallBoots,//ITEM ADDED
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                   "FootL",
                    new Vector3(-0.06206F, -0.8584F, 0.07425F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "FootR",
                    new Vector3(-0.02454F, -0.91405F, -0.08598F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(1F, 1F, 1F))));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,//ITEM ADDED
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(0.54849F, 0.29914F, 0.05247F),
                    new Vector3(333.2592F, 73.80288F, 113.9083F),
                    new Vector3(-1.65228F, 1.65228F, 1.65228F)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(-0.7152F, 0.65511F, 0.17937F),
                    new Vector3(343.0727F, 273.023F, 259.7193F),
                    new Vector3(1.65228F, 1.65228F, 1.65228F))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",//ITEM ADDED
                "HandR",
                new Vector3(0.03761F, 2.38697F, -0.49405F),
                new Vector3(1.72924F, 98.23392F, 265.1608F),
                new Vector3(1F, 1F, 1F)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,//ITEM ADDED
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "HandL",
                    new Vector3(0.39126F, -3.88834F, 0.87262F),
                    new Vector3(0F, 326.4375F, 90F),
                    new Vector3(4.54411F, 4.54411F, 4.54411F)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "HandR",
                    new Vector3(0.51255F, -3.88834F, -0.49201F),
                    new Vector3(0F, 16.57148F, 90F),
                    new Vector3(4.54411F, 4.54411F, 4.54411F))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullcrown",//ITEM ADDED
                "Head",
                new Vector3(0.01321F, 1.43162F, 0.20837F),
                new Vector3(333.2151F, 180.3322F, 0F),
                new Vector3(1F, 1F, 1F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorReductionOnHit, "DisplayWarhammer",//ITEM ADDED
                "HandL",
                new Vector3(-2.11491F, 2.39096F, 1.93109F),
                new Vector3(6.79332F, 318.8018F, 57.96885F),
                new Vector3(1.66636F, 1.66636F, 1.66636F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",//ITEM ADDED
                "Head",
                new Vector3(-4.11265F, 0.61414F, 0.71875F),
                new Vector3(289.9617F, 310.5049F, 227.7345F),
                new Vector3(1F, 1F, 1F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Behemoth, "DisplayBehemoth",//ITEM ADDED
                "Chest",
                new Vector3(-0.54875F, 1.56057F, -3.9646F), 
                new Vector3(6.11851F, 200.3666F, 359.3759F),
                new Vector3(1F, 1F, 1F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AlienHead, "DisplayAlienHead",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",//ITEM ADDED
                "Head",
                new Vector3(-0.18729F, -0.62408F, 2.64015F),
                new Vector3(48.99079F, 35.54156F, 63.0342F),
                new Vector3(2.99428F, 2.99428F, 2.99428F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShockNearby, "DisplayTeslaCoil",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",//ITEM ADDED
                "Head",
                new Vector3(0.10487F, 1.77481F, -1.29546F),
                new Vector3(303.385F, 179.7858F, 359.5628F),
                new Vector3(5.61354F, 5.61354F, 5.61354F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",//ITEM ADDED
                "FootL",
                new Vector3(-0.25276F, -3.5791F, -0.03468F),
                new Vector3(66.62354F, 347.643F, 330.9188F),
                new Vector3(1F, 1F, 1F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.NovaOnHeal,//ITEM ADDED
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Head",
                    new Vector3(0.54231F, 0.69289F, 0.12676F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(2.79694F, 2.79694F, 2.79694F)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Head",
                    new Vector3(-0.70403F, 0.87404F, 0.03858F),
                    new Vector3(0F, 0F, 0F),
                    new Vector3(-2.79694F, 2.79694F, 2.79694F))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis", //ITEM ADDED
                "HandR",
                new Vector3(0.43817F, -2.47105F, -1.51659F),
                new Vector3(79.52251F, 160.1199F, 161.9474F),
                new Vector3(1F, 1F, 1F)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",//ITEM ADDED
                "Head",
                new Vector3(3.03389F, 0.47456F, -0.43924F),
                new Vector3(0F, 0F, 0F),
                new Vector3(1F, 1F, 1F)));
            //itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
            //    "Head",
            //    new Vector3(2, 2, 2),
            //    new Vector3(0, 0, 0),
            //    new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",//ITEM ADDED
                "FootR",
                new Vector3(-0.04678F, -3.53939F, 0.09334F),
                new Vector3(331.7854F, 155.7689F, 149.7504F),
                new Vector3(1F, 1F, 1F)));
        }
    }
}