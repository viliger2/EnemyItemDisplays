using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.Bosses
{
    public class GroveTender : ItemDisplaysBase
    {
        protected override string bodyName => "GravekeeperBody";

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {

        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> list, List<ItemDisplayRuleSet.NamedRuleGroup> list2)
        {
            #region items
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "IncreaseHealing",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAntler"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(1.5f, 2f, 0.017f),
                            localAngles = new Vector3(358.0388f, 93.19246f, 1.436809f),
                            localScale = new Vector3(3f, 3f, 3f),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAntler"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-1.5f, 2f, 0.017f),
                            localAngles = new Vector3(358.03f, 266.808f, 1.436998f),
                            localScale = new Vector3(-3f, 3f, 3f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "NovaOnHeal",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(1.25f, -1f, 0f),
                            localAngles = new Vector3(3.536957f, 0.01489126f, 14.99564f),
                            localScale = new Vector3(5f, 5f, 5f),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDevilHorns"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-1.25f, -1f, 0f),
                            localAngles = new Vector3(3.536963f, 0.0149023f, 344.9955f),
                            localScale = new Vector3(-5f, 5f, 5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "KillEliteFrenzy",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBrainstalk"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 1.5f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Clover",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayClover"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-1.5f, 3f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
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
                            childName = "Mask",
                            localPos = new Vector3(0f, 0f, 0.5f),
                            localAngles = new Vector3(-90f, 180f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "GhostOnKill",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMask"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 1f, 2f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
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
                            localPos = new Vector3(0f, 2f, 1f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ShieldOnly",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldBug"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0.75f, -0.2f, 0.5f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldBug"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-0.75f, -0.2f, 0.5f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(-4f, 4f, 4f),
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
                            localPos = new Vector3(0f, -0.5f, -1f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(5f, 5f, 5f),
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
                            childName = "MuzzleJar",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(7f, 8f, 10f),
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
                            childName = "MuzzleJar",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
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
                            localPos = new Vector3(0f, 1f, 2f),
                            localAngles = new Vector3(-90f, 180f, 0f),
                            localScale = new Vector3(5f, 5f, 5f),
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
                            childName = "Mask",
                            localPos = new Vector3(0.5f, -0.5f, 2.4f),
                            localAngles = new Vector3(90f, 25f, 0f),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
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
                            childName = "MuzzleJar",
                            localPos = new Vector3(3.5f, -2f, 0f),
                            localAngles = new Vector3(90f, -90f, 0f),
                            localScale = new Vector3(3f, 3f, 3f),
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
                            childName = "MuzzleJar",
                            localPos = new Vector3(0f, -2f, -5f),
                            localAngles = new Vector3(180f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
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
                            childName = "HandL",
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
                            childName = "HandL",
                            localPos = new Vector3(0.25f, 0f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
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
                            childName = "HandR",
                            localPos = new Vector3(-0.25f, 0f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
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
                            localPos = new Vector3(0f, 1.5f, -2f),
                            localAngles = new Vector3(-25f, 0f, 180f),
                            localScale = new Vector3(3f, 3f, 3f),
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
                            localPos = new Vector3(-1.9f, 0.5f, -1.5f),
                            localAngles = new Vector3(0f, -90f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            localPos = new Vector3(2f, 0f, 0f),
                            localAngles = new Vector3(-90f, 90f, 0f),
                            localScale = new Vector3(3f, 3f, 3f),
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
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(6f, 6f, 6f),
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
                            childName = "MuzzleJar",
                            localPos = new Vector3(-3.2f, -2.5f, 1f),
                            localAngles = new Vector3(0f, 300f, 180f),
                            localScale = new Vector3(8f, 8f, 8f),
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
                            localPos = new Vector3(0f, 2f, 0f),
                            localAngles = new Vector3(300f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            childName = "MuzzleJar",
                            localPos = new Vector3(0f, -4f, -3f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            childName = "HandR",
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
                name = "SprintWisp",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBrokenMask"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Mask",
                            localPos = new Vector3(0f, 0.25f, 1.5f),
                            localAngles = new Vector3(-110f, 0f, 180f),
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
                            localPos = new Vector3(0f, 0.25f, 0.75f),
                            localAngles = new Vector3(20f, 0f, 180f),
                            localScale = new Vector3(0.75f, 0.5f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Incubator",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAncestralIncubator"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "MuzzleJar",
                            localPos = new Vector3(0f, -4.5f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1.25f, 1f, 1.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ExplodeOnDeath",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWilloWisp"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(-8.5f, 2.75f, 0f),
                            localAngles = new Vector3(0f, 0f, 45f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ExecuteLowHealthElite",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGuillotine"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(8.5f, 2.75f, 0f),
                            localAngles = new Vector3(0f, 0f, -45f),
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
                            localPos = new Vector3(-2f, 13f, -4f),
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
                            localPos = new Vector3(4f, 12f, -6f),
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
                            localPos = new Vector3(0f, 16f, -12f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion items

            #region quips
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
                            localPos = new Vector3(0f, 1f, -2f),
                            localAngles = new Vector3(45f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
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
                            childName = "MuzzleJar",
                            localPos = new Vector3(0f, -9f, 0f),
                            localAngles = new Vector3(180f, 270f, 180f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            localPos = new Vector3(0f, 10.5f, -12f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list2.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Saw",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySawmerangFollower"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Root",
                            localPos = new Vector3(0f, 10.5f, -12f),
                            localAngles = new Vector3(-90f, 0f, 0f),
                            localScale = new Vector3(0.4f, 0.4f, 0.4f),
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
                            localPos = new Vector3(0f, 16f, -6f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion quips
        }
    }
}