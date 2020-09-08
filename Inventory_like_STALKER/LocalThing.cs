using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    class LocalThing
    {
        private int _loc_x;
        private int _loc_y;
        private byte _rot;
        private IThing _thing;

        public int Loc_X { get { return _loc_x; } }
        public int Loc_Y { get { return _loc_y; } }
        public byte Rot { get { return _rot; } }
        public IThing Thing { get { return _thing; } }

        public LocalThing(IThing thing, int loc_x, int loc_y, byte rot)
        {
            _thing = thing;
            SetRot(rot);
            SetLoc(loc_x, loc_y);
        }

        public void SetRot(byte rot)
        { _rot = rot; }
        public void SetLoc(int loc_x, int loc_y)
        { _loc_x = loc_x; _loc_y = loc_y; }
    }
}
