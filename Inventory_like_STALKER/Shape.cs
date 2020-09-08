using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    class Shape
    {
        private bool[][] _area;

        public bool[][] Area { get { return _area; } }

        public Shape()
        {
            SetSimpleShape();
        }

        private void SetSimpleShape()
        {
            _area = new bool[1][];
            _area[0] = new bool[1];
            _area[0][0] = true;
        }

        public Shape(bool[][] area)
        {
            SetShape(area);
        }

        private void SetShape(bool[][] newArea)
        {
            _area = newArea;
            //стоит написать метод, проверяющий корректность маски
        }
    }
}
