using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays.Monsters.DLC0
{
    public class JellyFish : ItemDisplaysBase
    {
        protected override string bodyName => "JellyfishBody";

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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 1.1f, 0f),
                            localAngles = new Vector3(270f, 90f, 0f),
                            localScale = new Vector3(2.8f, 3f, 3f),
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
                            childName = "Hull2",
                            localPos = new Vector3(1f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0.6f, 1.5f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(0.3f, 0.3f, 0.3f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(1.5f, 1.5f, 1.5f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(11f, 11f, 11f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0.5f, 0f),
                            localAngles = new Vector3(90f, 0f, 0f),
                            localScale = new Vector3(11f, 11f, 11f),
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
                            childName = "Hull2",
                            localPos = new Vector3(-0.3f, 0f, 0.65f),
                            localAngles = new Vector3(270f, 0f, 0f),
                            localScale = new Vector3(3f, 2f, 2f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0.7f, 0f, -0.7f),
                            localAngles = new Vector3(0f, 135f, 0f),
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
                            childName = "Hull2",
                            localPos = new Vector3(-1.25f, 0f, 0f),
                            localAngles = new Vector3(270f, 270f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0.75f, 0.75f),
                            localAngles = new Vector3(270f, 0f, 0f),
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
                            childName = "Hull2",
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
                            childName = "Hull2",
                            localPos = new Vector3(0.5f, 0f, 0.5f),
                            localAngles = new Vector3(0f, 315f, 270f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0.6f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
                            localScale = new Vector3(4f, 4f, 4f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, -1f, 0f),
                            localAngles = new Vector3(270f, 270f, 0f),
                            localScale = new Vector3(0.25f, 0.25f, 0.25f),
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
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWhip"),//Jellyfish.redWhip,
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 90f),
                            localScale = new Vector3(3f, 3f, 3f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "NovaOnLowHealth",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayJellyGuts"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Hull2",
                            localPos = new Vector3(-0.2f, 0f, -0.2f),
                            localAngles = new Vector3(315f, 0f, 0f),
                            localScale = new Vector3(1f, 1f, 1f),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            list.Add(new ItemDisplayRuleSet.NamedRuleGroup
            {
                name = "ExtraLife",
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHippo"),
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            childName = "Hull2",
                            localPos = new Vector3(-1f, 1f, 0.75f),
                            localAngles = new Vector3(0f, 315f, 0f),
                            localScale = new Vector3(2f, 2f, 2f),
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
                            childName = "Hull2",
                            localPos = new Vector3(0f, 0f, 0f),
                            localAngles = new Vector3(0f, 0f, 0f),
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