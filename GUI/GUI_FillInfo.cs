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
    public partial class GUI_FillInfo : Form
    {
        Business_FillInfo bf = new Business_FillInfo();
        public GUI_FillInfo()
        {
            InitializeComponent();
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                bf.them(txt_Name.Text, comboBox_Gender.Text, comboBox_Address.SelectedValue.ToString(), txt_Contact.Text, comboBox_BloodType.Text, comboBox_Status.Text);
                MainForm main = new MainForm();
                main.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void comboBox_Address_Click(object sender, EventArgs e)
        {
            Business_ManageBlood mb = new Business_ManageBlood();
            comboBox_Address.DataSource = mb.loadProvince();
            comboBox_Address.DisplayMember = "PNAME";
            comboBox_Address.ValueMember = "ID";
        }
    }
}
