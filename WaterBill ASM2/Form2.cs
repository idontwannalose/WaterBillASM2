using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill_ASM2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = txtUsername.Text;
            string p = txtPassword.Text;
            if (u.Equals("admin") && p.Equals("123456"))
            {
                MessageBox.Show(this, "Login successfully!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ManageBill waterBillManagement = new ManageBill();
                this.Hide();
                waterBillManagement.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "User on pass is incorrect!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Do you want to exit?", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
