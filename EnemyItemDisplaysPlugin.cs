using BepInEx;
using BepInEx.Configuration;
using System;
using System.Linq;
using EnemyItemDisplays.Monsters;
using EnemyItemDisplays.Monsters.Bosses;
using EnemyItemDisplays.Monsters.DLC0;
using EnemyItemDisplays.Monsters.DLC1;
using System.Security;
using System.Security.Permissions;
using UnityEngine.AddressableAssets;
using RoR2;
using SimpleJSON;
using System.IO;
using System.Text;
using static RoR2.ItemDisplayRuleSet;
using System.Collections.Generic;
using UnityEngine;

[assembly: HG.Reflection.SearchableAttribute.OptInAttribute]

namespace EnemyItemDisplays
{
    [BepInPlugin("com.TheTimeSweeper.SillyEnemyItemDisplays", "SillyEnemyItemDisplays", "0.1.2")]
    public class EnemyItemDisplaysPlugin : BaseUnityPlugin
    {
        public static Dictionary<string, string> IDRSFiles = new Dictionary<string, string>();

        void Awake()
        {
            Log.Init(Logger);
            //On.RoR2.ItemCatalog.Init += ItemCatalog_Init;

            var rulesPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(base.Info.Location), "Rules");
            var allFiles = Directory.GetFiles(rulesPath, "*.json", SearchOption.AllDirectories);

            foreach(var file in allFiles)
            {
                IDRSFiles.Add(System.IO.Path.GetFileNameWithoutExtension(file), file);
            }
        }

        [SystemInitializer(new Type[] { typeof(BodyCatalog), typeof(ItemCatalog)})]
        private static void Init()
        {
            ItemDisplays.PopulateDisplays();

            foreach (var body in BodyCatalog.allBodyPrefabs)
            {
                if (!IDRSFiles.TryGetValue(body.name, out var filePath))
                {
                    continue;
                }

                var jsonNode = SimpleJSON.JSON.Parse(File.ReadAllText(filePath));

                var modelLocator = body.GetComponent<ModelLocator>();
                if (!modelLocator) continue;

                if (!modelLocator.modelTransform) continue;

                var characterModel = modelLocator.modelTransform.GetComponent<CharacterModel>();
                if (!characterModel) continue;

                var bodyIDRS = characterModel.itemDisplayRuleSet;
                if (!bodyIDRS) continue;

                var childLocator = characterModel.GetComponent<ChildLocator>();
                if (!childLocator) continue;

                var additionalChildren = jsonNode["additionalChildren"].AsArray.DeserializeAdditionalChildren();
                foreach (var child in additionalChildren)
                {
                    Transform newTransform = characterModel.transform.Find(child.Path);
                    if (!newTransform)
                    {
                        Log.Warning($"Error adding ChildLocator entry: Couldn't find transform for {child.Path}");
                        continue;
                    }

                    HG.ArrayUtils.ArrayAppend(ref childLocator.transformPairs, new ChildLocator.NameTransformPair
                    {
                        name = child.Name,
                        transform = newTransform
                    });
                }

                foreach (JSONNode item in jsonNode["keyAssetRules"].AsArray)
                {
                    var karg = item.AsArray.DeserializeKARG();
                    if(bodyIDRS.keyAssetRuleGroups.Where(keyAsset => keyAsset.keyAsset == karg.keyAsset).Any())
                    {
                        Log.Info($"Skipping IDR for object {karg.keyAsset} ({karg.keyAssetAddress}) for body {body.name} as body's IDRS already has an entry for it.");
                        continue;
                    }
                    HG.ArrayUtils.ArrayAppend(ref bodyIDRS.keyAssetRuleGroups, karg);
                }
            }
        }

        private void ItemCatalog_Init(On.RoR2.ItemCatalog.orig_Init orig)
        {
            orig();

            ItemDisplaysBase[] enemyItemDisplays = new ItemDisplaysBase[]
            {
                #region bosses
                new BeetleQueen(),
                new GroveTender(),
                new ImpOverlord(),
                new StoneTitan(),
                    //new Aurelionite(), shared with stonetitan
                new WanderingVagrant(),
                new ClayDuneStrider(),
                #endregion

                #region dlc0
                new Beetle(),
                new BeetleGuard(),
                new ClayTemplar(),
                new ElderLemurian(),
                new GreaterWisp(),
                new Imp(),
                new JellyFish(),
                new Lemurian(),
                new Wisp(),
                #endregion

                #region dlc1
                new Gup(),
                    new Geep(),
                    new Gip(),
                #endregion
            };

            foreach (ItemDisplaysBase enemy in enemyItemDisplays)
            {
                enemy.Init();
            }

            BookKeep.Print();
        }
    }
}

/* for custom copy format in keb's helper
{childName},
                {localPos}, 
                {localAngles},
                {localScale})
*/