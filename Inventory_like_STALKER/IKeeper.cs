using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    interface IKeeper
    {
        LocalThing Kept { get; }
        int X { get; }
        int Y { get; }

        LocalThing Put();
        void Take(LocalThing thing, int x, int y);
        void MoveTo(int x, int y); // мб стоит убрать и сделать отдельно MovableKeeper
    }
}
