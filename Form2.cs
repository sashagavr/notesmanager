﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_09_03_2017
{
    public partial class Form2 : Form
    {
        Form1 f1;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Close();
        }
    }
}
