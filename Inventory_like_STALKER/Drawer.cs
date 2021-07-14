using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Inventory_like_STALKER
{
    static class Drawer // отрисовщик
    {
        private static Color backCol = Color.LightGray,//Color.LightSlateGray,
            frameCol = Color.DarkSlateGray,
            //paleCol = Color.Linen,
            lineCol = Color.LightGoldenrodYellow;

        //public static int invX, invY, invW, invH; // координаты инвентарной сумки
        //public static int chestX, chestY, chestW, chestH; // координаты контейнера
        //public static int prevX, prevY, prevW, prevH; //
        //public static int allX, allY, allW, allH; // координаты всего имеющегося пространства для отрисовки
        public static int margin = 16, line = 2, side = 40;

        //public static List<int> invCW, invCH; //

        /*
        public static void Draw(ref Bitmap image, IBag bag, IBag anBag)
        {
            Graphics g = Graphics.FromImage(image);
            g.Clear(backCol);
            int k = margin / 2 - 1;
            g.DrawRectangle(new Pen(frameCol, k),
                allX - margin / 2, allY - margin / 2,
                allW + margin, allH + margin);
            g.FillRectangle(new SolidBrush(frameCol), allX, allY, allW, allH);

            if (bag == null || bag.Height == 0 || bag.Width == 0)
                return;

            Pen p = new Pen(lineCol, line);
            g.DrawRectangle(p, invX, invY, invW, invH);

            if (invCW == null || invCW.Count == 0)
                MakeLines(bag, anBag);

            for (int i = 1; i < bag.Width-1; i++)
            {
                g.DrawLine(p, invCW[i], invY, invCW[i], invY + invH);
            }

            int hc = invH / bag.Height;
            int hd = invH % bag.Height;
            int hxd = 0;
            for (int i = 1; i < bag.Height; i++)
            {
                int cd = hd > 0 ? hc + 1 : hc;
                hd--;
                g.DrawLine(p, invX, invY + hxd + cd, invX + invW, invY + hxd + cd);
                hxd += cd;
            }


            if (anBag != null)
            {
                g.DrawRectangle(new Pen(paleCol, line), chestX, chestY, chestW, chestH);
            }
        }
        */

        public static void DrawBag(ref Bitmap image, IBag bag)
        {
            int widthImage = image.Width;
            int cellWidthCount = bag.Width;
            int cellWidthBag = side * bag.Width;

            int heightImage = image.Height;
            int cellHeightCount = bag.Height;
            int cellHeightBag = side * bag.Height;

            int allWeight = cellWidthBag + margin;
            int allHeight = cellHeightBag + margin;

            Graphics g = Graphics.FromImage(image);
            g.Clear(backCol);
            int k = margin / 2;
            g.FillRectangle(new SolidBrush(frameCol), 0, 0, allWeight, allHeight);

            Pen p = new Pen(lineCol, line);
            g.DrawRectangle(p, k, k, cellWidthBag, cellHeightBag);

            for (int j = 0; j < cellHeightCount; j++)
            {
                for (int i = 0; i < cellWidthCount; i++)
                {
                    g.DrawRectangle(p, k + side * i, k + side * j, side, side);
                }
            }
        }

        /*public static void SetParams(int bitmapW, int bitmapH, int numW, int numH)
        {
            allX = margin; allY = margin;
            allW = bitmapW-margin*2; allH = bitmapH - margin * 2;

            int w = allW / numW;
            int h = allH / (numH + numH + 2);
            int c = w > h ? h : w;

            allW = numW * c;
            allH = (numH + numH + 2) * c;
            allX = (bitmapW - margin * 2 - allW) / 2 + margin;
            allY = (bitmapH - margin * 2 - allH) / 2 + margin;

            invW = allW - line * 2;
            invH = numH * c - line * 2;
            invX = allX + line;
            invY = allY + allH - numH * c + line;

            chestW = invW;
            chestH = invH;
            chestX = allX + line;
            chestY = allY + line;

        }

        private static void MakeLines(IBag bag, IBag anBag)
        {
            invCW = new List<int>();
            invCH = new List<int>();
            invCW.Add(invX);
            invCH.Add(invY);

            int wc = invW / bag.Width;
            int wd = invW % bag.Width;
            int wxd = invX;
            for (int i = 1; i < bag.Width; i++)
            {
                int cd = wd > 0 ? wc + 1 : wc;
                wd--;
                wxd += cd;
                invCW.Add(wxd);
            }

            int hc = invH / bag.Height;
            int hd = invH % bag.Height;
            int hxd = invY;
            for (int i = 1; i < bag.Height; i++)
            {
                int cd = hd > 0 ? hc + 1 : hc;
                hd--;
                hxd += cd;
                invCH.Add(hxd);
            }
        }
        */
    }
}
