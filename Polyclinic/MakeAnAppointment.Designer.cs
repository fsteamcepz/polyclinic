namespace Polyclinic
{
    partial class MakeAnAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeAnAppointment));
            this.gradientPanel1 = new Polyclinic.GradientPanel();
            this.viewAllDoc = new System.Windows.Forms.Label();
            this.doctor_box = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet19 = new Polyclinic.PolyclinicDataSet19();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_box = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.spec_box = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet14 = new Polyclinic.PolyclinicDataSet14();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet17 = new Polyclinic.PolyclinicDataSet17();
            this.doctorTableAdapter = new Polyclinic.PolyclinicDataSet14TableAdapters.DoctorTableAdapter();
            this.doctorTableAdapter1 = new Polyclinic.PolyclinicDataSet17TableAdapters.DoctorTableAdapter();
            this.polyclinicDataSet18 = new Polyclinic.PolyclinicDataSet18();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new Polyclinic.PolyclinicDataSet18TableAdapters.ScheduleTableAdapter();
            this.doctorTableAdapter2 = new Polyclinic.PolyclinicDataSet19TableAdapters.DoctorTableAdapter();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(38)))), ((int)(((byte)(193)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(243)))));
            this.gradientPanel1.Controls.Add(this.viewAllDoc);
            this.gradientPanel1.Controls.Add(this.doctor_box);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.date_box);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.button6);
            this.gradientPanel1.Controls.Add(this.spec_box);
            this.gradientPanel1.Controls.Add(this.label14);
            this.gradientPanel1.Controls.Add(this.button7);
            this.gradientPanel1.Controls.Add(this.button5);
            this.gradientPanel1.Controls.Add(this.button4);
            this.gradientPanel1.Controls.Add(this.button2);
            this.gradientPanel1.Controls.Add(this.button3);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1136, 492);
            this.gradientPanel1.TabIndex = 43;
            // 
            // viewAllDoc
            // 
            this.viewAllDoc.AutoSize = true;
            this.viewAllDoc.BackColor = System.Drawing.Color.Transparent;
            this.viewAllDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllDoc.ForeColor = System.Drawing.Color.Fuchsia;
            this.viewAllDoc.Location = new System.Drawing.Point(1013, 109);
            this.viewAllDoc.Margin = new System.Windows.Forms.Padding(0);
            this.viewAllDoc.Name = "viewAllDoc";
            this.viewAllDoc.Size = new System.Drawing.Size(25, 25);
            this.viewAllDoc.TabIndex = 78;
            this.viewAllDoc.Text = "●";
            this.viewAllDoc.Click += new System.EventHandler(this.viewAllDoc_Click);
            // 
            // doctor_box
            // 
            this.doctor_box.DataSource = this.doctorBindingSource2;
            this.doctor_box.DisplayMember = "fullNameDoc";
            this.doctor_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctor_box.FormattingEnabled = true;
            this.doctor_box.Location = new System.Drawing.Point(671, 178);
            this.doctor_box.Name = "doctor_box";
            this.doctor_box.Size = new System.Drawing.Size(313, 28);
            this.doctor_box.TabIndex = 77;
            // 
            // doctorBindingSource2
            // 
            this.doctorBindingSource2.DataMember = "Doctor";
            this.doctorBindingSource2.DataSource = this.polyclinicDataSet19;
            // 
            // polyclinicDataSet19
            // 
            this.polyclinicDataSet19.DataSetName = "PolyclinicDataSet19";
            this.polyclinicDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(491, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 49);
            this.label4.TabIndex = 76;
            this.label4.Text = "Записатися на прийом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(395, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "ПІБ лікаря";
            // 
            // date_box
            // 
            this.date_box.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date_box.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.date_box.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.date_box.Checked = false;
            this.date_box.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_box.Location = new System.Drawing.Point(671, 240);
            this.date_box.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.date_box.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(313, 26);
            this.date_box.TabIndex = 67;
            this.date_box.ValueChanged += new System.EventHandler(this.dateTimeD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(395, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Дата";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button6.Location = new System.Drawing.Point(740, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 52);
            this.button6.TabIndex = 59;
            this.button6.Text = "Записатися";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // spec_box
            // 
            this.spec_box.DataSource = this.doctorBindingSource;
            this.spec_box.DisplayMember = "specialization";
            this.spec_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spec_box.FormattingEnabled = true;
            this.spec_box.Location = new System.Drawing.Point(671, 110);
            this.spec_box.Name = "spec_box";
            this.spec_box.Size = new System.Drawing.Size(313, 28);
            this.spec_box.TabIndex = 58;
            this.spec_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.polyclinicDataSet14;
            // 
            // polyclinicDataSet14
            // 
            this.polyclinicDataSet14.DataSetName = "PolyclinicDataSet14";
            this.polyclinicDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(395, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 29);
            this.label14.TabIndex = 57;
            this.label14.Text = "Оберіть спеціальність";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button7.Location = new System.Drawing.Point(686, 414);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(212, 52);
            this.button7.TabIndex = 49;
            this.button7.Text = "Головне меню";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button5.Location = new System.Drawing.Point(926, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 52);
            this.button5.TabIndex = 43;
            this.button5.Text = "Вихід";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(88)))), ((int)(((byte)(238)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(36, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 59);
            this.button4.TabIndex = 42;
            this.button4.Text = "Отримати послугу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(243)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(36, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 59);
            this.button2.TabIndex = 41;
            this.button2.Text = "Запис на прийом";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(88)))), ((int)(((byte)(238)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(36, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 59);
            this.button3.TabIndex = 39;
            this.button3.Text = "Знайти лікаря";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            this.doctorBindingSource1.DataSource = this.polyclinicDataSet17;
            // 
            // polyclinicDataSet17
            // 
            this.polyclinicDataSet17.DataSetName = "PolyclinicDataSet17";
            this.polyclinicDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // polyclinicDataSet18
            // 
            this.polyclinicDataSet18.DataSetName = "PolyclinicDataSet18";
            this.polyclinicDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.polyclinicDataSet18;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter2
            // 
            this.doctorTableAdapter2.ClearBeforeFill = true;
            // 
            // MakeAnAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 490);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeAnAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записатися на прийом";
            this.Load += new System.EventHandler(this.MakeAnAppointment_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox spec_box;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private PolyclinicDataSet14 polyclinicDataSet14;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PolyclinicDataSet14TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private PolyclinicDataSet17 polyclinicDataSet17;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private PolyclinicDataSet17TableAdapters.DoctorTableAdapter doctorTableAdapter1;
        private PolyclinicDataSet18 polyclinicDataSet18;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private PolyclinicDataSet18TableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.DateTimePicker date_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctor_box;
        private System.Windows.Forms.Label viewAllDoc;
        private PolyclinicDataSet19 polyclinicDataSet19;
        private System.Windows.Forms.BindingSource doctorBindingSource2;
        private PolyclinicDataSet19TableAdapters.DoctorTableAdapter doctorTableAdapter2;
    }
}