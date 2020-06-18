namespace Blood_Bank
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.panel_bgLogin = new System.Windows.Forms.Panel();
            this.label_bgLogin = new System.Windows.Forms.Label();
            this.txt_Passwd = new JTextBox.JTextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.txt_UsName = new JTextBox.JTextBox();
            this.lb_Create = new System.Windows.Forms.Label();
            this.btn_Login = new FlatButton.JFlatButton();
            this.panel_bgLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bgLogin
            // 
            this.panel_bgLogin.BackColor = System.Drawing.Color.Firebrick;
            this.panel_bgLogin.Controls.Add(this.label_bgLogin);
            this.panel_bgLogin.Location = new System.Drawing.Point(-1, 0);
            this.panel_bgLogin.Name = "panel_bgLogin";
            this.panel_bgLogin.Size = new System.Drawing.Size(367, 112);
            this.panel_bgLogin.TabIndex = 0;
            // 
            // label_bgLogin
            // 
            this.label_bgLogin.AutoSize = true;
            this.label_bgLogin.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bgLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_bgLogin.Location = new System.Drawing.Point(88, 9);
            this.label_bgLogin.Name = "label_bgLogin";
            this.label_bgLogin.Size = new System.Drawing.Size(179, 77);
            this.label_bgLogin.TabIndex = 0;
            this.label_bgLogin.Text = "Login";
            // 
            // txt_Passwd
            // 
            this.txt_Passwd.AutoSize = true;
            this.txt_Passwd.BorderColor = System.Drawing.Color.White;
            this.txt_Passwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Passwd.Hint = "";
            this.txt_Passwd.IsPassword = true;
            this.txt_Passwd.Length = 0;
            this.txt_Passwd.Location = new System.Drawing.Point(100, 197);
            this.txt_Passwd.Name = "txt_Passwd";
            this.txt_Passwd.OnFocus = System.Drawing.Color.Red;
            this.txt_Passwd.OnlyChar = false;
            this.txt_Passwd.OnlyNumber = false;
            this.txt_Passwd.Size = new System.Drawing.Size(253, 40);
            this.txt_Passwd.TabIndex = 2;
            this.txt_Passwd.TextValue = "";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.White;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(17, 151);
            this.label_Username.Name = "label_Username";
            this.label_Username.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_Username.Size = new System.Drawing.Size(83, 40);
            this.label_Username.TabIndex = 5;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.White;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(16, 197);
            this.label_Password.Name = "label_Password";
            this.label_Password.Padding = new System.Windows.Forms.Padding(0, 10, 6, 10);
            this.label_Password.Size = new System.Drawing.Size(84, 40);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password";
            // 
            // txt_UsName
            // 
            this.txt_UsName.AutoSize = true;
            this.txt_UsName.BorderColor = System.Drawing.Color.White;
            this.txt_UsName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_UsName.Hint = "";
            this.txt_UsName.IsPassword = false;
            this.txt_UsName.Length = 0;
            this.txt_UsName.Location = new System.Drawing.Point(100, 151);
            this.txt_UsName.Name = "txt_UsName";
            this.txt_UsName.OnFocus = System.Drawing.Color.Red;
            this.txt_UsName.OnlyChar = false;
            this.txt_UsName.OnlyNumber = false;
            this.txt_UsName.Size = new System.Drawing.Size(253, 40);
            this.txt_UsName.TabIndex = 2;
            this.txt_UsName.TextValue = "";
            // 
            // lb_Create
            // 
            this.lb_Create.AutoSize = true;
            this.lb_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Create.Location = new System.Drawing.Point(116, 322);
            this.lb_Create.Name = "lb_Create";
            this.lb_Create.Size = new System.Drawing.Size(133, 16);
            this.lb_Create.TabIndex = 6;
            this.lb_Create.Text = "Create an account";
            this.lb_Create.Click += new System.EventHandler(this.lb_Create_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Login.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.CausesValidation = false;
            this.btn_Login.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_Login.ErrorImageLeft")));
            this.btn_Login.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btn_Login.ErrorImageRight")));
            this.btn_Login.FocusBackground = System.Drawing.Color.Empty;
            this.btn_Login.FocusFontColor = System.Drawing.Color.Empty;
            this.btn_Login.ForeColors = System.Drawing.Color.White;
            this.btn_Login.HoverBackground = System.Drawing.Color.IndianRed;
            this.btn_Login.HoverFontColor = System.Drawing.Color.Empty;
            this.btn_Login.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_Login.ImageLeft")));
            this.btn_Login.ImageRight = null;
            this.btn_Login.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btn_Login.Location = new System.Drawing.Point(60, 265);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btn_Login.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btn_Login.RightPictureColor = System.Drawing.Color.Transparent;
            this.btn_Login.Size = new System.Drawing.Size(246, 43);
            this.btn_Login.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Login.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(369, 358);
            this.Controls.Add(this.lb_Create);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_UsName);
            this.Controls.Add(this.txt_Passwd);
            this.Controls.Add(this.panel_bgLogin);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Bank - Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.panel_bgLogin.ResumeLayout(false);
            this.panel_bgLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_bgLogin;
        private JTextBox.JTextBox txt_Passwd;
        private FlatButton.JFlatButton btn_Login;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private JTextBox.JTextBox txt_UsName;
        private System.Windows.Forms.Label lb_Create;
        private System.Windows.Forms.Label label_bgLogin;
    }
}

