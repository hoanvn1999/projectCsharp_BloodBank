namespace Blood_Bank
{
    partial class ManageBloodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.comboBox_Address = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_SuaThongTin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_BloodType = new System.Windows.Forms.ComboBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.grd_Info = new System.Windows.Forms.DataGridView();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOODTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dbBloodBankDataSet = new Blood_Bank.dbBloodBankDataSet();
            this.dbBloodBankDataSet1 = new Blood_Bank.dbBloodBankDataSet1();
            this.pROVINCETableAdapter1 = new Blood_Bank.dbBloodBankDataSet1TableAdapters.PROVINCETableAdapter();
            this.pROVINCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROVINCEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_Control.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBloodBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBloodBankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVINCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVINCEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.Controls.Add(this.comboBox_Address);
            this.groupBox_Control.Controls.Add(this.btn_Xoa);
            this.groupBox_Control.Controls.Add(this.btn_SuaThongTin);
            this.groupBox_Control.Controls.Add(this.label4);
            this.groupBox_Control.Controls.Add(this.label7);
            this.groupBox_Control.Controls.Add(this.label6);
            this.groupBox_Control.Controls.Add(this.label5);
            this.groupBox_Control.Controls.Add(this.label3);
            this.groupBox_Control.Controls.Add(this.label2);
            this.groupBox_Control.Controls.Add(this.label1);
            this.groupBox_Control.Controls.Add(this.comboBox_Status);
            this.groupBox_Control.Controls.Add(this.comboBox_BloodType);
            this.groupBox_Control.Controls.Add(this.comboBox_Gender);
            this.groupBox_Control.Controls.Add(this.txt_Contact);
            this.groupBox_Control.Controls.Add(this.txt_Name);
            this.groupBox_Control.Controls.Add(this.txt_ID);
            this.groupBox_Control.Location = new System.Drawing.Point(31, 93);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Size = new System.Drawing.Size(370, 456);
            this.groupBox_Control.TabIndex = 1;
            this.groupBox_Control.TabStop = false;
            this.groupBox_Control.Text = "Bảng điều khiển";
            // 
            // comboBox_Address
            // 
            this.comboBox_Address.FormattingEnabled = true;
            this.comboBox_Address.Location = new System.Drawing.Point(120, 142);
            this.comboBox_Address.Name = "comboBox_Address";
            this.comboBox_Address.Size = new System.Drawing.Size(224, 21);
            this.comboBox_Address.TabIndex = 5;
            this.comboBox_Address.Click += new System.EventHandler(this.comboBox_Address_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(202, 316);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(115, 43);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xoá khỏi danh sách";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_SuaThongTin
            // 
            this.btn_SuaThongTin.Location = new System.Drawing.Point(47, 316);
            this.btn_SuaThongTin.Name = "btn_SuaThongTin";
            this.btn_SuaThongTin.Size = new System.Drawing.Size(115, 43);
            this.btn_SuaThongTin.TabIndex = 4;
            this.btn_SuaThongTin.Text = "Sửa thông tin";
            this.btn_SuaThongTin.UseVisualStyleBackColor = true;
            this.btn_SuaThongTin.Click += new System.EventHandler(this.btn_SuaThongTin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nhóm máu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã người dùng";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Donor",
            "Receive"});
            this.comboBox_Status.Location = new System.Drawing.Point(120, 221);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(224, 21);
            this.comboBox_Status.TabIndex = 1;
            // 
            // comboBox_BloodType
            // 
            this.comboBox_BloodType.FormattingEnabled = true;
            this.comboBox_BloodType.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox_BloodType.Location = new System.Drawing.Point(120, 194);
            this.comboBox_BloodType.Name = "comboBox_BloodType";
            this.comboBox_BloodType.Size = new System.Drawing.Size(224, 21);
            this.comboBox_BloodType.TabIndex = 1;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(120, 114);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(224, 21);
            this.comboBox_Gender.TabIndex = 1;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(120, 168);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(224, 20);
            this.txt_Contact.TabIndex = 0;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(120, 88);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(224, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_ID
            // 
            this.txt_ID.ForeColor = System.Drawing.Color.Red;
            this.txt_ID.Location = new System.Drawing.Point(120, 62);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(224, 20);
            this.txt_ID.TabIndex = 0;
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.grd_Info);
            this.groupBox_Info.Location = new System.Drawing.Point(426, 93);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(728, 456);
            this.groupBox_Info.TabIndex = 1;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Bảng thông tin";
            // 
            // grd_Info
            // 
            this.grd_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_ID,
            this.NAME,
            this.GENDER,
            this.PNAME,
            this.CONTACT,
            this.BLOODTYPE,
            this.STATUS});
            this.grd_Info.Location = new System.Drawing.Point(13, 25);
            this.grd_Info.Name = "grd_Info";
            this.grd_Info.Size = new System.Drawing.Size(702, 417);
            this.grd_Info.TabIndex = 0;
            this.grd_Info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Info_CellClick);
            this.grd_Info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Info_CellContentClick);
            // 
            // USER_ID
            // 
            this.USER_ID.DataPropertyName = "USER_ID";
            this.USER_ID.HeaderText = "Mã người dùng";
            this.USER_ID.Name = "USER_ID";
            this.USER_ID.Width = 120;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Tên người dùng";
            this.NAME.Name = "NAME";
            this.NAME.Width = 120;
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "GENDER";
            this.GENDER.HeaderText = "Giới tính";
            this.GENDER.Name = "GENDER";
            this.GENDER.Width = 60;
            // 
            // PNAME
            // 
            this.PNAME.DataPropertyName = "PNAME";
            this.PNAME.HeaderText = "Địa chỉ";
            this.PNAME.Name = "PNAME";
            this.PNAME.Width = 150;
            // 
            // CONTACT
            // 
            this.CONTACT.DataPropertyName = "CONTACT";
            this.CONTACT.HeaderText = "Số điện thoại";
            this.CONTACT.Name = "CONTACT";
            // 
            // BLOODTYPE
            // 
            this.BLOODTYPE.DataPropertyName = "BLOODTYPE";
            this.BLOODTYPE.HeaderText = "Nhóm máu";
            this.BLOODTYPE.Name = "BLOODTYPE";
            this.BLOODTYPE.Width = 40;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.Width = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(520, 44);
            this.label8.TabIndex = 2;
            this.label8.Text = "QUẢN LÝ NGÂN HÀNG MÁU";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Ảnh đại diện";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dbBloodBankDataSet
            // 
            this.dbBloodBankDataSet.DataSetName = "dbBloodBankDataSet";
            this.dbBloodBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbBloodBankDataSet1
            // 
            this.dbBloodBankDataSet1.DataSetName = "dbBloodBankDataSet1";
            this.dbBloodBankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROVINCETableAdapter1
            // 
            this.pROVINCETableAdapter1.ClearBeforeFill = true;
            // 
            // ManageBloodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.groupBox_Control);
            this.Name = "ManageBloodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank";
            this.Load += new System.EventHandler(this.ManageBloodForm_Load);
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox_Control.PerformLayout();
            this.groupBox_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBloodBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBloodBankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVINCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROVINCEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.Windows.Forms.DataGridView grd_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.ComboBox comboBox_BloodType;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_SuaThongTin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private dbBloodBankDataSet dbBloodBankDataSet;
        private System.Windows.Forms.BindingSource pROVINCEBindingSource;
        private dbBloodBankDataSet1 dbBloodBankDataSet1;
        private System.Windows.Forms.BindingSource pROVINCEBindingSource1;
        private dbBloodBankDataSet1TableAdapters.PROVINCETableAdapter pROVINCETableAdapter1;
        private System.Windows.Forms.ComboBox comboBox_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOODTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}