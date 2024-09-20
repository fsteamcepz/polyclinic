namespace Polyclinic
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.gradientPanel2 = new Polyclinic.GradientPanel();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginToAcc = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.polyclinicDataSet1 = new Polyclinic.PolyclinicDataSet();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(36)))), ((int)(((byte)(239)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.gradientPanel2.Controls.Add(this.checkPass);
            this.gradientPanel2.Controls.Add(this.pictureBox5);
            this.gradientPanel2.Controls.Add(this.loginPassword);
            this.gradientPanel2.Controls.Add(this.login);
            this.gradientPanel2.Controls.Add(this.label4);
            this.gradientPanel2.Controls.Add(this.loginToAcc);
            this.gradientPanel2.Controls.Add(this.pictureBox4);
            this.gradientPanel2.Controls.Add(this.pictureBox3);
            this.gradientPanel2.Controls.Add(this.label3);
            this.gradientPanel2.Location = new System.Drawing.Point(-2, -1);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(596, 526);
            this.gradientPanel2.TabIndex = 0;
            this.gradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel2_Paint);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.BackColor = System.Drawing.Color.Transparent;
            this.checkPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPass.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkPass.Location = new System.Drawing.Point(335, 343);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(154, 24);
            this.checkPass.TabIndex = 8;
            this.checkPass.Text = "Показати пароль";
            this.checkPass.UseVisualStyleBackColor = false;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Polyclinic.Properties.Resources.login;
            this.pictureBox5.Location = new System.Drawing.Point(223, 56);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 50);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPassword.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPassword.Location = new System.Drawing.Point(156, 305);
            this.loginPassword.MaxLength = 32;
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(333, 28);
            this.loginPassword.TabIndex = 6;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(156, 191);
            this.login.MaxLength = 50;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(333, 28);
            this.login.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(293, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Назад";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginToAcc
            // 
            this.loginToAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(36)))), ((int)(((byte)(239)))));
            this.loginToAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginToAcc.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginToAcc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginToAcc.Location = new System.Drawing.Point(205, 395);
            this.loginToAcc.Name = "loginToAcc";
            this.loginToAcc.Size = new System.Drawing.Size(221, 51);
            this.loginToAcc.TabIndex = 3;
            this.loginToAcc.Text = "Увійти";
            this.loginToAcc.UseVisualStyleBackColor = false;
            this.loginToAcc.Click += new System.EventHandler(this.loginToAcc_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Polyclinic.Properties.Resources.user2;
            this.pictureBox4.Location = new System.Drawing.Point(90, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 48);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Polyclinic.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(90, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 50);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(276, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 49);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вхід";
            // 
            // polyclinicDataSet1
            // 
            this.polyclinicDataSet1.DataSetName = "PolyclinicDataSet";
            this.polyclinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(592, 525);
            this.Controls.Add(this.gradientPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вхід";
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.ComponentModel.BackgroundWorker backgroundWorker1;
        //private GradientPanel gradientPanel1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.TextBox textBox4;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.PictureBox pictureBox1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginToAcc;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox checkPass;
        private PolyclinicDataSet polyclinicDataSet1;
    }
}