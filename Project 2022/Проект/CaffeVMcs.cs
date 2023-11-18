using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class CaffeVMcs : Form
    {

        public static double total = 0;
        public CaffeVMcs()
        {
            InitializeComponent();
        }

        private void CaffeVMcs_Load(object sender, EventArgs e)
        {
            
            label1.Visible = false;

        }


        private void espreso_CheckedChanged(object sender, EventArgs e)
        {
           
            if (espreso.Checked == true)
            {
                
                label1.Text = "3.50";
                label1.Visible = true;
            }
        }

        private void americano_CheckedChanged(object sender, EventArgs e)
        {
            if (americano.Checked)
            {
                label1.Text = "1.50";
                label1.Visible = true;
            }
        }

        private void capuchino_CheckedChanged(object sender, EventArgs e)
        {
            if (capuchino.Checked)
            {
                label1.Text = "1.75";
                label1.Visible = true;
            }
        }

        private void macchiato_CheckedChanged(object sender, EventArgs e)
        {
            if (macchiato.Checked)
            {
                label1.Text = "2.00";
                label1.Visible = true;
            }
        }

        private void conpanna_CheckedChanged(object sender, EventArgs e)
        {
            if (conpanna.Checked)
            {
                label1.Text = "2.50";
                label1.Visible = true;
            }
        }

        private void caramel_CheckedChanged(object sender, EventArgs e)
        {
            if (caramel.Checked)
            {
                label1.Text = "3.25";
                label1.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (capuchino.Checked == false && americano.Checked == false && espreso.Checked == false && macchiato.Checked == false && conpanna.Checked == false && caramel.Checked == false)
            {
                MessageBox.Show("Не сте избрали напитка");
            }
            else
            {
                MessageBox.Show("Вземете напитката си");
                label1.Text = "";
                //this.Hide();
            }

        }

        
    }
}
