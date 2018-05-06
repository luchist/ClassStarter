using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClassStarter
{
    public class ClassStarter : Mod
    {
        public ClassStarter()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            };
        }
    }

    public class ClassStarterPlayer : ModPlayer
    {
        public static int[] TankGear = new int[]
        {
            ItemID.PaladinsShield,
            ItemID.BandofRegeneration,
            ItemID.SilverShortsword
        };

        public static int[] MeeleGear = new int[]
        {
            ItemID.SilverBroadsword,
            ItemID.CobaltShield,
            ItemID.Shackle
        };


        public static int[] RangerGear = new int[]
        {
			ItemID.SilverBow,
            ItemID.MagicQuiver,
            ItemID.WoodenArrow
        };

        public static int[] MageGear = new int[]
        {
            ItemID.AmethystStaff,
            ItemID.AmethystRobe,
            ItemID.BandofStarpower
        };

        public static int[] CommonGear = new int[]
        {
            ItemID.LesserHealingPotion,
            ItemID.LesserManaPotion,
            ItemID.RecallPotion,
            ItemID.WormholePotion
        };


        public static List<int> TankGearList;

        public static void SetUp()
        {
            TankGearList = TankGear.ToList();
        }


        public override void SetupStartInventory(IList<Item> items)
        {
            // Remove all items
            items.Clear();
            SetUp();

            for (int i = 0; i < TankGearList.Count; i++)
            {
                Item item = new Item();
                item.SetDefaults(TankGearList[i]);
                items.Add(item);
            }
        }
    }
}
