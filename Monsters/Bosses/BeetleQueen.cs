using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.Bosses
{
    public class BeetleQueen : ItemDisplaysBase
    {
        protected override string bodyName => "BeetleQueen2Body";

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {

        }

        protected override void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> list, List<ItemDisplayRuleSet.NamedRuleGroup> list2)
        {
            #region old rules
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
                            localPos = new Vector3(0f, 1.5f, -1.5f),
                            localAngles = new Vector3(0f, 180f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
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
                            childName = "Stomach",
                            localPos = new Vector3(0f, -2.5f, 5f),
                            localAngles = new Vector3(345f, 0f, 180f),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
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
                            childName = "Butt",
                            localPos = new Vector3(0.8f, -2.2f, -1.5f),
                            localAngles = new Vector3(0f, 180f, 0f),
                            localScale = new Vector3(7f, 5f, 5f),
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
                            childName = "Stomach",
                            localPos = new Vector3(3f, 0f, 1f),
                            localAngles = new Vector3(0f, 90f, 180f),
                            localScale = new Vector3(5f, 5f, 5f),
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
                            childName = "Butt",
                            localPos = new Vector3(0f, -3f, -2f),
                            localAngles = new Vector3(0f, 180f, 0f),
                            localScale = new Vector3(9f, 9f, 9f),
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
                            childName = "Stomach",
                            localPos = new Vector3(1f, -2f, 1f),
                            localAngles = new Vector3(60f, 0f, 0f),
                            localScale = new Vector3(8f, 8f, 8f),
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
                            childName = "Stomach",
                            localPos = new Vector3(-3f, -2f, 0f),
                            localAngles = new Vector3(0f, 180f, 90f),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
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
                            childName = "Stomach",
                            localPos = new Vector3(0f, -3f, 1f),
                            localAngles = new Vector3(315f, 0f, 180f),
                            localScale = new Vector3(8f, 8f, 8f),
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
                            childName = "Stomach",
                            localPos = new Vector3(0f, -2f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion
        }
    }
}