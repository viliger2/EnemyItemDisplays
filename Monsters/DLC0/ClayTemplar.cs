using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.DLC0
{
    public class ClayTemplar : ItemDisplaysBase
    {
        protected override string bodyName => "ClayBruiserBody";

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            #region not done
            /*
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
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Crowbar, "DisplayCrowbar",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Firework, "DisplayFirework",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.StrengthenBurn, "DisplayGasTank",
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
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Missile, "DisplayMissileLauncher",
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
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.BonusGoldPackOnKill, "DisplayTome",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Seed, "DisplaySeed",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.MoveSpeedOnKill, "DisplayGrappleHook",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.Squid, "DisplaySquidTurret",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.PermanentDebuffOnHit, "DisplayScorpion",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(DLC1Content.Items.CritDamage, "DisplayLaserSight",
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
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.AlienHead, "DisplayAlienHead",
                "Head",
                new Vector3(2, 2, 2),
                new Vector3(0, 0, 0),
                new Vector3(1, 1, 1)));
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ShockNearby, "DisplayTeslaCoil",
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
            */
            #endregion not done
        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> list, List<ItemDisplayRuleSet.NamedRuleGroup> list2)
        {
            ItemDisplayRuleSet itemDisplayRuleSet3 = Resources.Load<GameObject>("Prefabs/CharacterBodies/LoaderBody").GetComponentInChildren<CharacterModel>().itemDisplayRuleSet;

            #region fromLoader
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "IncreaseHealing",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("IncreaseHealing")))
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "NovaOnHeal",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("NovaOnHeal")))
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "KillEliteFrenzy",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("KillEliteFrenzy")))
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Clover",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("Clover")))
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "GoldOnHit",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("GoldOnHit")))
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ShieldOnly",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("ShieldOnly")))
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "HeadHunter",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("HeadHunter")))
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "GhostOnKill",
                displayRuleGroup = itemDisplayRuleSet3.FindDisplayRuleGroup(ItemCatalog.GetItemDef(ItemCatalog.FindItemIndex("GhostOnKill")))
            });
            #endregion loader

            #region items
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "CritGlasses",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGlasses"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 0.4f, 0.25f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "AttackSpeedOnCrit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWolfPelt"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 0.5f, 0.067f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "JumpBoost",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWaxBird"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, -0.7f, -0.05f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Bandolier",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBandolier"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0.05f, -0.05f, -1.75f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.75f, 1f, 1f),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBandolier"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-0.2f, -0.5f, 0.25f),
                            localAngles = new Vector3(-45f, 180f, 0f),
                            localScale = new Vector3(1f, 2f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "DeathMark",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDeathMark"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0f, -0.25f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.1f, 0.1f, 0.1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "WarCryOnMultiKill",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayPauldron"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 0.1f, -0.25f),
                            localAngles = new Vector3(-90f, 0f, 0f),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Mushroom",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMushroom"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-0.25f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 45f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BarrierOnOverHeal",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAegis"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0.25f, -1f),
                            localAngles = new Vector3(180f, 180f, 180f),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Behemoth",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBehemoth"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0f, -0.9f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "NearbyDamageBonus",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDiamond"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0f, -2.75f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.7f, 0.7f, 0.7f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "FireRing",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFireRing"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0f, -1f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(3.5f, 3.5f, 3.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "IceRing",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayIceRing"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0f, -1.2f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(3.5f, 3.5f, 3.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ArmorPlate",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-0.4f, -0.5f, 0.15f),
                            localAngles = new Vector3(-90f, 260f, 45f),
                            localScale = new Vector3(0.8f, 0.6f, 0.6f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Bear",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBear"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 0f, -0.4f),
                            localAngles = new Vector3(0f, 180f, 0f),
                            localScale = new Vector3(0.6f, 0.6f, 0.6f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Medkit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMedkit"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-0.4f, -0.5f, 0.15f),
                            localAngles = new Vector3(-90f, -90f, 0f),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Dagger",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDagger"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(-90f, -90f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ChainLightning",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayUkulele"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0.4f, 0f, -1.75f),
                            localAngles = new Vector3(0f, 85f, 90f),
                            localScale = new Vector3(0.8f, 0.8f, 0.8f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Syringe",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 0f, -0.15f),
                            localAngles = new Vector3(-60f, 0f, 0f),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ArmorReductionOnHit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWarhammer"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0.25f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "FallBoots",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "FootL",
                            localPos = new Vector3(0f, -0.05f, 0f),
                            localAngles = new Vector3(45f, 0f, 0f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "FootR",
                            localPos = new Vector3(0f, -0.05f, 0f),
                            localAngles = new Vector3(70f, 0f, 0f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BounceNearby",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHook"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0f, -0.25f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "UtilitySkillMagazine",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0f, -0.75f),
                            localAngles = new Vector3(0f, -90f, 90f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Hoof",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHoof"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "FootL",
                            localPos = new Vector3(0f, 0.05f, -0.15f),
                            localAngles = new Vector3(50f, 180f, 180f),
                            localScale = new Vector3(0.15f, 0.15f, 0.075f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "HealWhileSafe",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySnail"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "FootR",
                            localPos = new Vector3(0f, -0.05f, 0f),
                            localAngles = new Vector3(0f, 0f, 180f),
                            localScale = new Vector3(0.1f, 0.1f, 0.1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "LunarPrimaryReplacement",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBirdEye"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, -0.1f, -0.25f),
                            localAngles = new Vector3(-90f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "SecondarySkillMagazine",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDoubleMag"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, -0.8f, -2f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(-0.2f, -0.2f, -0.2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Pearl",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayPearl"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-1f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.2f, 0.2f, 0.2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ShinyPearl",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShinyPearl"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(1f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.2f, 0.2f, 0.2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "SprintOutOfCombat",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWhip"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-0.5f, -1.2f, 0.25f),
                            localAngles = new Vector3(0f, 0f, -20f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Icicle",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFrostRelic"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Root",
                            localPos = new Vector3(-1f, 2f, -1f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Talisman",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTalisman"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Root",
                            localPos = new Vector3(1f, 2f, -1f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "FocusConvergence",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Root",
                            localPos = new Vector3(0.5f, 2.5f, -3f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.2f, 0.2f, 0.2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion items

            #region quips
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Fruit",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFruit"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0.6f, -1.2f, 0f),
                            localAngles = new Vector3(0f, -45f, 45f),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BFG",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBFG"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(0f, 0.2f, -0.25f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Meteor",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMeteor"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Root",
                            localPos = new Vector3(0f, 2f, -0.75f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Blackhole",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravCube"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Root",
                            localPos = new Vector3(0f, 2f, -0.75f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Jetpack",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBugWings"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-0.15f, -0.25f, 0f),
                            localAngles = new Vector3(0f, 45f, 0f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "GoldGat",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGoldGat"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Muzzle",
                            localPos = new Vector3(1f, 0.8f, -1f),
                            localAngles = new Vector3(45f, 90f, 0f),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion quips
        }
    }
}