using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    class SimpleKeeper : IKeeper
    {
        private LocalThing _kept;
        private int _x;
        private int _y;

        public LocalThing Kept { get { return _kept; } }
        public int X { get { return _x; } }
        public int Y { get { return _y; } }

        public SimpleKeeper()
        {
            _x = -1;
            _y = -1;
            _kept = null;
        }

        public LocalThing Put()
        {
            return _kept;
        }

        public void Take(LocalThing thing, int x, int y)
        {
            _kept = thing;
            _x = x;
            _y = y;
        }

        public void MoveTo(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
