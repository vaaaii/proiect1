using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proiect1
{
    
    public partial class Form1 : Form
    {
       public bool ok = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer bg_music = new SoundPlayer("cripiwa.wav");
            bg_music.PlayLooping();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sertar s = new sertar();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info i = new info();
            i.ShowDialog();
            ok = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            //nu
        }
        private void label2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            //nu inteleg de ce nu mere, o mers initial si acuma ii blestemat
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            final ff = new final();
            ff.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fesreastra f = new fesreastra();
            f.ShowDialog();
        }
    }
}
