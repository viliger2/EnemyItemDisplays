﻿using RoR2;
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.Text;
using System.IO;
using static RoR2.HoverVehicleMotor;

namespace EnemyItemDisplays
{
    public abstract class ItemDisplaysBase
    {
        protected abstract string bodyName { get; }

        protected virtual bool generateDisplays => false;
        protected virtual Dictionary<string, string> NewChildLocatorEntries => null;

        protected abstract void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules);
        protected virtual void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> itemList, List<ItemDisplayRuleSet.NamedRuleGroup> equipmentList) { }

        protected CharacterModel bodyCharacterModel { get; private set; }

        public virtual ItemDisplaysBase Init()
        {
            bodyCharacterModel = BodyCatalog.FindBodyPrefab(bodyName).GetComponentInChildren<CharacterModel>();
            SetItemDisplays();
            if(NewChildLocatorEntries != null)
            {
                AddNewChildLocatorEntries();
            }

            return this;
        }

        private void SetItemDisplays()
        {
            ItemDisplayRuleSet characterItemDisplayRuleSet = bodyCharacterModel.itemDisplayRuleSet;
            List<ItemDisplayRuleSet.KeyAssetRuleGroup> newItemDisplayRules = new List<ItemDisplayRuleSet.KeyAssetRuleGroup>();

            //grab rob's old displays - not gonna waste time doing all that again
            LegacyConvertRules(characterItemDisplayRuleSet);

            //grab pre-existing displays (namely elite displays) and rob's displays from above
            RecoverExistingItemDisplays(characterItemDisplayRuleSet, newItemDisplayRules);

            //set new display rules here
            SetItemDisplayRules(newItemDisplayRules);

            if (generateDisplays)
            {
                ItemDisplayCheck.PrintUnused(newItemDisplayRules, bodyName);
            }

            bodyCharacterModel.itemDisplayRuleSet.keyAssetRuleGroups = newItemDisplayRules.ToArray();

            Record(newItemDisplayRules);

            JSONNode node = new JSONObject();
            JSONNode keyAssetRules = node["keyAssetRules"].AsArray;
            foreach (var keyAssetRuleGroups in newItemDisplayRules)
            {
                if (!ItemDisplays.KeyAssetDisplayPrefabsDictionary.TryGetValue(keyAssetRuleGroups.keyAsset.name, out _))
                {
                    continue;
                }
                var newArray = new JSONArray();
                newArray.SerializeKARG(keyAssetRuleGroups);
                keyAssetRules.Add(newArray);
            }

            JSONNode additionalChildren = node["additionalChildren"].AsArray;
            if (NewChildLocatorEntries != null)
            {
                foreach (var additionalChild in NewChildLocatorEntries)
                {
                    JSONArray child = new JSONArray()
                {
                    additionalChild.Key,
                    additionalChild.Value
                };
                    additionalChildren.Add(child);
                }
            }

            File.WriteAllText($"Assets/{bodyName}.json", node.ToString(1), Encoding.UTF8);

        }

        private int LegacyConvertRules(ItemDisplayRuleSet characterItemDisplayRuleSet)
        {
            List<ItemDisplayRuleSet.NamedRuleGroup> itemRules = new List<ItemDisplayRuleSet.NamedRuleGroup>();
            List<ItemDisplayRuleSet.NamedRuleGroup> equipmentRules = new List<ItemDisplayRuleSet.NamedRuleGroup>();

            SetLegacyItemDisplays(itemRules, equipmentRules);

            if (itemRules.Count != 0)
            {
                characterItemDisplayRuleSet.namedItemRuleGroups = itemRules.ToArray();
            }
            if (equipmentRules.Count != 0)
            {
                characterItemDisplayRuleSet.namedEquipmentRuleGroups = equipmentRules.ToArray();
            }

            if (itemRules.Count == 0 && equipmentRules.Count == 0)
                return 0;

            characterItemDisplayRuleSet.UpdgradeToAssetKeying();
            return equipmentRules.Count;
        }

        private void RecoverExistingItemDisplays(ItemDisplayRuleSet characterItemDisplayRuleSet, List<ItemDisplayRuleSet.KeyAssetRuleGroup> newItemDisplayRules)
        {
            for (int i = 0; i < characterItemDisplayRuleSet.keyAssetRuleGroups.Length; i++)
            {
                ItemDisplayRuleSet.KeyAssetRuleGroup group = characterItemDisplayRuleSet.keyAssetRuleGroups[i];
                if (group.displayRuleGroup.rules == null)
                {
                    Log.Warning($"{bodyCharacterModel.name}: keyasset {group.keyAsset.name} null");
                    continue;
                }

                newItemDisplayRules.Add(group);
            }
        }

        private static void Record(List<ItemDisplayRuleSet.KeyAssetRuleGroup> newItemDisplayRules)
        {
            int newItemCount = 0;
            foreach (ItemDisplayRuleSet.KeyAssetRuleGroup item in newItemDisplayRules)
            {
                if (item.keyAsset is ItemDef)
                    newItemCount++;
            }

            BookKeep.TotalAddedDisplays += newItemCount;
            BookKeep.TotalPotentialDisplays += BookKeep.TotalVanillaItems;
            BookKeep.MonstersAdded += 1;
        }

        private void AddNewChildLocatorEntries()
        {
            ChildLocator childLocator = bodyCharacterModel.GetComponent<ChildLocator>();

            List<ChildLocator.NameTransformPair> newPairs = new List<ChildLocator.NameTransformPair>();

            foreach (KeyValuePair<string, string> newEntry in NewChildLocatorEntries)
            {
                Transform newTransform = bodyCharacterModel.transform.Find(newEntry.Value);
                if(newTransform == null)
                {
                    Log.Warning($"Error adding ChildLocator entry: Couldn't find transform for {newEntry.Value}");
                }
                newPairs.Add(new ChildLocator.NameTransformPair
                {
                    name = newEntry.Key,
                    transform = newTransform
                });
            }
            childLocator.transformPairs = childLocator.transformPairs.Concat(newPairs).ToArray();
        }
    }
}