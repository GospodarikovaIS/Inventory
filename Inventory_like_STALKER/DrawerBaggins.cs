using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inventory_like_STALKER
{
    static class DrawerBaggins
    {
        private static Color backCol = Color.LightGray, //Color.LightSlateGray,
            frameCol = Color.DarkSlateGray,
            paleCol = Color.Linen,
            lineCol = Color.LightGoldenrodYellow;

        public static int margin = 15, line = 2, side = 40;


        public static void DrawBag(ref Bitmap image, IBag bag)
        {
            int widthImage = image.Width;
            int cellWidthCount = bag.Width;
            int cellWidthBag = side * bag.Width;

            int heightImage = image.Height;
            int cellHeightCount = bag.Height;
            int cellHeightBag = side * bag.Height;

            Graphics g = Graphics.FromImage(image);
            g.Clear(backCol);
            int k = margin / 2 - 1;
            g.DrawRectangle(new Pen(frameCol, k), 0, 0, cellWidthBag + margin, cellHeightBag + margin);
            g.FillRectangle(new SolidBrush(frameCol), margin / 2, margin / 2, cellWidthBag + margin / 2, cellHeightBag + margin / 2);
            
            Pen p = new Pen(lineCol, line);
            g.DrawRectangle(p, margin / 2, margin / 2, cellWidthBag + margin / 2, cellHeightBag + margin / 2);

            for (int j = 0; j <= cellHeightCount; j++)
            {
                g.DrawLine(p, new Point(margin / 2 - line / 2, margin / 2 + j * side - line / 2), new Point(margin / 2 + cellWidthCount, margin / 2 + j * side + line / 2));
                for (int i = 0; i <= cellWidthCount; i++)
                {
                    g.DrawLine(p, new Point(margin / 2 + i * side - line / 2, margin / 2 - line / 2), new Point(margin / 2 + i * side + line / 2, margin / 2 + cellHeightBag + line / 2));
                }
            }
        }
    }
}
