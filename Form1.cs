using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEESENGEr
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "admin" && PasswordBox.Text == "12345")
            {
                //Если логин и пароль верные, то переходим на другой экран
                ContactsScreen form3 = new ContactsScreen();
                form3.Show();
                this.Hide();
            }
            else
            {
                //Иначе выводим сообщение об ошибке авторизации
                LoginMessageBlock.Text = "Wrong login or password!";
                LoginMessageBlock.Visible=true;
            }

        }
        


        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
