namespace Blood_Bank.GUI
{
    partial class GUI_FillInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_FillInfo));
            this.panel_bgLogin = new System.Windows.Forms.Panel();
            this.label_bgLogin = new System.Windows.Forms.Label();
            this.comboBox_Address = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_BloodType = new System.Windows.Forms.ComboBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.txt_Contact = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Create = new FlatButton.JFlatButton();
            this.panel_bgLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bgLogin
            // 
            this.panel_bgLogin.BackColor = System.Drawing.Color.Firebrick;
            this.panel_bgLogin.Controls.Add(this.label_bgLogin);
            this.panel_bgLogin.Location = new System.Drawing.Point(1, 0);
            this.panel_bgLogin.Name = "panel_bgLogin";
            this.panel_bgLogin.Size = new System.Drawing.Size(367, 112);
            this.panel_bgLogin.TabIndex = 1;
            // 
            // label_bgLogin
            // 
            this.label_bgLogin.AutoSize = true;
            this.label_bgLogin.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bgLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_bgLogin.Location = new System.Drawing.Point(4, 23);
            this.label_bgLogin.Name = "label_bgLogin";
            this.label_bgLogin.Size = new System.Drawing.Size(359, 58);
            this.label_bgLogin.TabIndex = 0;
            this.label_bgLogin.Text = "Create an account";
            // 
            // comboBox_Address
            // 
            this.comboBox_Address.FormattingEnabled = true;
            this.comboBox_Address.Location = new System.Drawing.Point(123, 192);
            this.comboBox_Address.Name = "comboBox_Address";
            this.comboBox_Address.Size = new System.Drawing.Size(224, 21);
            this.comboBox_Address.TabIndex = 19;
            this.comboBox_Address.Click += new System.EventHandler(this.comboBox_Address_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhóm máu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên người dùng";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Donor",
            "Receive"});
            this.comboBox_Status.Location = new System.Drawing.Point(123, 271);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(224, 21);
            this.comboBox_Status.TabIndex = 9;
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
            this.comboBox_BloodType.Location = new System.Drawing.Point(123, 244);
            this.comboBox_BloodType.Name = "comboBox_BloodType";
            this.comboBox_BloodType.Size = new System.Drawing.Size(224, 21);
            this.comboBox_BloodType.TabIndex = 10;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(123, 164);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(224, 21);
            this.comboBox_Gender.TabIndex = 11;
            // 
            // txt_Contact
            // 
            this.txt_Contact.Location = new System.Drawing.Point(123, 218);
            this.txt_Contact.Name = "txt_Contact";
            this.txt_Contact.Size = new System.Drawing.Size(224, 20);
            this.txt_Contact.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(123, 138);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(224, 20);
            this.txt_Name.TabIndex = 7;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Create.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btn_Create.ButtonText = "Create";
            this.btn_Create.CausesValidation = false;
            this.btn_Create.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_Create.ErrorImageLeft")));
            this.btn_Create.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btn_Create.ErrorImageRight")));
            this.btn_Create.FocusBackground = System.Drawing.Color.Empty;
            this.btn_Create.FocusFontColor = System.Drawing.Color.Empty;
            this.btn_Create.ForeColors = System.Drawing.Color.White;
            this.btn_Create.HoverBackground = System.Drawing.Color.IndianRed;
            this.btn_Create.HoverFontColor = System.Drawing.Color.Empty;
            this.btn_Create.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_Create.ImageLeft")));
            this.btn_Create.ImageRight = null;
            this.btn_Create.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btn_Create.Location = new System.Drawing.Point(62, 320);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btn_Create.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btn_Create.RightPictureColor = System.Drawing.Color.Transparent;
            this.btn_Create.Size = new System.Drawing.Size(246, 43);
            this.btn_Create.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Create.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btn_Create.TabIndex = 20;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // GUI_FillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 387);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.comboBox_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.comboBox_BloodType);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.txt_Contact);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.panel_bgLogin);
            this.Name = "GUI_FillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill Information";
            this.panel_bgLogin.ResumeLayout(false);
            this.panel_bgLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bgLogin;
        private System.Windows.Forms.Label label_bgLogin;
        private System.Windows.Forms.ComboBox comboBox_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.ComboBox comboBox_BloodType;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox txt_Contact;
        private System.Windows.Forms.TextBox txt_Name;
        private FlatButton.JFlatButton btn_Create;
    }
}