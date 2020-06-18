using Blood_Bank.App_Code;
using Blood_Bank.Business;
using Blood_Bank.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blood_Bank
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        Business_Login bs;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bs = new Business_Login();
            bs.login(this, txt_UsName.TextValue, txt_Passwd.TextValue);
        }

        private void lb_Create_Click(object sender, EventArgs e)
        {
            GUI_CreateAccount ca = new GUI_CreateAccount();
            ca.Show();
            this.Hide();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Tài khoản mặc định cho quản trị viên:\n\tUsername: admin\n\tPassword: admin\n\nĐối với tài khoản dành cho người dùng thông thường có thể tạo tài khoản tại nút \"Create an account\" để sử dụng.\n\nNhấn \"OK\" để sử dụng phần mềm.", "Nhắn thầy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
