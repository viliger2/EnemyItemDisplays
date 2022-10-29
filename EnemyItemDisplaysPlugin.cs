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

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace EnemyItemDisplays
{
    [BepInPlugin("com.TheTimeSweeper.SillyEnemyItemDisplays", "SillyEnemyItemDisplays", "0.1.2")]
    public class EnemyItemDisplaysPlugin : BaseUnityPlugin
    {
        void Awake()
        {
            Log.Init(base.Logger);
            ItemDisplays.PopulateDisplays();

            On.RoR2.ItemCatalog.Init += ItemCatalog_Init;
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