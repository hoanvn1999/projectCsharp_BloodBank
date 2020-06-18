using Blood_Bank.App_Code;
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

namespace Blood_Bank
{
    public partial class ManageBloodForm : Form
    {
        Business_ManageBlood mb = new Business_ManageBlood();
        public ManageBloodForm()
        {
            InitializeComponent();
        }

        private void loadInfo()
        {
            grd_Info.DataSource = mb.tbManageBlood();
        }

        private void ManageBloodForm_Load(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void grd_Info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void grd_Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a, b, c, d, h, f, g;
            mb.grd_Click(grd_Info, grd_Info.CurrentRow.Index, out a , out b, out c, out d , out h, out f, out g);
            txt_ID.Text = a;
            txt_Name.Text = b;
            comboBox_Gender.Text = c;
            comboBox_Address.Text = d;
            txt_Contact.Text = h;
            comboBox_BloodType.Text = f;
            comboBox_Status.Text = g;
        }

        private void PicBox_Avt_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                }
            }
            catch (Exception) { }
        }

        private void btn_SuaThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                mb.sua(txt_ID.Text, txt_Name.Text, comboBox_Gender.Text, comboBox_Address.SelectedValue.ToString(), txt_Contact.Text, comboBox_BloodType.Text, comboBox_Status.Text);
                loadInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            mb.xoa(txt_ID.Text);
            loadInfo();
        }

        private void comboBox_Address_Click(object sender, EventArgs e)
        {
            comboBox_Address.DataSource = mb.loadProvince();
            comboBox_Address.DisplayMember = "PNAME";
            comboBox_Address.ValueMember = "ID";
        }
    }
}
