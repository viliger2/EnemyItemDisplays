using System.Security;
using System.Security.Permissions;
using RoR2.ContentManagement;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace EnemyItemDisplays
{
    public class BookKeep
    {
        public static int TotalAddedDisplays = 0;
        public static int TotalPotentialDisplays = 0;
        public static int MonstersAdded = 0;

        private static int? totalVanillaItems = null;
        public static int TotalVanillaItems {
            get
            {
                if (totalVanillaItems == null)
                {
                    totalVanillaItems = 0;
                    for (int i = 0; i < ContentManager.allLoadedContentPacks.Length; i++)
                    {
                        ReadOnlyContentPack contentPack = ContentManager.allLoadedContentPacks[i];
                        if (contentPack.identifier == "RoR2.BaseContent" || contentPack.identifier == "RoR2.DLC1")
                        {
                            totalVanillaItems += contentPack.itemDefs.Length + contentPack.equipmentDefs.Length;
                        }
                    }
                }

                return totalVanillaItems.Value;
            }
        }

        public static void Print()
        {
            Log.Message(TotalVanillaItems);
            Log.Message($"Added item displays to {MonstersAdded} enemies. Total enemy item displays: {TotalAddedDisplays}/{TotalPotentialDisplays} (including preexisting)");
        }
    }
}

/* for custom copy format in keb's helper
{childName},
                {localPos}, 
                {localAngles},
                {localScale})
*/