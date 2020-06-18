using Blood_Bank.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.GUI
{
    public partial class GUI_CreateAccount : Form
    {
        public GUI_CreateAccount()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if(txt_Passwd.TextValue != txt_ReEnter.TextValue)
                MessageBox.Show("Mật khẩu nhập lại không chính xác, vui lòng nhập lại");
            else
            {
                Business_CreateAccount ca = new Business_CreateAccount();
                ca.createAccount(txt_UsName.TextValue, txt_Passwd.TextValue);
                GUI_FillInfo fill = new GUI_FillInfo();
                fill.Visible = true;
                this.Close();
            }
        }
    }
}
