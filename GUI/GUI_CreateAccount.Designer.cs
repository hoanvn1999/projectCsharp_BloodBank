using FlatButton;
using JTextBox;
namespace Blood_Bank.GUI
{
    partial class GUI_CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_CreateAccount));
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.txt_UsName = new JTextBox.JTextBox();
            this.txt_Passwd = new JTextBox.JTextBox();
            this.panel_bgLogin = new System.Windows.Forms.Panel();
            this.btn_Next = new FlatButton.JFlatButton();
            this.txt_ReEnter = new JTextBox.JTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_bgLogin = new System.Windows.Forms.Label();
            this.panel_bgLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.White;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(14, 197);
            this.label_Password.Name = "label_Password";
            this.label_Password.Padding = new System.Windows.Forms.Padding(0, 10, 6, 10);
            this.label_Password.Size = new System.Drawing.Size(84, 40);
            this.label_Password.TabIndex = 10;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.White;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(15, 151);
            this.label_Username.Name = "label_Username";
            this.label_Username.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label_Username.Size = new System.Drawing.Size(83, 40);
            this.label_Username.TabIndex = 11;
            this.label_Username.Text = "Username";
            // 
            // txt_UsName
            // 
            this.txt_UsName.AutoSize = true;
            this.txt_UsName.BorderColor = System.Drawing.Color.White;
            this.txt_UsName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_UsName.Hint = "";
            this.txt_UsName.IsPassword = false;
            this.txt_UsName.Length = 0;
            this.txt_UsName.Location = new System.Drawing.Point(98, 151);
            this.txt_UsName.Name = "txt_UsName";
            this.txt_UsName.OnFocus = System.Drawing.Color.Red;
            this.txt_UsName.OnlyChar = false;
            this.txt_UsName.OnlyNumber = false;
            this.txt_UsName.Size = new System.Drawing.Size(253, 40);
            this.txt_UsName.TabIndex = 7;
            this.txt_UsName.TextValue = "";
            // 
            // txt_Passwd
            // 
            this.txt_Passwd.AutoSize = true;
            this.txt_Passwd.BorderColor = System.Drawing.Color.White;
            this.txt_Passwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Passwd.Hint = "";
            this.txt_Passwd.IsPassword = true;
            this.txt_Passwd.Length = 0;
            this.txt_Passwd.Location = new System.Drawing.Point(98, 197);
            this.txt_Passwd.Name = "txt_Passwd";
            this.txt_Passwd.OnFocus = System.Drawing.Color.Red;
            this.txt_Passwd.OnlyChar = false;
            this.txt_Passwd.OnlyNumber = false;
            this.txt_Passwd.Size = new System.Drawing.Size(253, 40);
            this.txt_Passwd.TabIndex = 8;
            this.txt_Passwd.TextValue = "";
            // 
            // panel_bgLogin
            // 
            this.panel_bgLogin.BackColor = System.Drawing.Color.Firebrick;
            this.panel_bgLogin.Controls.Add(this.label_bgLogin);
            this.panel_bgLogin.Location = new System.Drawing.Point(0, 0);
            this.panel_bgLogin.Name = "panel_bgLogin";
            this.panel_bgLogin.Size = new System.Drawing.Size(367, 112);
            this.panel_bgLogin.TabIndex = 6;
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Next.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btn_Next.ButtonText = "Next";
            this.btn_Next.CausesValidation = false;
            this.btn_Next.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_Next.ErrorImageLeft")));
            this.btn_Next.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btn_Next.ErrorImageRight")));
            this.btn_Next.FocusBackground = System.Drawing.Color.Empty;
            this.btn_Next.FocusFontColor = System.Drawing.Color.Empty;
            this.btn_Next.ForeColors = System.Drawing.Color.White;
            this.btn_Next.HoverBackground = System.Drawing.Color.IndianRed;
            this.btn_Next.HoverFontColor = System.Drawing.Color.Empty;
            this.btn_Next.ImageLeft = ((System.Drawing.Image)(resources.GetObject("btn_Next.ImageLeft")));
            this.btn_Next.ImageRight = null;
            this.btn_Next.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btn_Next.Location = new System.Drawing.Point(58, 312);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btn_Next.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btn_Next.RightPictureColor = System.Drawing.Color.Transparent;
            this.btn_Next.Size = new System.Drawing.Size(246, 43);
            this.btn_Next.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Next.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btn_Next.TabIndex = 9;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // txt_ReEnter
            // 
            this.txt_ReEnter.AutoSize = true;
            this.txt_ReEnter.BorderColor = System.Drawing.Color.White;
            this.txt_ReEnter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ReEnter.Hint = "";
            this.txt_ReEnter.IsPassword = true;
            this.txt_ReEnter.Length = 0;
            this.txt_ReEnter.Location = new System.Drawing.Point(98, 243);
            this.txt_ReEnter.Name = "txt_ReEnter";
            this.txt_ReEnter.OnFocus = System.Drawing.Color.Red;
            this.txt_ReEnter.OnlyChar = false;
            this.txt_ReEnter.OnlyNumber = false;
            this.txt_ReEnter.Size = new System.Drawing.Size(253, 40);
            this.txt_ReEnter.TabIndex = 8;
            this.txt_ReEnter.TextValue = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 243);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 6, 10);
            this.label1.Size = new System.Drawing.Size(84, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Re-enter";
            // 
            // label_bgLogin
            // 
            this.label_bgLogin.AutoSize = true;
            this.label_bgLogin.Font = new System.Drawing.Font("Script MT Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bgLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_bgLogin.Location = new System.Drawing.Point(4, 27);
            this.label_bgLogin.Name = "label_bgLogin";
            this.label_bgLogin.Size = new System.Drawing.Size(359, 58);
            this.label_bgLogin.TabIndex = 1;
            this.label_bgLogin.Text = "Create an account";
            // 
            // GUI_CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.txt_UsName);
            this.Controls.Add(this.txt_ReEnter);
            this.Controls.Add(this.txt_Passwd);
            this.Controls.Add(this.panel_bgLogin);
            this.Name = "GUI_CreateAccount";
            this.Text = "GUI_CreateAccount";
            this.panel_bgLogin.ResumeLayout(false);
            this.panel_bgLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
        private FlatButton.JFlatButton btn_Next;
        private JTextBox.JTextBox txt_UsName;
        private JTextBox.JTextBox txt_Passwd;
        private System.Windows.Forms.Panel panel_bgLogin;
        private JTextBox.JTextBox txt_ReEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_bgLogin;
    }
}