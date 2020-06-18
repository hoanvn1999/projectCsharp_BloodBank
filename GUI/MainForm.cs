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
    public partial class MainForm : Form
    {
        ManageBloodForm mnForm;
        GUI_FindPeople findPeople;
        formLogin formLG;
        public MainForm()
        {
            InitializeComponent();
        }

        private void bloodBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mnForm == null)
            {
                mnForm = new ManageBloodForm();
                mnForm.FormClosed += new FormClosedEventHandler(ManageBloodForm_FormClosed);
                mnForm.MdiParent = this;
                mnForm.Show();
            }
            else mnForm.Activate();
        }
        private void ManageBloodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mnForm = null;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLG = new formLogin();
            formLG.Show();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string usrname = System.IO.File.ReadAllText("user.txt");
            if (usrname != "admin")
                bloodBankToolStripMenuItem.Visible = false;
        }

        private void findPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (findPeople == null)
            {
                findPeople = new GUI_FindPeople();
                findPeople.FormClosed += new FormClosedEventHandler(GUI_FindPeople_FormClosed);
                findPeople.MdiParent = this;
                findPeople.Show();
            }
            else findPeople.Activate();
        }
        private void GUI_FindPeople_FormClosed(object sender, FormClosedEventArgs e)
        {
            findPeople = null;
        }
    }
}
