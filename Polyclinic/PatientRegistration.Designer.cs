namespace Polyclinic
{
    partial class PatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegistration));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.insuranceNumberP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.addressP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.phoneP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateP = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.idP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passP = new System.Windows.Forms.TextBox();
            this.checkPassPat = new System.Windows.Forms.CheckBox();
            this.familyDoctorP = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet = new Polyclinic.PolyclinicDataSet();
            this.doctorTableAdapter = new Polyclinic.PolyclinicDataSetTableAdapters.DoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(662, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 44);
            this.button2.TabIndex = 65;
            this.button2.Text = "Вихід";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(251, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 64;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(407, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 44);
            this.button3.TabIndex = 63;
            this.button3.Text = "Реєстрація";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.registrationPatient);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "Сімейний лікар";
            // 
            // insuranceNumberP
            // 
            this.insuranceNumberP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insuranceNumberP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insuranceNumberP.Location = new System.Drawing.Point(724, 154);
            this.insuranceNumberP.MaxLength = 8;
            this.insuranceNumberP.Name = "insuranceNumberP";
            this.insuranceNumberP.Size = new System.Drawing.Size(248, 28);
            this.insuranceNumberP.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(529, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 26);
            this.label13.TabIndex = 60;
            this.label13.Text = "Номер страховки";
            // 
            // addressP
            // 
            this.addressP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressP.Location = new System.Drawing.Point(221, 216);
            this.addressP.MaxLength = 40;
            this.addressP.Name = "addressP";
            this.addressP.Size = new System.Drawing.Size(276, 28);
            this.addressP.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(18, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 26);
            this.label14.TabIndex = 58;
            this.label14.Text = "Адреса проживання";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(529, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 26);
            this.label16.TabIndex = 57;
            this.label16.Text = "Телефон";
            // 
            // phoneP
            // 
            this.phoneP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneP.Location = new System.Drawing.Point(724, 213);
            this.phoneP.MaxLength = 10;
            this.phoneP.Name = "phoneP";
            this.phoneP.Size = new System.Drawing.Size(248, 28);
            this.phoneP.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(529, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 26);
            this.label15.TabIndex = 55;
            this.label15.Text = "Дата народження";
            // 
            // dateP
            // 
            this.dateP.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateP.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateP.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.dateP.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateP.Location = new System.Drawing.Point(724, 94);
            this.dateP.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateP.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateP.Name = "dateP";
            this.dateP.Size = new System.Drawing.Size(248, 26);
            this.dateP.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(16, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 26);
            this.label17.TabIndex = 53;
            this.label17.Text = "ІПН";
            // 
            // idP
            // 
            this.idP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idP.Location = new System.Drawing.Point(221, 157);
            this.idP.MaxLength = 10;
            this.idP.Name = "idP";
            this.idP.Size = new System.Drawing.Size(276, 28);
            this.idP.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "ПІБ";
            // 
            // fullNameP
            // 
            this.fullNameP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullNameP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameP.Location = new System.Drawing.Point(221, 95);
            this.fullNameP.MaxLength = 40;
            this.fullNameP.Name = "fullNameP";
            this.fullNameP.Size = new System.Drawing.Size(276, 28);
            this.fullNameP.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 49);
            this.label1.TabIndex = 49;
            this.label1.Text = "Введіть дані про пацієнта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(529, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 71;
            this.label3.Text = "Пароль";
            // 
            // passP
            // 
            this.passP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passP.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passP.Location = new System.Drawing.Point(724, 276);
            this.passP.MaxLength = 32;
            this.passP.Name = "passP";
            this.passP.Size = new System.Drawing.Size(248, 28);
            this.passP.TabIndex = 72;
            this.passP.UseSystemPasswordChar = true;
            // 
            // checkPassPat
            // 
            this.checkPassPat.AutoSize = true;
            this.checkPassPat.BackColor = System.Drawing.Color.Transparent;
            this.checkPassPat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPassPat.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkPassPat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkPassPat.Location = new System.Drawing.Point(823, 313);
            this.checkPassPat.Name = "checkPassPat";
            this.checkPassPat.Size = new System.Drawing.Size(154, 24);
            this.checkPassPat.TabIndex = 73;
            this.checkPassPat.Text = "Показати пароль";
            this.checkPassPat.UseVisualStyleBackColor = false;
            this.checkPassPat.CheckedChanged += new System.EventHandler(this.checkPassPat_CheckedChanged_1);
            // 
            // familyDoctorP
            // 
            this.familyDoctorP.DataSource = this.doctorBindingSource;
            this.familyDoctorP.DisplayMember = "fullNameDoc";
            this.familyDoctorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.familyDoctorP.FormattingEnabled = true;
            this.familyDoctorP.Location = new System.Drawing.Point(221, 273);
            this.familyDoctorP.Name = "familyDoctorP";
            this.familyDoctorP.Size = new System.Drawing.Size(276, 28);
            this.familyDoctorP.TabIndex = 74;
            this.familyDoctorP.ValueMember = "idDoctor";
            this.familyDoctorP.SelectedIndexChanged += new System.EventHandler(this.familyDoctorP_SelectedIndexChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.polyclinicDataSet;
            // 
            // polyclinicDataSet
            // 
            this.polyclinicDataSet.DataSetName = "PolyclinicDataSet";
            this.polyclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1005, 476);
            this.Controls.Add(this.familyDoctorP);
            this.Controls.Add(this.checkPassPat);
            this.Controls.Add(this.passP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insuranceNumberP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.addressP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.phoneP);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateP);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.idP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameP);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація пацієнта";
            this.Load += new System.EventHandler(this.PatientRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insuranceNumberP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox addressP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox phoneP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox idP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passP;
        private System.Windows.Forms.CheckBox checkPassPat;
        private System.Windows.Forms.ComboBox familyDoctorP;
        private PolyclinicDataSet polyclinicDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PolyclinicDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
    }
}