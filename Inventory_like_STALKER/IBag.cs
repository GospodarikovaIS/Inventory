using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    interface IBag
    {
        int Width { get; }
        int Height { get; }
        List<LocalThing> Stuff { get; }
        List<LocalThing[]> Field { get; }
        
        //
        bool PutThing(LocalThing newThing);
        bool CanPutThing(LocalThing newThing);
        LocalThing TouchThing(int loc_x, int loc_y);
        LocalThing TakeThing(int loc_x, int loc_y);
    }
}
