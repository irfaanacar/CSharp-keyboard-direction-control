using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klavyeileyonkontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int xkonumu = pictureBox1.Location.X;
            int ykonumu = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.W && ykonumu > 0)
            {
                ykonumu = ykonumu - 8;//-5 olmasının sebebi nesne yukarıya çıktıkça konumunun değeri azalır bunun için en yukarda 0'dır.
            }
            if  (e.KeyCode == Keys.S && ykonumu<380)
            {
                ykonumu = ykonumu + 8;
            }
            if (e.KeyCode == Keys.A && xkonumu>0)
            {
                xkonumu = xkonumu - 8; //kaç piksellik hareket sağlayacağını belirleyebiliriz. Ben 8 yaptım.
            }
            if (e.KeyCode == Keys.D && xkonumu < 880)
            {
                xkonumu= xkonumu + 8;
            }
            pictureBox1.Location = new Point(xkonumu, ykonumu);
            if (pictureBox1.Left <= label1.Left)
            {
                label1.BackColor = Color.Crimson;
            }
            if (pictureBox1.Right >= label2.Left)
            {
                label2.BackColor = Color.Yellow;
            }
            if(pictureBox1.Top <= label3.Bottom)
            {
                label3.BackColor = Color.Blue;
            }
            if (pictureBox1.Bottom >= label4.Top)
            {
                label4.BackColor = Color.Green;
            }
    }
  }
}

