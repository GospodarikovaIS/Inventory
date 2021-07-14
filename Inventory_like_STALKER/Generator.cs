using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    static class Generator // класс для генерации сумок, вещей и т.п.
    {
        //private static List<IThing> things;
        private static Random rnd = new Random();

        public static IBag GetRandomBag(int w, int h)
        {
            IBag newBag = new Bag(w, h);
            GetRandomLoot(ref newBag);

            return newBag;
        }

        public static void GetRandomLoot(ref IBag bag)
        {
            int num = rnd.Next(2,11);
            for (int i = 0; i < num; i++)
            {
                IThing th = GetRandomThing();
                PutOnFirstPlace(th, ref bag);
            }
        }

        public static IThing GetRandomThing()
        {
            // 1stly create rock
            IThing rndThing = new SimpleThing("Mysterious rock", "unusing item", 2.5, 100);
            return rndThing;
        }

        public static void PutOnFirstPlace(IThing thing, ref IBag bag)
        {
            int x = -1, y = -1;
            byte rot = 0;

            for (; rot < 4; rot++)
            {
                for (int i = 0; i < bag.Height; i++)
                {
                    for (int j = 0; j < bag.Width; j++)
                    {
                        if (bag.CanPutThing(new LocalThing(thing, j, i, rot)))
                        {
                            x = j;
                            y = i;
                            break;
                        }
                    }
                    if (x != -1)
                        break;
                }
                if (x != -1)
                    break;
            }

            LocalThing lthing = new LocalThing(thing, x, y, rot);
            if (x != -1)
                bag.PutThing(lthing);
                

        }
    }
}
