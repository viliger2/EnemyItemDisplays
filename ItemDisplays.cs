﻿using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays
{
    internal static class ItemDisplays
    {
        public static Dictionary<string, GameObject> itemDisplayPrefabs = new Dictionary<string, GameObject>();
        public static Dictionary<Object, List<string>> KeyAssetDisplayPrefabs = new Dictionary<Object, List<string>>();

        public static Dictionary<string, List<GameObject>> KeyAssetDisplayPrefabsDictionary = new Dictionary<string, List<GameObject>>();

        public static void PopulateDisplays()
        {
            //PopulateFromBody("CommandoBody");
            PopulateDisplaysFromBody("MercBody");
        }

        private static void PopulateDisplaysFromBody(string bodyName)
        {
            ItemDisplayRuleSet itemDisplayRuleSet = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/CharacterBodies/" + bodyName)?.GetComponent<ModelLocator>()?.modelTransform.GetComponent<CharacterModel>()?.itemDisplayRuleSet;
            if (itemDisplayRuleSet == null)
            {
                Log.Error("couldn't load ItemDisplayRuleSet from " + bodyName + ". Check if name was entered correctly");
                return;
            }

            ItemDisplayRuleSet.KeyAssetRuleGroup[] itemRuleGroups = itemDisplayRuleSet.keyAssetRuleGroups;

            for (int i = 0; i < itemRuleGroups.Length; i++)
            {
                ItemDisplayRule[] rules = itemRuleGroups[i].displayRuleGroup.rules;

                if (!KeyAssetDisplayPrefabsDictionary.ContainsKey(itemRuleGroups[i].keyAsset.name))
                {
                    List<GameObject> displayPrefabs = new List<GameObject>();
                    for(int j = 0; j < rules.Length; j++)
                    {
                        if (rules[j].followerPrefab)
                        {
                            displayPrefabs.Add(rules[j].followerPrefab);
                        } else
                        {
                            displayPrefabs.Add(rules[j].followerPrefabAddress.LoadAssetAsync<GameObject>().WaitForCompletion());
                        }
                    }
                    KeyAssetDisplayPrefabsDictionary.Add(itemRuleGroups[i].keyAsset.name, displayPrefabs);
                }


                bool alreadySeenThisKey = KeyAssetDisplayPrefabs.ContainsKey(itemRuleGroups[i].keyAsset);

                for (int j = 0; j < rules.Length; j++)
                {
                    GameObject followerPrefab = rules[j].followerPrefab;
                    if (followerPrefab)
                    {
                        string key = followerPrefab.name?.ToLowerInvariant();
                        if (!itemDisplayPrefabs.ContainsKey(key))
                        {



                            itemDisplayPrefabs[key] = followerPrefab;
                        }

                        if (!alreadySeenThisKey)
                        {
                            if (!KeyAssetDisplayPrefabs.ContainsKey(itemRuleGroups[i].keyAsset))
                            {
                                KeyAssetDisplayPrefabs[itemRuleGroups[i].keyAsset] = new List<string>();
                            }
                            KeyAssetDisplayPrefabs[itemRuleGroups[i].keyAsset].Add(followerPrefab.name);
                        }
                    }
                }
            }
        }

        public static GameObject LoadDisplayNew(string name, int index = 0)
        {
            if (!KeyAssetDisplayPrefabsDictionary.ContainsKey(name))
            {
                return null;
            }

            var list = KeyAssetDisplayPrefabsDictionary[name];
            if(list.Count < index)
            {
                return null;
            }

            return list[index];
        }

        public static GameObject LoadDisplay(string name)
        {
            if (itemDisplayPrefabs.ContainsKey(name.ToLowerInvariant()))
            {
                if (itemDisplayPrefabs[name.ToLowerInvariant()])
                {

                    GameObject display = itemDisplayPrefabs[name.ToLowerInvariant()];

                    return display;
                }
            }
            Log.Error("item display " + name + " returned null");
            return null;
        }

        #region add rule helpers

        private static Object GetKeyAssetFromString(string itemName)
        {
            Object itemDef = RoR2.LegacyResourcesAPI.Load<ItemDef>("ItemDefs/" + itemName);

            if (itemDef == null)
            {
                itemDef = RoR2.LegacyResourcesAPI.Load<EquipmentDef>("EquipmentDefs/" + itemName);
            }

            if (itemDef == null)
            {
                Log.Error("Could not load keyasset for " + itemName);
            }

            return itemDef;
        }

        public static ItemDisplayRuleSet.KeyAssetRuleGroup CreateGenericDisplayRuleGroup(Object keyAsset_, GameObject itemPrefab, string childName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            ItemDisplayRule singleRule = CreateDisplayRule(itemPrefab, childName, position, rotation, scale);
            return CreateDisplayRuleGroupWithRules(keyAsset_, singleRule);
        }

        public static ItemDisplayRule CreateDisplayRule(string prefabName, string childName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            return CreateDisplayRule(LoadDisplay(prefabName), childName, position, rotation, scale);
        }
        public static ItemDisplayRule CreateDisplayRule(GameObject itemPrefab, string childName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            return new ItemDisplayRule
            {
                ruleType = ItemDisplayRuleType.ParentedPrefab,
                childName = childName,
                followerPrefab = itemPrefab,
                limbMask = LimbFlags.None,
                localPos = position,
                localAngles = rotation,
                localScale = scale
            };
        }

        public static ItemDisplayRule CreateLimbMaskDisplayRule(LimbFlags limb)
        {
            return new ItemDisplayRule
            {
                ruleType = ItemDisplayRuleType.LimbMask,
                limbMask = limb,
                childName = "",
                followerPrefab = null
                //localPos = Vector3.zero,
                //localAngles = Vector3.zero,
                //localScale = Vector3.zero
            };
        }

        public static ItemDisplayRuleSet.KeyAssetRuleGroup CreateDisplayRuleGroupWithRules(string itemName, params ItemDisplayRule[] rules)
        {
            return CreateDisplayRuleGroupWithRules(GetKeyAssetFromString(itemName), rules);
        }
        public static ItemDisplayRuleSet.KeyAssetRuleGroup CreateDisplayRuleGroupWithRules(Object keyAsset_, params ItemDisplayRule[] rules)
        {
            return new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = keyAsset_,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = rules
                }
            };
        }

        public static ItemDisplayRuleSet.KeyAssetRuleGroup CreateGenericDisplayRule(string itemName, string prefabName, string childName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            return CreateGenericDisplayRule(GetKeyAssetFromString(itemName), prefabName, childName, position, rotation, scale);
        }
        public static ItemDisplayRuleSet.KeyAssetRuleGroup CreateGenericDisplayRule(Object itemDef, string prefabName, string childName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            return CreateGenericDisplayRule(itemDef, LoadDisplay(prefabName), childName, position, rotation, scale);
        }
        public static ItemDisplayRuleSet.KeyAssetRuleGroup CreateGenericDisplayRule(string itemName, GameObject displayPrefab, string childName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            return CreateGenericDisplayRule(GetKeyAssetFromString(itemName), displayPrefab, childName, position, rotation, scale);
        }
        public static ItemDisplayRuleSet.KeyAssetRuleGroup CreateGenericDisplayRule(Object itemDef, GameObject displayPrefab, string childName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            if (displayPrefab == null)
            {
                Log.Warning("could not find display prefab for " + itemDef);
            }

            return new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = itemDef,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            childName = childName,
                            followerPrefab = displayPrefab,
                            followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(""),
                            limbMask = LimbFlags.None,
                            localPos = position,
                            localAngles = rotation,
                            localScale = scale
                        }
                    }
                }
            };
        }
        #endregion add rule helpers
    }
}