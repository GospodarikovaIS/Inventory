using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    class SimpleThing : IThing // реализация простенькой вещи
    {
        private string _name; // наименование
        private string _type; // тип вещи (возможно, лучше енум)
        private double _weight; // значение веса
        private int _cost; // стоимость
        private Shape _mask; // маска, содержащая форму предмета
        
        public string Name { get { return _name; } }
        public string Type { get { return _type; } }
        public double Weight { get { return _weight; } }
        public int Cost { get { return _cost; } }
        public Shape Mask { get { return _mask; } }

        // много загонных конструкторов
        public SimpleThing()
        {
            SetName("");
            SetType("");
            SetWeight(0);
            SetCost(0);
            SetShape(new Shape());
        }

        public SimpleThing(string name, string type, double weight, int cost)
        {
            SetName(name);
            SetType(type);
            SetWeight(weight);
            SetCost(cost);
            _mask = new Shape();
        }

        public SimpleThing(string name, string type, double weight, int cost, Shape mask)
        {
            SetName(name);
            SetType(type);
            SetWeight(weight);
            SetCost(cost);
            SetShape(mask);
        }

        public SimpleThing(string name, string type, double weight, int cost, bool[][] mask)
        {
            SetName(name);
            SetType(type);
            SetWeight(weight);
            SetCost(cost);
            SetShape(mask);
        }

        // сеттеры приватного характера
        private void SetName(string name)
        { _name = name; }
        private void SetType(string type)
        { _type = type; }
        private void SetWeight(double weight)
        { _weight = weight; }
        private void SetCost(int cost)
        { _cost = cost; }
        private void SetShape(Shape mask)
        { _mask = mask; }
        private void SetShape(bool[][] mask)
        { _mask = new Shape(mask); }
    }
}
