using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.DLC0
{
    public class Beetle : ItemDisplaysBase
    {
        protected override string bodyName => "BeetleBody";

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            itemDisplayRules.Add(ItemDisplays.CreateGenericDisplayRule(RoR2Content.Items.ExtraLife, "DisplayHippo",
                "Head",
                new Vector3(-0.17263F, 0.84528F, 0.81076F),
                new Vector3(322.9382F, 179.7548F, 347.6476F),
                new Vector3(0.9521F, 0.98007F, 0.98007F)));
        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> list, List<ItemDisplayRuleSet.NamedRuleGroup> list2)
        {
            #region rob is a fucking madman I miss him
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
                            localPos = new Vector3(0f, 0.25f, -0.2f),
                            localAngles = new Vector3(320f, 180f, 0f),
                            localScale = new Vector3(0.75f, 0.8f, 0.5f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Crowbar",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayCrowbar"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Chest",
                            localPos = new Vector3(0.5f, 0f, -0.6f),
                            localAngles = new Vector3(0f, 45f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
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
                            childName = "Chest",
                            localPos = new Vector3(0f, 0.75f, -1.5f),
                            localAngles = new Vector3(0f, 180f, 0f),
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
                            childName = "Head",
                            localPos = new Vector3(0f, 0.75f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
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
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
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
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
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
                            localPos = new Vector3(0.25f, 0f, 0.75f),
                            localAngles = new Vector3(35f, 0f, 180f),
                            localScale = new Vector3(2.5f, 1f, 1f),
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
                            childName = "Chest",
                            localPos = new Vector3(0.6f, 0.2f, -0.5f),
                            localAngles = new Vector3(0f, 110f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
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
                            childName = "Chest",
                            localPos = new Vector3(0f, 0f, -0.75f),
                            localAngles = new Vector3(270f, 180f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            childName = "Chest",
                            localPos = new Vector3(0f, 0.8f, 0f),
                            localAngles = new Vector3(315f, 0f, 0f),
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
                            childName = "Chest",
                            localPos = new Vector3(-0.5f, 0f, -0.6f),
                            localAngles = new Vector3(0f, 215f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            childName = "Chest",
                            localPos = new Vector3(0f, 0.5f, 0.4f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
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
                            childName = "CalfR",
localPos = new Vector3(0.02072F, 0.4715F, 0.0433F),
localAngles = new Vector3(78.09513F, 196.0571F, 16.40343F),
localScale = new Vector3(0.1F, 0.125F, 0.1F),
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
                            childName = "Chest",
                            localPos = new Vector3(-0.6f, -0.5f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "Seed",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySeed"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Head",
                            localPos = new Vector3(0f, 0f, 0.4f),
                            localAngles = new Vector3(0f, 0f, 180f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BeetleGland",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBeetleGland"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Chest",
                            localPos = new Vector3(0.8f, 0f, -0.25f),
                            localAngles = new Vector3(90f, 315f, 0f),
                            localScale = new Vector3(0.4f, 0.4f, 0.4f),
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
                            childName = "Chest",
                            localPos = new Vector3(0f, 0.5f, -0.7f),
                            localAngles = new Vector3(270f, 0f, 0f),
                            localScale = new Vector3(3f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ShockNearby",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTeslaCoil"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Chest",
                            localPos = new Vector3(0f, 0f, -0.6f),
                            localAngles = new Vector3(270f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion rob i love u
        }
    }
}