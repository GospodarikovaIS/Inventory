using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    class Bag : IBag
    {
        private int _w;
        private int _h;
        private List<LocalThing> _stuff;
        private List<LocalThing[]> _field;

        public int Width { get { return _w; } }
        public int Height { get { return _h; } }
        public List<LocalThing> Stuff { get { return _stuff; } }
        public List<LocalThing[]> Field { get { return _field; } }
        
        //
        public Bag(int w, int h)
        {
            if (w <= 0 || h <= 0)
            { w = 1; h = 1; }

            _w = w;
            _h = h;

            _field = new List<LocalThing[]>(_h);
            for (int i = 0; i < _field.Count; i++)
            {
                _field[i] = new LocalThing[w];
            }
        }


        public bool PutThing(LocalThing newThing)
        {
            return false;
        }

        public bool CanPutThing(LocalThing newThing)
        {
            bool[][] shape = newThing.Thing.Mask.Area;
            byte rot = newThing.Rot;
            int loc_x = newThing.Loc_X, loc_y = newThing.Loc_Y;

            if (!(shape.Length > 0 && shape[0].Length > 0)) // форма некорректна
                return false;

            shape = Rotate(shape, rot); // поворот
            int h = shape.Length, w = shape[0].Length; // параметры формы
            bool fail = false;

            for (int i = 0; i < h; i++) // проход по форме вещи
            {
                for (int j = 0; j < w; j++)
                {
                    // определение перекрытия с другими вещами
                    if (shape[i][j] && _field[loc_y + i][loc_x + j] != null) 
                    {
                        fail = true;
                        break;
                    }
                }
                if (fail)
                    break;
            }

            return !fail;
        }

        public LocalThing TouchThing(int loc_x, int loc_y)
        {
            if (loc_x < 0 || loc_y < 0 || loc_x>=_w || loc_y>=_h) // отсеивание некорректных позиций
                return null;
            
            // поиск вещи, находящейся в указанной клетке
            LocalThing taken = _stuff.Find(delegate (LocalThing thing)
                                    { return thing.Equals(_field[loc_y][loc_x]); });

            if (taken != null)
                return taken;
            return null;
        }

        public LocalThing TakeThing(int loc_x, int loc_y)
        {
            LocalThing taken = TouchThing(loc_x, loc_y);
            if (taken == null)
                return null;

            DropThing(taken); // удаление вещи из сумки
            return taken;
            }

        private bool[][] Rotate(bool[][] shape, byte rot) // поворот формы в соотвествии с rot
        {
            if (shape.Length > 1 && shape[0].Length > 1)
            {
                switch (rot)
                {
                    case 0:
                        break;
                    case 1:
                        shape = Rotate90(shape);
                        break;
                    case 2:
                        shape = Rotate90(Rotate90(shape));
                        break;
                    case 3:
                        shape = Rotate90(Rotate90(Rotate90(shape)));
                        break;
                    default:
                        break;
                }
            }
            return shape;
        }

        private bool[][] Rotate90(bool[][] shape) //поворот любой формы один раз против часовой
        {
            int new_W = shape.Length, new_H = shape[0].Length;
            bool[][] newShape = new bool[new_H][];
            for (int i = 0; i < new_H; i++)
            {
                newShape[i] = new bool[new_W];
                for (int j = 0; j < new_W; j++)
                    newShape[i][j] = shape[new_W - j][i];
            }
            return shape;
        }

        private void DropThing(LocalThing thing) // удаление вещи с поля и из списка
        {
            for (int i = 0; i < _field.Count; i++)
                for (int j = 0; j < _field[0].Length; j++)
                    if (_field[i][j].Equals(thing))
                        _field[i][j] = null;
                
            _stuff.Remove(thing);
        }
    }
}
