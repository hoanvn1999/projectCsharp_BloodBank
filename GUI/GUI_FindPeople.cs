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
    public partial class GUI_FindPeople : Form
    {
        Business_ManageBlood mb = new Business_ManageBlood();
        Business_FindPeople mf = new Business_FindPeople();
        public GUI_FindPeople()
        {
            InitializeComponent();
        }
        private void loadInfo()
        {
            grd_Info.DataSource = mb.tbManageBlood();
        }

        private void GUI_FindPeople_Load(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void comboBox_Address_Click(object sender, EventArgs e)
        {
            comboBox_Address.DataSource = mb.loadProvince();
            comboBox_Address.DisplayMember = "PNAME";
            comboBox_Address.ValueMember = "ID";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string a = "";
            if (comboBox_Address.SelectedItem != null)
                a = comboBox_Address.SelectedValue.ToString();
            grd_Info.DataSource = mf.search(a, comboBox_BloodType.Text, comboBox_Status.Text);
        }
    }
}
