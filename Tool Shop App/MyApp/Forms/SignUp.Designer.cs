namespace MyApp.Forms
{
    partial class Form1
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backHomeButton = new Guna.UI.WinForms.GunaImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaRadioButton1 = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaRadioButton2 = new Guna.UI.WinForms.GunaRadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.kryptonPalette1.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette1_PalettePaint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(653, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(649, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1057, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Your Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(1057, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Your Phone #";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.AnimationHoverSpeed = 0.07F;
            this.LoginButton.AnimationSpeed = 0.03F;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BaseColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.Maroon;
            this.LoginButton.BorderSize = 2;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.FocusedColor = System.Drawing.Color.Empty;
            this.LoginButton.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.LoginButton.ForeColor = System.Drawing.Color.Maroon;
            this.LoginButton.Image = null;
            this.LoginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginButton.Location = new System.Drawing.Point(896, 687);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnHoverBaseColor = System.Drawing.Color.Maroon;
            this.LoginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginButton.OnHoverImage = null;
            this.LoginButton.OnPressedColor = System.Drawing.Color.Black;
            this.LoginButton.Radius = 15;
            this.LoginButton.Size = new System.Drawing.Size(229, 67);
            this.LoginButton.TabIndex = 14;
            this.LoginButton.Text = "Sign Up";
            this.LoginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Red;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(1118, 545);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(239, 25);
            this.gunaLinkLabel1.TabIndex = 15;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Already Have Account?Login";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(754, 589);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "Select Role";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.backHomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1748, 43);
            this.panel1.TabIndex = 18;
            // 
            // backHomeButton
            // 
            this.backHomeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.backHomeButton.BackColor = System.Drawing.Color.Transparent;
            this.backHomeButton.BackgroundImage = global::MyApp.Properties.Resources.back_arrow;
            this.backHomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backHomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backHomeButton.Image = null;
            this.backHomeButton.ImageSize = new System.Drawing.Size(64, 64);
            this.backHomeButton.Location = new System.Drawing.Point(3, 3);
            this.backHomeButton.Name = "backHomeButton";
            this.backHomeButton.OnHoverImage = null;
            this.backHomeButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.backHomeButton.Size = new System.Drawing.Size(64, 37);
            this.backHomeButton.TabIndex = 1;
            this.backHomeButton.Click += new System.EventHandler(this.backHomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1748, 140);
            this.panel2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(878, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 51);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tools Shop";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 851);
            this.panel3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(75, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyApp.Properties.Resources.add_user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usernameBox
            // 
            this.usernameBox.BaseColor = System.Drawing.Color.LightGray;
            this.usernameBox.BorderColor = System.Drawing.Color.Maroon;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.FocusedBaseColor = System.Drawing.Color.White;
            this.usernameBox.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.usernameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.usernameBox.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.usernameBox.Location = new System.Drawing.Point(660, 393);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(303, 47);
            this.usernameBox.TabIndex = 22;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.LightGray;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.gunaTextBox1.Location = new System.Drawing.Point(1064, 393);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(303, 47);
            this.gunaTextBox1.TabIndex = 23;
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.LightGray;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.gunaTextBox2.Location = new System.Drawing.Point(660, 483);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(303, 47);
            this.gunaTextBox2.TabIndex = 24;
            this.gunaTextBox2.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.LightGray;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.Maroon;
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.gunaTextBox3.Location = new System.Drawing.Point(1064, 483);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(303, 47);
            this.gunaTextBox3.TabIndex = 25;
            this.gunaTextBox3.TextChanged += new System.EventHandler(this.gunaTextBox3_TextChanged);
            // 
            // gunaRadioButton1
            // 
            this.gunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton1.CheckedOnColor = System.Drawing.Color.Maroon;
            this.gunaRadioButton1.FillColor = System.Drawing.Color.Maroon;
            this.gunaRadioButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaRadioButton1.ForeColor = System.Drawing.Color.Maroon;
            this.gunaRadioButton1.Location = new System.Drawing.Point(936, 594);
            this.gunaRadioButton1.Name = "gunaRadioButton1";
            this.gunaRadioButton1.Size = new System.Drawing.Size(132, 32);
            this.gunaRadioButton1.TabIndex = 26;
            this.gunaRadioButton1.Text = "Manager";
            this.gunaRadioButton1.CheckedChanged += new System.EventHandler(this.gunaRadioButton1_CheckedChanged);
            // 
            // gunaRadioButton2
            // 
            this.gunaRadioButton2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton2.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton2.CheckedOnColor = System.Drawing.Color.Maroon;
            this.gunaRadioButton2.FillColor = System.Drawing.Color.Maroon;
            this.gunaRadioButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaRadioButton2.ForeColor = System.Drawing.Color.Maroon;
            this.gunaRadioButton2.Location = new System.Drawing.Point(1087, 594);
            this.gunaRadioButton2.Name = "gunaRadioButton2";
            this.gunaRadioButton2.Size = new System.Drawing.Size(141, 32);
            this.gunaRadioButton2.TabIndex = 27;
            this.gunaRadioButton2.Text = "Customer";
            this.gunaRadioButton2.CheckedChanged += new System.EventHandler(this.gunaRadioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 1034);
            this.Controls.Add(this.gunaRadioButton2);
            this.Controls.Add(this.gunaRadioButton1);
            this.Controls.Add(this.gunaTextBox3);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton LoginButton;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaTextBox usernameBox;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaImageButton backHomeButton;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton1;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton2;
    }
}