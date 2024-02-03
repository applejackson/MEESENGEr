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
    public partial class ContactsScreen : Form
    {
        public ContactsScreen()
        {
            InitializeComponent();
        }

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex >= 0)
            {
                //Тут будет код загрузки сообщений из чата

                //Сбрасываем индекс
                ContactsList.SelectedIndex = -1;

                ChatScreen form2 = new ChatScreen();
                form2.Show();
                this.Hide(); ;
            }

        }
    }
}
