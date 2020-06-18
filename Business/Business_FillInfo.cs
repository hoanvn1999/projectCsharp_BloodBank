using Blood_Bank.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Business
{
    class Business_FillInfo
    {
        DataConnection con = new DataConnection();
        public void them(string tenND, string gioiTinh, string diaChi, string sdt, string nhomMau, string trangThai)
        {
            string usrname = System.IO.File.ReadAllText("user.txt");
            string SQL = "INSERT INTO [USER](USER_ID, NAME, GENDER, ADDRESS, CONTACT, BLOODTYPE, STATUS) VALUES('" + usrname + "',N'" +
                                             tenND + "','" + gioiTinh + "','" + diaChi +
                                             "','" + sdt + "','" + nhomMau + "','" + trangThai + "')";
            con.executeSQL(SQL);
        }
    }
}
