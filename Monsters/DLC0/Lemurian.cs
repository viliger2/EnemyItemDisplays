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

            #region not done
            /*
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorPlate, "DisplayRepulsionArmorPlate",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.PersonalShield, "DisplayShieldGenerator",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FlatHealth, "DisplaySteakCurved",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TreasureCache, "DisplayKey",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IgniteOnKill, "DisplayGasoline",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StunChanceOnHit, "DisplayStunGrenade",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.OutOfCombatArmor, "DisplayOddlyShapedOpal",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.GoldOnHurt, "DisplayRollOfPennies",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.NearbyDamageBonus, "DisplayDiamond",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealWhileSafe, "DisplaySnail",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Mushroom, "DisplayMushroom",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BossDamageBonus, "DisplayAPRound",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnKill, "DisplayBrooch",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Syringe, "DisplaySyringeCluster",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FragileDamageBonus, "DisplayDelicateWatch",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.AttackSpeedAndMoveSpeed, "DisplayCoffee",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SecondarySkillMagazine, "DisplayDoubleMag",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WardOnLevel, "DisplayWarbanner",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BleedOnHit, "DisplayTriTip",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintBonus, "DisplaySoda",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.HealingPotion, "DisplayHealingPotion",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.Tooth,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothNecklaceDecal"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall2"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayToothMeshSmall1"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.StickyBomb, "DisplayStickyBomb",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Medkit, "DisplayMedkit",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bear, "DisplayBear",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Hoof, "DisplayHoof",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AttackSpeedOnCrit, "DisplayWolfPelt",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ChainLightning, "DisplayUkulele",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RegeneratingScrap, "DisplayRegeneratingScrap",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExplodeOnDeath, "DisplayWilloWisp",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Bandolier, "DisplayBandolier",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EnergizedOnEquipmentUse, "DisplayWarHorn",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.FreeChest, "DisplayShippingRequestForm",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Thorns, "DisplayRazorwireLeft",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.EquipmentMagazine, "DisplayBattery",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Infusion, "DisplayInfusion",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PrimarySkillShuriken, "DisplayShuriken",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HealOnCrit, "DisplayScythe",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SlowOnHit, "DisplayBauble",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintArmor, "DisplayBuckler",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Feather, "DisplayFeather",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.TPHealingNova, "DisplayGlowFlower",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExecuteLowHealthElite, "DisplayGuillotine",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Phasing, "DisplayStealthkit",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.WarCryOnMultiKill, "DisplayPauldron",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.FireRing, "DisplayFireRing",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.SprintOutOfCombat, "DisplayWhip",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.JumpBoost, "DisplayWaxBird",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.IceRing, "DisplayIceRing",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.DeathMark, "DisplayDeathMark",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.FallBoots,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayGravBoots"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.IncreaseHealing,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAntler"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.UtilitySkillMagazine,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.HeadHunter, "DisplaySkullcrown",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ArmorReductionOnHit, "DisplayWarhammer",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Talisman, "DisplayTalisman",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoreMissile, "DisplayICBM",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.RandomEquipmentTrigger, "DisplayBottledChaos",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.KillEliteFrenzy, "DisplayBrainstalk",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Behemoth, "DisplayBehemoth",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AlienHead, "DisplayAlienHead",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Clover, "DisplayClover",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShockNearby, "DisplayTeslaCoil",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.GhostOnKill, "DisplayMask",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.ImmuneToDebuff, "DisplayRainCoatBelt",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.LaserTurbine, "DisplayLaserTurbine",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Plant, "DisplayInterstellarDeskPlant",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateDisplayRuleGroupWithRules(RoR2Content.Items.NovaOnHeal,
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1)),
                ItemDisplays.CreateDisplayRule(ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                    "Head",
                    new Vector3(2, 2, 2),
                    new Vector3(0, 0, 0),
                    new Vector3(1, 1, 1))));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BarrierOnOverHeal, "DisplayAegis",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Icicle, "DisplayFrostRelic",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Dagger, "DisplayDagger",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BounceNearby, "DisplayHook",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            */
            #endregion not done
        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> itemList, List<ItemDisplayRuleSet.NamedRuleGroup> equipmentList) { }
    }
}