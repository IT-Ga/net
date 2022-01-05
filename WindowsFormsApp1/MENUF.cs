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
    public partial class MENUF : Form
    {
        BUS_USER busUSER = new BUS_USER();
        BUS_thecao busTHE = new BUS_thecao();
        
        
       
        public MENUF()
        {
            InitializeComponent();
         
        }

        private void GUI_User_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = busTHE.getThe();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = dgvUser.CurrentRow.Index;
          
            txtmathe.Text = dgvUser.Rows[i].Cells[0].Value.ToString();
            txttenthe.Text = dgvUser.Rows[i].Cells[1].Value.ToString();
            txtmaloai.Text = dgvUser.Rows[i].Cells[2].Value.ToString();
            txtgiatien.Text = dgvUser.Rows[i].Cells[3].Value.ToString();
            txtsoluong.Text = dgvUser.Rows[i].Cells[4].Value.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmathe.Text != "" && txttenthe.Text != "" && txtmaloai.Text != "" && txtgiatien.Text != "" && txtsoluong.Text != "")
            {
                
                if (busTHE.insertthecao(txtmathe.Text, txttenthe.Text, txtmaloai.Text,  txtgiatien.Text, txtsoluong.Text))
                {
                    dgvUser.DataSource = busTHE.getThe();
                    MessageBox.Show("Thêm thẻ cào đặt thành công !");
                }
                else
                {
                    MessageBox.Show("thông tin chưa đầy đủ!");
                }
            }
            else
            {
                MessageBox.Show("thông tin chưa đầy đủ!");
                txtmathe.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (busTHE.deletethecao(txtmathe.Text))
            {
                dgvUser.DataSource = busTHE.getThe();
                MessageBox.Show("Xoá thành công!");
                

            }
            else
            {
                MessageBox.Show("xoá thất bại!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            busTHE.searchthecao(txttim.Text);
            dgvUser.DataSource = busTHE.getThe();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmathe.Text != "" && txttenthe.Text != "" && txtmaloai.Text != "" && txtgiatien.Text != "" && txtsoluong.Text != "")
            {
                if (busTHE.updatethecao(txtmathe.Text, txttenthe.Text, txtmaloai.Text, txtgiatien.Text, txtsoluong.Text))
                {
                    
                    MessageBox.Show("Chỉnh sửa thành công !");
                    dgvUser.DataSource = busTHE.getThe();
                }
                else
                {
                    MessageBox.Show("thông tin chưa đầy đủ!");
                }
            }
            else
            {
                MessageBox.Show("thông tin chưa đầy đủ!");
                txtmathe.Focus();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            dgvUser.DataSource = busTHE.getThe();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
