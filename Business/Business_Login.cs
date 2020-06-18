using Blood_Bank.App_Code;
using Blood_Bank.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.Business
{
    class Business_Login
    {
        public void login(Form atHere,string username, string password)
        {
            DataConnection con = new DataConnection();
            DataTable tbUS = con.getTable("SELECT * FROM [ACCOUNT] WHERE USERNAME = '" + username + "' AND PASSWORD = '" + password + "'");
            if (tbUS.Rows.Count > 0)
            {
                System.IO.File.WriteAllText("user.txt", username);
                tbUS = con.getTable("SELECT * FROM [USER] WHERE USER_ID = '" + username + "'");
                if(tbUS.Rows.Count == 0 && username != "admin")
                {
                    GUI_FillInfo fill = new GUI_FillInfo();
                    fill.Visible = true;
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Visible = true;
                }
                atHere.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản, mật khẩu");
            }
        }
    }
}
