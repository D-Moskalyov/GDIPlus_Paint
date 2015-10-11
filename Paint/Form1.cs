using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;
        Brush brush;
        List<Point> mouseClicks = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            brush = new SolidBrush(Color.Black);

            //radioButton5.Checked = false;
            //radioButton6.Checked = false;
            //radioButton7.Checked = false;
            //radioButton8.Checked = false;
            //radioButton9.Checked = false;
            //radioButton8.Checked = false;
            panel5.Visible = false;
            label1.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            pen.Color = Color.White;
            ((SolidBrush)brush).Color = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Black;
            pen.Color = Color.Black;
            ((SolidBrush)brush).Color = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
            pen.Color = Color.Green;
            ((SolidBrush)brush).Color = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
            pen.Color = Color.Yellow;
            ((SolidBrush)brush).Color = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue;
            pen.Color = Color.Blue;
            ((SolidBrush)brush).Color = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Orange;
            pen.Color = Color.Orange;
            ((SolidBrush)brush).Color = Color.Orange;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            pen.Color = Color.Red;
            ((SolidBrush)brush).Color = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Aqua;
            pen.Color = Color.Aqua;
            ((SolidBrush)brush).Color = Color.Aqua;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

    }
}
