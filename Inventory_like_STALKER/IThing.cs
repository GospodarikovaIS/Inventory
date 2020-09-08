using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_like_STALKER
{
    interface IThing
    {
        string Name { get; }
        string Type { get; }
        double Weight { get; }
        int Cost { get; }
        Shape Mask { get; }
        //


    }
}
