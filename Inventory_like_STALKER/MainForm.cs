using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_like_STALKER
{
    public partial class MainForm : Form
    {
        private const int stW = 15, stH = 5;
        private Controller c;
        private IBag myBag, anotherBag;
        Bitmap image;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitAll();
        }

        private void butOpenInv_Click(object sender, EventArgs e)
        {
            InitAll();
        }
        
        private void boxPanel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void boxPanel_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void boxPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void boxPanel_Paint(object sender, PaintEventArgs e)
        {
            Draw();
            e.Graphics.DrawImage(image, 0, 0);
        }

        private void boxPanel_SizeChanged(object sender, EventArgs e)
        {
            ResizeDrawer();
            Draw();
            boxPanel.Refresh();
        }

        private void InitAll()
        {
            myBag = Generator.GetRandomBag(stW, stH);
            c = new Controller(myBag);
            //CreateAnothBag();
            ResizeDrawer();
            Draw();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ResizeDrawer();
            Draw();
        }

        private void Draw()
        {
            image = new Bitmap(boxPanel.Width, boxPanel.Height);
            //Drawer.Draw(ref image, myBag, anotherBag);
            Drawer.DrawBag(ref image, myBag);
        }

        private void ResizeDrawer()
        {
            //Drawer.SetParams(boxPanel.Width, boxPanel.Height, stW, stH);
        }

        private void CreateAnothBag()
        {
            anotherBag = Generator.GetRandomBag(stW, stH);
            //c.SetAnotherBag(anotherBag);
        }
    }
}
