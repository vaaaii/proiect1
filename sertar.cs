﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect1
{
    public partial class sertar : Form
    {
        public sertar()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked.Equals(true))
                this.Close();
            else if (radioButton3.Checked.Equals(true))
                this.Close();
            else if (radioButton4.Checked.Equals(true))
                this.Close();
            else
                textBox2.Visible = true;




        }
    }
}
