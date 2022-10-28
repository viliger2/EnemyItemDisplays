using RoR2;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace EnemyItemDisplays
{
    public abstract class ItemDisplaysBase
    {
        protected abstract string bodyName { get; }
        protected CharacterModel bodyCharacterModel { get; private set; }

        public virtual ItemDisplaysBase Init()
        {
            bodyCharacterModel = BodyCatalog.FindBodyPrefab(bodyName).GetComponentInChildren<CharacterModel>();
            SetItemDisplays();

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

            bodyCharacterModel.itemDisplayRuleSet.keyAssetRuleGroups = newItemDisplayRules.ToArray();

            Record(newItemDisplayRules);
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

        protected abstract void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules);

        protected virtual void SetLegacyItemDisplays(List<ItemDisplayRuleSet.NamedRuleGroup> itemList, List<ItemDisplayRuleSet.NamedRuleGroup> equipmentList) { }
    }
}