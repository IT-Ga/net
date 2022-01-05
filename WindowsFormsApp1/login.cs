using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_CARD;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        BUS_USER busAcc = new BUS_USER();
        public login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnExti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text != "" && txbPassWord.Text != "")
            {
                if (busAcc.getLogin(txbPassWord.Text, txbPassWord.Text))
                {
                    mySave.KT = !mySave.KT;
                   
                    MENUF f = new MENUF();
                    f.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Username or Password is not correct!", "Attention");
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
