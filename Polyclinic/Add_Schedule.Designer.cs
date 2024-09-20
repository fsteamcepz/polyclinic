namespace Polyclinic
{
    partial class Add_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Schedule));
            this.gradientPanel1 = new Polyclinic.GradientPanel();
            this.Doctors = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet4 = new Polyclinic.PolyclinicDataSet4();
            this.fridK = new System.Windows.Forms.TextBox();
            this.chetK = new System.Windows.Forms.TextBox();
            this.serK = new System.Windows.Forms.TextBox();
            this.vivK = new System.Windows.Forms.TextBox();
            this.fridE = new System.Windows.Forms.TextBox();
            this.chetE = new System.Windows.Forms.TextBox();
            this.serE = new System.Windows.Forms.TextBox();
            this.fridS = new System.Windows.Forms.TextBox();
            this.chetS = new System.Windows.Forms.TextBox();
            this.serS = new System.Windows.Forms.TextBox();
            this.ponK = new System.Windows.Forms.TextBox();
            this.vivE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.vivS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ponE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ponS = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet3 = new Polyclinic.PolyclinicDataSet3();
            this.doctorTableAdapter = new Polyclinic.PolyclinicDataSet3TableAdapters.DoctorTableAdapter();
            this.doctorTableAdapter1 = new Polyclinic.PolyclinicDataSet4TableAdapters.DoctorTableAdapter();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(38)))), ((int)(((byte)(193)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(243)))));
            this.gradientPanel1.Controls.Add(this.Doctors);
            this.gradientPanel1.Controls.Add(this.fridK);
            this.gradientPanel1.Controls.Add(this.chetK);
            this.gradientPanel1.Controls.Add(this.serK);
            this.gradientPanel1.Controls.Add(this.vivK);
            this.gradientPanel1.Controls.Add(this.fridE);
            this.gradientPanel1.Controls.Add(this.chetE);
            this.gradientPanel1.Controls.Add(this.serE);
            this.gradientPanel1.Controls.Add(this.fridS);
            this.gradientPanel1.Controls.Add(this.chetS);
            this.gradientPanel1.Controls.Add(this.serS);
            this.gradientPanel1.Controls.Add(this.ponK);
            this.gradientPanel1.Controls.Add(this.vivE);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.label14);
            this.gradientPanel1.Controls.Add(this.vivS);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.ponE);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.ponS);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.button7);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Location = new System.Drawing.Point(0, -2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1011, 595);
            this.gradientPanel1.TabIndex = 46;
            // 
            // Doctors
            // 
            this.Doctors.DataSource = this.doctorBindingSource1;
            this.Doctors.DisplayMember = "fullNameDoc";
            this.Doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(377, 154);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(276, 28);
            this.Doctors.TabIndex = 92;
            this.Doctors.ValueMember = "idDoctor";
            this.Doctors.SelectedIndexChanged += new System.EventHandler(this.Doctors_SelectedIndexChanged);
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.polyclinicDataSet4;
            // 
            // polyclinicDataSet4
            // 
            this.polyclinicDataSet4.DataSetName = "PolyclinicDataSet4";
            this.polyclinicDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fridK
            // 
            this.fridK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fridK.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fridK.Location = new System.Drawing.Point(856, 431);
            this.fridK.MaxLength = 3;
            this.fridK.Name = "fridK";
            this.fridK.Size = new System.Drawing.Size(116, 28);
            this.fridK.TabIndex = 91;
            // 
            // chetK
            // 
            this.chetK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chetK.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chetK.Location = new System.Drawing.Point(692, 431);
            this.chetK.MaxLength = 3;
            this.chetK.Name = "chetK";
            this.chetK.Size = new System.Drawing.Size(116, 28);
            this.chetK.TabIndex = 90;
            // 
            // serK
            // 
            this.serK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serK.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serK.Location = new System.Drawing.Point(530, 431);
            this.serK.MaxLength = 3;
            this.serK.Name = "serK";
            this.serK.Size = new System.Drawing.Size(116, 28);
            this.serK.TabIndex = 89;
            // 
            // vivK
            // 
            this.vivK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vivK.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vivK.Location = new System.Drawing.Point(365, 431);
            this.vivK.MaxLength = 3;
            this.vivK.Name = "vivK";
            this.vivK.Size = new System.Drawing.Size(116, 28);
            this.vivK.TabIndex = 88;
            // 
            // fridE
            // 
            this.fridE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fridE.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fridE.Location = new System.Drawing.Point(856, 357);
            this.fridE.MaxLength = 5;
            this.fridE.Name = "fridE";
            this.fridE.Size = new System.Drawing.Size(116, 28);
            this.fridE.TabIndex = 87;
            // 
            // chetE
            // 
            this.chetE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chetE.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chetE.Location = new System.Drawing.Point(692, 357);
            this.chetE.MaxLength = 5;
            this.chetE.Name = "chetE";
            this.chetE.Size = new System.Drawing.Size(116, 28);
            this.chetE.TabIndex = 86;
            // 
            // serE
            // 
            this.serE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serE.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serE.Location = new System.Drawing.Point(530, 357);
            this.serE.MaxLength = 5;
            this.serE.Name = "serE";
            this.serE.Size = new System.Drawing.Size(116, 28);
            this.serE.TabIndex = 85;
            // 
            // fridS
            // 
            this.fridS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fridS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fridS.Location = new System.Drawing.Point(856, 279);
            this.fridS.MaxLength = 5;
            this.fridS.Name = "fridS";
            this.fridS.Size = new System.Drawing.Size(116, 28);
            this.fridS.TabIndex = 84;
            // 
            // chetS
            // 
            this.chetS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chetS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chetS.Location = new System.Drawing.Point(692, 279);
            this.chetS.MaxLength = 5;
            this.chetS.Name = "chetS";
            this.chetS.Size = new System.Drawing.Size(116, 28);
            this.chetS.TabIndex = 83;
            // 
            // serS
            // 
            this.serS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serS.Location = new System.Drawing.Point(530, 279);
            this.serS.MaxLength = 5;
            this.serS.Name = "serS";
            this.serS.Size = new System.Drawing.Size(116, 28);
            this.serS.TabIndex = 82;
            // 
            // ponK
            // 
            this.ponK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ponK.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ponK.Location = new System.Drawing.Point(201, 431);
            this.ponK.MaxLength = 3;
            this.ponK.Name = "ponK";
            this.ponK.Size = new System.Drawing.Size(116, 28);
            this.ponK.TabIndex = 81;
            // 
            // vivE
            // 
            this.vivE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vivE.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vivE.Location = new System.Drawing.Point(365, 357);
            this.vivE.MaxLength = 5;
            this.vivE.Name = "vivE";
            this.vivE.Size = new System.Drawing.Size(116, 28);
            this.vivE.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(23, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 29);
            this.label9.TabIndex = 79;
            this.label9.Text = "Номер кабінету";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(23, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 78;
            this.label8.Text = "Час початку";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(547, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 29);
            this.label7.TabIndex = 77;
            this.label7.Text = "Середа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(708, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "Четвер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(372, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "Вівторок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(859, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 74;
            this.label1.Text = "П\'ятниця";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(196, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 29);
            this.label14.TabIndex = 73;
            this.label14.Text = "Понеділок";
            // 
            // vivS
            // 
            this.vivS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vivS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vivS.Location = new System.Drawing.Point(365, 279);
            this.vivS.MaxLength = 5;
            this.vivS.Name = "vivS";
            this.vivS.Size = new System.Drawing.Size(116, 28);
            this.vivS.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(467, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Головне меню";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ponE
            // 
            this.ponE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ponE.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ponE.Location = new System.Drawing.Point(201, 353);
            this.ponE.MaxLength = 5;
            this.ponE.Name = "ponE";
            this.ponE.Size = new System.Drawing.Size(116, 28);
            this.ponE.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "Час закінчення";
            // 
            // ponS
            // 
            this.ponS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ponS.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ponS.Location = new System.Drawing.Point(201, 279);
            this.ponS.MaxLength = 5;
            this.ponS.Name = "ponS";
            this.ponS.Size = new System.Drawing.Size(116, 28);
            this.ponS.TabIndex = 58;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Polyclinic.Properties.Resources.doctor;
            this.pictureBox2.Location = new System.Drawing.Point(377, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 105);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button7.Location = new System.Drawing.Point(414, 498);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 54);
            this.button7.TabIndex = 52;
            this.button7.Text = "Додати";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(478, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 49);
            this.label2.TabIndex = 51;
            this.label2.Text = "Додавання розкладу";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.polyclinicDataSet3;
            // 
            // polyclinicDataSet3
            // 
            this.polyclinicDataSet3.DataSetName = "PolyclinicDataSet3";
            this.polyclinicDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // Add_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 592);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання розкладу";
            this.Load += new System.EventHandler(this.Add_Schedule_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ponS;
        private System.Windows.Forms.TextBox ponE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vivS;
        private System.Windows.Forms.TextBox fridS;
        private System.Windows.Forms.TextBox chetS;
        private System.Windows.Forms.TextBox serS;
        private System.Windows.Forms.TextBox ponK;
        private System.Windows.Forms.TextBox vivE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox fridE;
        private System.Windows.Forms.TextBox chetE;
        private System.Windows.Forms.TextBox serE;
        private System.Windows.Forms.TextBox fridK;
        private System.Windows.Forms.TextBox chetK;
        private System.Windows.Forms.TextBox serK;
        private System.Windows.Forms.TextBox vivK;
        private System.Windows.Forms.ComboBox Doctors;
        private PolyclinicDataSet3 polyclinicDataSet3;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PolyclinicDataSet3TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private PolyclinicDataSet4 polyclinicDataSet4;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private PolyclinicDataSet4TableAdapters.DoctorTableAdapter doctorTableAdapter1;
    }
}