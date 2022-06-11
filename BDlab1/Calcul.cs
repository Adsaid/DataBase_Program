﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDlab1
{
    public partial class Calcul : Form
    {
        public Calcul()
        {
            InitializeComponent();
        }

        private void Calcul_Load(object sender, EventArgs e)
        {
            cmbxAct.Items.Add("+");
            cmbxAct.Items.Add("-");
            cmbxAct.Items.Add("*");
            cmbxAct.Items.Add("/");

            cmbxAct.Text = "+";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double ch1, ch2;
            if (txtCh1.Text == "") ch1 = 0; else ch1 = double.Parse(txtCh1.Text);
            if (txtCh2.Text == "") ch2 = 0; else ch2 = Convert.ToDouble(txtCh2.Text);

            if (cmbxAct.SelectedIndex == 0)
                txtRez.Text = (ch1 + ch2).ToString();
            else if (cmbxAct.SelectedIndex == 1)
                txtRez.Text = (ch1 - ch2).ToString();
            else if (cmbxAct.SelectedIndex == 2)
                txtRez.Text = (ch1 * ch2).ToString();
            else if (cmbxAct.SelectedIndex == 3)
                txtRez.Text = (ch1 / ch2).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
