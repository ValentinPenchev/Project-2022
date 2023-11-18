using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Проект
{
    public partial class Airlines : Form
    {
        public static double total = 0;



        public Airlines()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            //
            //this.Hide();
            //Cafe f2 = new Cafe(); //this is the change, code for redirect  
            //f2.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
           
        }

    


        private void lblData_Click(object sender, EventArgs e)
        {
            

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            richTextBox1.Clear();
            total= 0;
        }

        private void button1_Click(object sender, EventArgs e) // Бутон запази
        {
            if (comboBox1.Text == "София") //Ако в comboBox1(падащ списък) е избрано "София"
            {
                if (comboBox2.Text == "Пловдив") // и ако в comboBox1(падащ списък) е избрано "Пловдив"
                {
                    //добави към променлива total ст-ст 35 (където 35 ни е цената)
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Варна") // иначе ако 
                {
                    total = total + 50;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Бургас")
                {
                    total = total + 50;
                    //richTextBox1.Text = total.ToString();
                }

            }

            else if (comboBox1.Text == "Пловдив")
            {
                if (comboBox2.Text == "София")
                {
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Варна")
                {
                    total = total + 45;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Бургас")
                {
                    total = total + 40;
                    //richTextBox1.Text = total.ToString();
                }
            }
            else if (comboBox1.Text == "Варна")
            {
                if (comboBox2.Text == "София")
                {
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Пловдив")
                {
                    total = total + 100;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Бургас")
                {
                    total = total + 150;
                    //richTextBox1.Text = total.ToString();
                }

            }
            else if (comboBox1.Text == "Бургас")
            {
                if (comboBox2.Text == "София")
                {
                    total = total + 35;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Варна")
                {
                    total = total + 80;
                    //richTextBox1.Text = total.ToString();
                }
                else if (comboBox2.Text == "Пловдив")
                {
                    total = total + 75;
                    //richTextBox1.Text = total.ToString();
                }


            }

            /*След натискане на бутон Запази в richTextBox1 ни се отпечатва следното:
             * textBox1.Text e ст-ст на полето име
             * textBox2.Text e ст-ст на полето адрес и т.н
             * \n - текста се пренася на нов ред
             
             
             */
            richTextBox1.Text = "Име: " + textBox1.Text + "\nАдрес: " + textBox2.Text + "\nТелефон: " + textBox3.Text + "\nДестинация: " +
               "\nОт: " + comboBox1.Text + " До: " + comboBox2.Text + "\nЦена: " + total + " лв.";
            //Информация за полет


            //Ако Ст-ст на comboBox1 е същото като comboBox2 изписва Грешка
            //Пример: ако изпишем че пътуваме от София до София - грешка

            if (comboBox1.Text == comboBox2.Text)
            {
                richTextBox1.Text = "Грешни данни";
            }

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\User\Desktop\test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    richTextBox1.AppendText(reader.ReadLine()); 
                }
                
            }
        }
    }
}

