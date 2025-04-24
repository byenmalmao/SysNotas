namespace SysNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Usertb = new TextBox();
            passwordtb = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            SysPlants = new Label();
            label1 = new Label();
            seepasswordcb = new CheckBox();
            SuspendLayout();
            // 
            // Usertb
            // 
            Usertb.BackColor = Color.Honeydew;
            Usertb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usertb.Location = new Point(101, 167);
            Usertb.Name = "Usertb";
            Usertb.PlaceholderText = "User";
            Usertb.Size = new Size(223, 34);
            Usertb.TabIndex = 0;
            Usertb.TextAlign = HorizontalAlignment.Center;
            Usertb.TextChanged += textBox1_TextChanged;
            // 
            // passwordtb
            // 
            passwordtb.BackColor = Color.Honeydew;
            passwordtb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordtb.Location = new Point(101, 217);
            passwordtb.Name = "passwordtb";
            passwordtb.PlaceholderText = "Password";
            passwordtb.Size = new Size(223, 34);
            passwordtb.TabIndex = 1;
            passwordtb.TextAlign = HorizontalAlignment.Center;
            passwordtb.UseSystemPasswordChar = true;
            passwordtb.TextChanged += passwordtb_TextChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(85, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(77, 74);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(163, 306);
            button1.Name = "button1";
            button1.Size = new Size(107, 44);
            button1.TabIndex = 3;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // SysPlants
            // 
            SysPlants.AutoSize = true;
            SysPlants.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SysPlants.ForeColor = Color.DarkGreen;
            SysPlants.Location = new Point(163, 78);
            SysPlants.Name = "SysPlants";
            SysPlants.Size = new Size(159, 45);
            SysPlants.TabIndex = 4;
            SysPlants.Text = "SysPlants";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 5;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // seepasswordcb
            // 
            seepasswordcb.AutoSize = true;
            seepasswordcb.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seepasswordcb.Location = new Point(191, 257);
            seepasswordcb.Name = "seepasswordcb";
            seepasswordcb.Size = new Size(131, 25);
            seepasswordcb.TabIndex = 7;
            seepasswordcb.Text = "See Password";
            seepasswordcb.UseVisualStyleBackColor = true;
            seepasswordcb.CheckedChanged += seepasswordcb_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(460, 454);
            Controls.Add(seepasswordcb);
            Controls.Add(label1);
            Controls.Add(SysPlants);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(passwordtb);
            Controls.Add(Usertb);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usertb;
        private TextBox passwordtb;
        private Panel panel1;
        private Button button1;
        private Label SysPlants;
        private Label label1;
        private CheckBox seepasswordcb;
    }
}