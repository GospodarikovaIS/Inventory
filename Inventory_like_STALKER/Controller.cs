using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    class Controller // класс, контроллирующий всё это безобразие
    {
        private IBag _bag; // наличествующая в мире сумка
        //private IBag _anotherBag; // открытый контейнер

        private SimpleKeeper _hand; // вещь на данный момент в руке (с её старыми координатами)
        private SimpleKeeper _selected; // выбранная вещь (пикнутая в сумке)
        private SimpleKeeper _highlighted; // вещь под курсором

        public Controller(IBag bag) // пустой конструктор, принимает только ссылку на сумку игрока
        {
            _bag = bag;
            //_anotherBag = null;
            _hand = new SimpleKeeper();
            _selected = new SimpleKeeper();
            _highlighted = new SimpleKeeper();
            SetEveryHand(-1, -1);
        }

        //public void SetAnotherBag(IBag bag) // записать ссылку на открытый сейчас контейнер
        //{
        //_anotherBag = bag;
        //}

        public void SelectThis(int x, int y, LocalThing thing)
        {

        }

        private void SelectEvery()
        {

        }

        public void HighlightThis(int x, int y, LocalThing thing)
        {

        }

        public void SetHand(int x, int y, LocalThing thing) // переставить руку в координаты
        {
            //if (x < 0 || y < 0) // если координаты некорректны, рука сбрасывается
            //{
            //    SetEveryHand(-1, -1);
            //    if (_hand != null)
            //    {
            //        // обработать то, что  в руке, куда-то (пока просто будет теряться)
            //        _hand = null;
            //    }

            //    return;
            //}

            //SetEveryHand(x, y);
        }

        private void SetEveryHand(int x, int y) // переставить руку в координаты (без проверок корректности)
        {
            //_handX = x;
            //_handY = y;
        }
    }
}
