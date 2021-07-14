using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    class LocalThing // вещь на позиции
    {
        private int _loc_x; // координаты в интвентаре
        private int _loc_y;
        private byte _rot; // угол поворота (1,2,3 или 4)
        private IThing _thing; // сама вещь

        public int Loc_X { get { return _loc_x; } }
        public int Loc_Y { get { return _loc_y; } }
        public byte Rot { get { return _rot; } }
        public IThing Thing { get { return _thing; } }

        public LocalThing(IThing thing, int loc_x, int loc_y, byte rot) // конструктор - сразу загонный, потому что все эти вещи необходимы для помещения вещи в сумку
        {
            _thing = thing;
            SetRot(rot);
            SetLoc(loc_x, loc_y);
        }

        public void SetRot(byte rot) // изменение угла поворота
        { _rot = rot; }
        public void SetLoc(int loc_x, int loc_y) // перемещение по координате
        { _loc_x = loc_x; _loc_y = loc_y; }
    }
}
