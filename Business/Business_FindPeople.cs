using Blood_Bank.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Business
{
    class Business_FindPeople
    {
        public DataTable search(string diaChi, string nhomMau, string trangThai)
        {
            string SQL = "SELECT USER_ID, NAME, GENDER, PNAME, CONTACT, BLOODTYPE, STATUS FROM [USER],[PROVINCE] WHERE ADDRESS = ID";
            if (diaChi != "") SQL += " AND ADDRESS = '" + diaChi + "'";
            if (nhomMau != "") SQL += " AND BLOODTYPE = '" + nhomMau + "'";
            if (trangThai != "") SQL += " AND STATUS = '" + trangThai + "'";
            DataConnection con = new DataConnection();
            return con.getTable(SQL);
        }
    }
}
