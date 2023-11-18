using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace Проект
{

    public partial class Cafe : Form
    {
        public static double total = 0, change;
        public Cafe()
        {
            InitializeComponent();


            



        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Това може да не го правите
            this.Close();
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //изписва крайната сума
            tbTotal.Text = tbSum.Text + "лв.";
        }

        private void button3_Click(object sender, EventArgs e) // Бутон Добави
        {
            if (rbHotCoffee.Checked == true) // Ako е избран радио бутон Hot Cafe 
            {

                if (rbSmall.Checked == true)  // Ako е избран радио бутон Small 
                {
                    //изпиши в richTexBox
                    richTextBox1.Text = richTextBox1.Text + "\nSmall Hot Coffee - 1.50";
                    //добави към променлива total - 1,50
                    total = total + 1.50;
                    //Добавяме към текст бокс tbSum ст-ст на total
                    tbSum.Text = total.ToString();
                }
                else if (rbMedium.Checked == true) //Иначе ако е избран радио бутон Medium
                {

                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 2";
                    total = total + 2;
                    tbSum.Text = total.ToString();
                }
                else
                {

                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 3.50";
                    total = total + 3.50;
                    tbSum.Text = total.ToString();

                }


            }
            else if (rbIceCoffee.Checked == true) // Иначе ако е избран радио бутон ice coffee 
            {
                if (rbSmall.Checked == true) // Ako е избран радио бутон Small 
                {

                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 2.50";
                    total = total + 2.50;
                    tbSum.Text = total.ToString();

                }
                else if (rbMedium.Checked == true)
                {

                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 3.50";
                    total = total + 3.50;
                    tbSum.Text = total.ToString();
                }
                else
                {

                    richTextBox1.Text = richTextBox1.Text + "\nMedium Hot Coffee - 4";
                    total = total + 4;
                    tbSum.Text = total.ToString();
                }


            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //изчиства всички полета
            richTextBox1.Clear();
            tbSum.Clear();
            total = 0;
            tbTotal.Clear();
            rbHotCoffee.Checked = false;
            rbIceCoffee.Checked = false;
            rbSmall.Checked= false;
            rbMedium.Checked = false;
            rbLarge.Checked= false;
        }
    }
}
