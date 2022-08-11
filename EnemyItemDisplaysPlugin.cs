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
            ;
        }

        private void ItemCatalog_Init(On.RoR2.ItemCatalog.orig_Init orig)
        {
            orig();
            #region bosses
            new BeetleQueen().Init();
            new GroveTender().Init();
            new StoneTitan().Init();
                //new Aurelionite().Init(); shared with stonetitan
            #endregion

            #region dlc1
            new Beetle().Init();
            new ClayTemplar().Init();
            new GreaterWisp().Init();
            new Imp().Init();
            new ImpOverlord().Init();
            new JellyFish().Init();
            new Lemurian().Init();
            new Wisp().Init();
            #endregion

            #region dlc2
            new Gup().Init();
                new Geep().Init();
                new Gip().Init();
            #endregion
        }
    }
}

/* for custom copy format in keb's helper
{childName},
                {localPos}, 
                {localAngles},
                {localScale})
*/