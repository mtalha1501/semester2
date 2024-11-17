namespace MyApp.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.usernameBox = new Guna.UI.WinForms.GunaTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backHomeButton = new Guna.UI.WinForms.GunaImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.licensing1 = new Guna.UI.Licensing.Licensing();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BaseColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.Maroon;
            this.LoginButton.BorderSize = 2;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.FocusedColor = System.Drawing.Color.Empty;
            this.LoginButton.ForeColor = System.Drawing.Color.Maroon;
            this.LoginButton.Image = null;
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.LoginButton.Radius = 15;
            this.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.TextOffsetX = 45;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // gunaLinkLabel1
            // 
            resources.ApplyResources(this.gunaLinkLabel1, "gunaLinkLabel1");
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Red;
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.LightGray;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.gunaTextBox2, "gunaTextBox2");
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            // 
            // usernameBox
            // 
            this.usernameBox.BaseColor = System.Drawing.Color.LightGray;
            this.usernameBox.BorderColor = System.Drawing.Color.Maroon;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.FocusedBaseColor = System.Drawing.Color.White;
            this.usernameBox.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.usernameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.usernameBox, "usernameBox");
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.SelectedText = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyApp.Properties.Resources.log_in__1_;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label7);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.backHomeButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // backHomeButton
            // 
            this.backHomeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.backHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.backHomeButton.BackgroundImage = global::MyApp.Properties.Resources.back_arrow;
            resources.ApplyResources(this.backHomeButton, "backHomeButton");
            this.backHomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backHomeButton.Image = null;
            this.backHomeButton.ImageSize = new System.Drawing.Size(64, 64);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.OnHoverImage = null;
            this.backHomeButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.backHomeButton.Click += new System.EventHandler(this.backHomeButton_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Name = "label9";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.Close.Image = global::MyApp.Properties.Resources.cross;
            this.kryptonPalette1.Common.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.Common.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.Common.StateCommon.Border.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.Common.StateCommon.Border.Color2 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.Common.StateCommon.Border.ColorAngle = 135F;
            this.kryptonPalette1.Common.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.kryptonPalette1.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.Common.StateCommon.Border.Rounding = 20;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.TabStyles.TabCommon.OverrideFocus.Back.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPalette1.TabStyles.TabCommon.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.White;
            this.licensing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.licensing1, "licensing1");
            this.licensing1.Name = "licensing1";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.licensing1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.LoginButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Login";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton LoginButton;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox usernameBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton backHomeButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI.Licensing.Licensing licensing1;
    }
}

