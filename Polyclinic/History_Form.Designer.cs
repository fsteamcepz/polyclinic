namespace Polyclinic
{
    partial class History_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History_Form));
            this.gradientPanel1 = new Polyclinic.GradientPanel();
            this.pib_box = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet10 = new Polyclinic.PolyclinicDataSet10();
            this.diagnos_box = new System.Windows.Forms.ComboBox();
            this.diagnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet13 = new Polyclinic.PolyclinicDataSet13();
            this.service_box = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet11 = new Polyclinic.PolyclinicDataSet11();
            this.date_box = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.polyclinicDataSet9 = new Polyclinic.PolyclinicDataSet9();
            this.patientTableAdapter = new Polyclinic.PolyclinicDataSet10TableAdapters.PatientTableAdapter();
            this.serviceTableAdapter = new Polyclinic.PolyclinicDataSet11TableAdapters.ServiceTableAdapter();
            this.polyclinicDataSet12 = new Polyclinic.PolyclinicDataSet12();
            this.diagnosTableAdapter = new Polyclinic.PolyclinicDataSet13TableAdapters.DiagnosTableAdapter();
            this.result_box = new System.Windows.Forms.ComboBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(38)))), ((int)(((byte)(193)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(243)))));
            this.gradientPanel1.Controls.Add(this.result_box);
            this.gradientPanel1.Controls.Add(this.pib_box);
            this.gradientPanel1.Controls.Add(this.diagnos_box);
            this.gradientPanel1.Controls.Add(this.service_box);
            this.gradientPanel1.Controls.Add(this.date_box);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label14);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.button7);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, -2);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(658, 540);
            this.gradientPanel1.TabIndex = 47;
            // 
            // pib_box
            // 
            this.pib_box.DataSource = this.patientBindingSource;
            this.pib_box.DisplayMember = "fullNamePat";
            this.pib_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pib_box.FormattingEnabled = true;
            this.pib_box.Location = new System.Drawing.Point(266, 106);
            this.pib_box.Name = "pib_box";
            this.pib_box.Size = new System.Drawing.Size(340, 28);
            this.pib_box.TabIndex = 93;
            this.pib_box.ValueMember = "idPatient";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.polyclinicDataSet10;
            // 
            // polyclinicDataSet10
            // 
            this.polyclinicDataSet10.DataSetName = "PolyclinicDataSet10";
            this.polyclinicDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnos_box
            // 
            this.diagnos_box.DataSource = this.diagnosBindingSource;
            this.diagnos_box.DisplayMember = "nameDiagnos";
            this.diagnos_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnos_box.FormattingEnabled = true;
            this.diagnos_box.Location = new System.Drawing.Point(263, 347);
            this.diagnos_box.Name = "diagnos_box";
            this.diagnos_box.Size = new System.Drawing.Size(340, 28);
            this.diagnos_box.TabIndex = 92;
            this.diagnos_box.ValueMember = "idDiagnos";
            // 
            // diagnosBindingSource
            // 
            this.diagnosBindingSource.DataMember = "Diagnos";
            this.diagnosBindingSource.DataSource = this.polyclinicDataSet13;
            // 
            // polyclinicDataSet13
            // 
            this.polyclinicDataSet13.DataSetName = "PolyclinicDataSet13";
            this.polyclinicDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_box
            // 
            this.service_box.DataSource = this.serviceBindingSource;
            this.service_box.DisplayMember = "typeService";
            this.service_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.service_box.FormattingEnabled = true;
            this.service_box.Location = new System.Drawing.Point(266, 227);
            this.service_box.Name = "service_box";
            this.service_box.Size = new System.Drawing.Size(340, 28);
            this.service_box.TabIndex = 91;
            this.service_box.ValueMember = "idService";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.polyclinicDataSet11;
            // 
            // polyclinicDataSet11
            // 
            this.polyclinicDataSet11.DataSetName = "PolyclinicDataSet11";
            this.polyclinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // date_box
            // 
            this.date_box.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date_box.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText;
            this.date_box.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.date_box.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_box.Location = new System.Drawing.Point(266, 168);
            this.date_box.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.date_box.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(340, 26);
            this.date_box.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(43, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 29);
            this.label9.TabIndex = 79;
            this.label9.Text = "Дата прийому";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(43, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 78;
            this.label8.Text = "ПІБ пацієнта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "Діагноз";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(43, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 29);
            this.label14.TabIndex = 73;
            this.label14.Text = "Вид послуги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(259, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Головне меню";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(43, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "Результат прийому";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button7.Location = new System.Drawing.Point(206, 425);
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
            this.label2.Location = new System.Drawing.Point(257, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 49);
            this.label2.TabIndex = 51;
            this.label2.Text = "Прийом";
            // 
            // polyclinicDataSet9
            // 
            this.polyclinicDataSet9.DataSetName = "PolyclinicDataSet9";
            this.polyclinicDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // polyclinicDataSet12
            // 
            this.polyclinicDataSet12.DataSetName = "PolyclinicDataSet12";
            this.polyclinicDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosTableAdapter
            // 
            this.diagnosTableAdapter.ClearBeforeFill = true;
            // 
            // result_box
            // 
            this.result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_box.FormattingEnabled = true;
            this.result_box.Items.AddRange(new object[] {
            "Завершено",
            "Не завершено"});
            this.result_box.Location = new System.Drawing.Point(266, 289);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(340, 28);
            this.result_box.TabIndex = 94;
            // 
            // History_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 536);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прийом";
            this.Load += new System.EventHandler(this.History_Form_Load_1);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_box;
        private System.Windows.Forms.ComboBox service_box;
        private System.Windows.Forms.ComboBox diagnos_box;
        private System.Windows.Forms.ComboBox pib_box;
        private PolyclinicDataSet9 polyclinicDataSet9;
        private PolyclinicDataSet10 polyclinicDataSet10;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private PolyclinicDataSet10TableAdapters.PatientTableAdapter patientTableAdapter;
        private PolyclinicDataSet11 polyclinicDataSet11;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private PolyclinicDataSet11TableAdapters.ServiceTableAdapter serviceTableAdapter;
        private PolyclinicDataSet12 polyclinicDataSet12;
        private PolyclinicDataSet13 polyclinicDataSet13;
        private System.Windows.Forms.BindingSource diagnosBindingSource;
        private PolyclinicDataSet13TableAdapters.DiagnosTableAdapter diagnosTableAdapter;
        private System.Windows.Forms.ComboBox result_box;
    }
}