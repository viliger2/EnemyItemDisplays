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
    [BepInPlugin("com.TheTimeSweeper.SillyEnemyItemDisplays", "SillyEnemyItemDisplays", "0.1.0")]
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
                #endregion

                #region dlc1
                new Beetle(),
                new ClayTemplar(),
                new ElderLemurian(),
                new GreaterWisp(),
                new Imp(),
                new JellyFish(),
                new Lemurian(),
                new Wisp(),
                #endregion

                #region dlc2
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