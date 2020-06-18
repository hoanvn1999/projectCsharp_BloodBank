using Blood_Bank.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.Business
{
    class Business_CreateAccount
    {
        DataConnection con = new DataConnection();
        public void createAccount(string username, string password)
        {
            try
            {
                string SQL = "INSERT INTO [ACCOUNT](USERNAME, PASSWORD) VALUES('" + username + "','" + password + "')";
                con.executeSQL(SQL);
                System.IO.File.WriteAllText("user.txt", username);
            }
            catch (Exception)
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
        }
    }
}
