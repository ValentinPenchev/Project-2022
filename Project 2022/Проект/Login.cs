using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Проект
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Едноредов комеентар (//)
            /*Многоредов 
             коментар */

            /*if (tbUsername.Text == "admin" && tbPassword.Text == "pass") //Достъп за вход
            {

            }*/


            //MessageBox.Show("Добре дошли"); //Съобщение, което се показва след натискане на бутон Login
            

             this.Hide();// Скрива формата Login (след натискане на бутона)
             //Cafe f2 = new Cafe(); //Свързва форма Login с втората форма, (където Cafe е името на вашата втора форма) .
             //f2.ShowDialog(); // Показва втората форма (в този случай Cafe form)

            //Ако искате да стартирате проект с самолетни билети, откоментирате следващите два реда
            //и закоментирате горните два - (!this.Hide() остава!)

            //CaffeVMcs f2 = new CaffeVMcs();
              Airlines f2 = new Airlines();      //Свързва форма Login с втората форма, (където Airlines е името на вашата втора форма)  
              f2.ShowDialog();       //Показва втората форма (в този случай Cafe form)

        }
    }
}
