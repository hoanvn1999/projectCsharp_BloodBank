using Blood_Bank.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.Business
{
    class Business_ManageBlood
    {
        DataConnection con;
        public DataTable tbManageBlood()
        {
            con = new DataConnection();
            return con.getTable("SELECT USER_ID, NAME, GENDER, PNAME, CONTACT, BLOODTYPE, STATUS FROM [USER],[PROVINCE] WHERE ADDRESS = ID");
        }
        public DataTable loadProvince()
        {
            con = new DataConnection();
            DataTable tb = con.getTable("SELECT * FROM [PROVINCE]");
            return tb;
        }
        public DataTable loadProvince(string s)
        {
            con = new DataConnection();
            DataTable tb = con.getTable("SELECT * FROM [PROVINCE] WHERE PNAME = '" + s +"'");
            return tb;
        }
        public void grd_Click(DataGridView grd,int index, out string maNguoiDung, out string tenNguoiDung, out string gioiTinh, out string diaChi, out string SoDienThoai, out string nhomMau, out string trangThai)
        {
            maNguoiDung = grd.Rows[index].Cells[0].Value.ToString();
            tenNguoiDung = grd.Rows[index].Cells[1].Value.ToString();
            gioiTinh = grd.Rows[index].Cells[2].Value.ToString();
            diaChi = grd.Rows[index].Cells[3].Value.ToString();
            SoDienThoai = grd.Rows[index].Cells[4].Value.ToString();
            nhomMau = grd.Rows[index].Cells[6].Value.ToString();
            trangThai = grd.Rows[index].Cells[7].Value.ToString();
            loadProvince(diaChi);
        }
        public void sua(string maND, string tenND, string gioiTinh, string diaChi, string sdt, string nhomMau, string trangThai)
        {
            string SQL = "UPDATE [USER] " +
                         "SET NAME = N'" + tenND + "', GENDER = '" + gioiTinh +
                            "', ADDRESS = '" + diaChi + "', CONTACT = '" + sdt +
                            "', BLOODTYPE = '" + nhomMau + "', STATUS = '" +trangThai +
                         "' WHERE USER_ID = '" + maND + "'";
            con.executeSQL(SQL);
        }
        public void xoa(string maNV)
        {
            string SQL = "DELETE FROM [USER] WHERE USER_ID = '" + maNV + "'";
            con.executeSQL(SQL);
        }
    }
}
