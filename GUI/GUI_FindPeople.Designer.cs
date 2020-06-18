namespace Blood_Bank.GUI
{
    partial class GUI_FindPeople
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
            this.grd_Info = new System.Windows.Forms.DataGridView();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOODTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Address = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_BloodType = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Info)).BeginInit();
            this.SuspendLayout();
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
            this.grd_Info.Location = new System.Drawing.Point(57, 158);
            this.grd_Info.Name = "grd_Info";
            this.grd_Info.Size = new System.Drawing.Size(702, 417);
            this.grd_Info.TabIndex = 1;
            // 
            // USER_ID
            // 
            this.USER_ID.DataPropertyName = "USER_ID";
            this.USER_ID.HeaderText = "Mã người dùng";
            this.USER_ID.Name = "USER_ID";
            this.USER_ID.Width = 80;
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
            this.PNAME.Width = 180;
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
            this.STATUS.Width = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(405, 44);
            this.label8.TabIndex = 3;
            this.label8.Text = "KẾT NỐI MỌI NGƯỜI";
            // 
            // comboBox_Address
            // 
            this.comboBox_Address.FormattingEnabled = true;
            this.comboBox_Address.Location = new System.Drawing.Point(73, 91);
            this.comboBox_Address.Name = "comboBox_Address";
            this.comboBox_Address.Size = new System.Drawing.Size(224, 21);
            this.comboBox_Address.TabIndex = 11;
            this.comboBox_Address.Click += new System.EventHandler(this.comboBox_Address_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhóm máu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Donor",
            "Receive"});
            this.comboBox_Status.Location = new System.Drawing.Point(574, 90);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(109, 21);
            this.comboBox_Status.TabIndex = 6;
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
            this.comboBox_BloodType.Location = new System.Drawing.Point(379, 90);
            this.comboBox_BloodType.Name = "comboBox_BloodType";
            this.comboBox_BloodType.Size = new System.Drawing.Size(114, 21);
            this.comboBox_BloodType.TabIndex = 7;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(705, 86);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 28);
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // GUI_FindPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 599);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.comboBox_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.comboBox_BloodType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grd_Info);
            this.Name = "GUI_FindPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI_FindPeople";
            this.Load += new System.EventHandler(this.GUI_FindPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOODTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.ComboBox comboBox_BloodType;
        private System.Windows.Forms.Button btn_Search;
    }
}