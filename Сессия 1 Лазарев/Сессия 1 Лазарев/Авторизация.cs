using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сессия_1_Лазарев
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Админ")
            {
                if (textBox2.Text == "12345")
                {
                    Админ админ = new Админ();
                    this.Hide();
                    админ.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else
            if (textBox1.Text == "Пользователь")
            {
                if (textBox2.Text == "1234")
                {
                    Пользователь пользователь = new Пользователь();
                    this.Hide();
                    пользователь.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
