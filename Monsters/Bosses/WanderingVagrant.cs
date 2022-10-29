using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays
{
    internal class WanderingVagrant : ItemDisplaysBase
    {
        protected override string bodyName => "VagrantBody";

        protected override Dictionary<string, string> NewChildLocatorEntries => new Dictionary<string, string>
        {
            { "Tentacle1_1",  "VagrantArmature/DetatchedHull/Tentacle1.001/Tentacle1.005/Tentacle1.003"},
            { "Tentacle1_2",  "VagrantArmature/DetatchedHull/Tentacle1.001/Tentacle1.005/Tentacle1.003/Tentacle1.007/Tentacle1.002"},
            { "Tentacle1_3",  "VagrantArmature/DetatchedHull/Tentacle1.001/Tentacle1.005/Tentacle1.003/Tentacle1.007/Tentacle1.002/Tentacle1.006/Tentacle1.004"},
            { "Tentacle1_Tip","VagrantArmature/DetatchedHull/Tentacle1.001/Tentacle1.005/Tentacle1.003/Tentacle1.007/Tentacle1.002/Tentacle1.006/Tentacle1.004/Tentacle1.008/Tentacle1.008_end"},
                                              
            { "Tentacle2_1",  "VagrantArmature/DetatchedHull/Tentacle2.001/Tentacle2.005/Tentacle2.003"},
            { "Tentacle2_2",  "VagrantArmature/DetatchedHull/Tentacle2.001/Tentacle2.005/Tentacle2.003/Tentacle2.007/Tentacle2.002"},
            { "Tentacle2_3",  "VagrantArmature/DetatchedHull/Tentacle2.001/Tentacle2.005/Tentacle2.003/Tentacle2.007/Tentacle2.002/Tentacle2.006/Tentacle2.004"},
            { "Tentacle2_Tip","VagrantArmature/DetatchedHull/Tentacle2.001/Tentacle2.005/Tentacle2.003/Tentacle2.007/Tentacle2.002/Tentacle2.006/Tentacle2.004/Tentacle2.008/Tentacle2.008_end"},
                                              
            { "Tentacle3_1",  "VagrantArmature/DetatchedHull/Tentacle3.001/Tentacle3.005/Tentacle3.003"},
            { "Tentacle3_2",  "VagrantArmature/DetatchedHull/Tentacle3.001/Tentacle3.005/Tentacle3.003/Tentacle3.007/Tentacle3.002"},
            { "Tentacle3_3",  "VagrantArmature/DetatchedHull/Tentacle3.001/Tentacle3.005/Tentacle3.003/Tentacle3.007/Tentacle3.002/Tentacle3.006/Tentacle3.004"},
            { "Tentacle3_Tip","VagrantArmature/DetatchedHull/Tentacle3.001/Tentacle3.005/Tentacle3.003/Tentacle3.007/Tentacle3.002/Tentacle3.006/Tentacle3.004/Tentacle3.008/Tentacle3.008_end"},
        };

        protected override bool generateDisplays => true;

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.CritGlasses, "DisplayGlasses",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHit, "DisplayTriTip",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Tooth,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothNecklaceDecal"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Hoof, "DisplayHoof",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Feather, "DisplayFeather",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.FallBoots,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullcrown",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorReductionOnHit, "DisplayWarhammer",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Behemoth, "DisplayBehemoth",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AlienHead, "DisplayAlienHead",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShockNearby, "DisplayTeslaCoil",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.NovaOnHeal,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Hull",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                "Hull",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
        }
    }
}