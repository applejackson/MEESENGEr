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
    public partial class ChatScreen : Form
    {
        public ChatScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ContactsScreen form3 = new ContactsScreen();
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = "";

            //if (!string.IsNullOrEmpty(listBox1);
            //{

            //    text = label1.Text;
            //}

            if (!string.IsNullOrEmpty(text))
            {

                bool result = true;

                if (result)
                {
                    MessageBox.Show(
                       "Выберите один из вариантов",
                       "Сообщение",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
