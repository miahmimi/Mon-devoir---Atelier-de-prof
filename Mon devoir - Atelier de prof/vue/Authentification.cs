using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mon_devoir___Atelier_de_prof.vue
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "new" && txtpwd.Text == "123")
            {

                btnconnect.Focus();
                vue.listeperso frm = new vue.listeperso();
                frm.Show();
                this.Hide();

            }



            else
            {
                MessageBox.Show("Erreur!");
                txtlogin.Clear();
                txtpwd.Clear();
                txtlogin.Focus();
            }
        }
          

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
