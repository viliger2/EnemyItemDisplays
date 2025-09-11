using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.Bosses
{
    public class ImpOverlord : ItemDisplaysBase
    {
        protected override string bodyName => "ImpBossBody";

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
                            childName = "Neck",
                            localPos = new Vector3(0f, -1.5f, -1.3f),
                            localAngles = new Vector3(0f, 180f, 0f),
                            localScale = new Vector3(2.5f, 5f, 5f),
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
                            localPos = new Vector3(0.1f, 0.5f, 0f),
                            localAngles = new Vector3(0f, 0f, 345f),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDiamond"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "HandR",
                            localPos = new Vector3(-0.1f, 0.5f, 0f),
                            localAngles = new Vector3(0f, 0f, 15f),
                            localScale = new Vector3(0.75f, 0.75f, 0.75f),
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
                            localScale = new Vector3(3f, 3f, 3f),
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
                            childName = "Neck",
                            localPos = new Vector3(0f, 0f, 0.8f),
                            localAngles = new Vector3(0f, 0f, 0f),
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
                            childName = "Neck",
                            localPos = new Vector3(0f, -3f, 0.8f),
                            localAngles = new Vector3(270f, 0f, 0f),
                            localScale = new Vector3(5f, 5f, 5f),
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
                            childName = "Neck",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(0f, 180f, 0f),
                            localScale = new Vector3(5f, 5f, 5f),
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
                            childName = "Neck",
                            localPos = new Vector3(0.5f, -1.5f, 0.8f),
                            localAngles = new Vector3(0f, 0f, 90f),
                            localScale = new Vector3(4f, 4f, 4f),
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
                            childName = "Neck",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "BleedOnHitAndExplode",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBleedOnHitAndExplode"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Neck",
                            localPos = new Vector3(-1f, -2f, 1f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.5f, 0.5f, 0.5f),
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
                            childName = "Neck",
                            localPos = new Vector3(0f, -0.5f, -0.5f),
                            localAngles = new Vector3(315f, 0f, 0f),
                            localScale = new Vector3(3f, 3f, 3f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion
        }
    }
}