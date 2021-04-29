using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abs
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void if_librarian_CheckedChanged(object sender, EventArgs e)
        {
            if (if_librarian.Checked)
            {
                label1.Text = "Пароль";
            }
            else
            {
                label1.Text = "ID билета";
            }
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            if (if_librarian.Checked)
            {
                Main_W_Librarian db_w = new Main_W_Librarian();

            }
            else
            {

            }
        }
    }
}
