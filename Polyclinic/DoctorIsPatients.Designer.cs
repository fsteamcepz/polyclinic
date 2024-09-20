namespace Polyclinic
{
    partial class DoctorIsPatients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorIsPatients));
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyclinicDataSet1 = new Polyclinic.PolyclinicDataSet1();
            this.patientTableAdapter = new Polyclinic.PolyclinicDataSet1TableAdapters.PatientTableAdapter();
            this.polyclinicDataSet = new Polyclinic.PolyclinicDataSet();
            this.doctorTableAdapter = new Polyclinic.PolyclinicDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new Polyclinic.PolyclinicDataSetTableAdapters.TableAdapterManager();
            this.polyclinicDataSet2 = new Polyclinic.PolyclinicDataSet2();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter1 = new Polyclinic.PolyclinicDataSet2TableAdapters.DoctorTableAdapter();
            this.gradientPanel1 = new Polyclinic.GradientPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.patients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients)).BeginInit();
            this.SuspendLayout();
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.polyclinicDataSet1;
            // 
            // polyclinicDataSet1
            // 
            this.polyclinicDataSet1.DataSetName = "PolyclinicDataSet1";
            this.polyclinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.UpdateOrder = Polyclinic.PolyclinicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // polyclinicDataSet2
            // 
            this.polyclinicDataSet2.DataSetName = "PolyclinicDataSet2";
            this.polyclinicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.polyclinicDataSet2;
            // 
            // doctorTableAdapter1
            // 
            this.doctorTableAdapter1.ClearBeforeFill = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(38)))), ((int)(((byte)(193)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(243)))));
            this.gradientPanel1.Controls.Add(this.button8);
            this.gradientPanel1.Controls.Add(this.button9);
            this.gradientPanel1.Controls.Add(this.patients);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.button6);
            this.gradientPanel1.Controls.Add(this.button5);
            this.gradientPanel1.Controls.Add(this.button3);
            this.gradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1139, 495);
            this.gradientPanel1.TabIndex = 45;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(243)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(36, 319);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(273, 59);
            this.button8.TabIndex = 87;
            this.button8.Text = "Історія прийомів";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(243)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Location = new System.Drawing.Point(36, 210);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(273, 59);
            this.button9.TabIndex = 86;
            this.button9.Text = "Розклад на тиждень";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // patients
            // 
            this.patients.AllowUserToAddRows = false;
            this.patients.AllowUserToDeleteRows = false;
            this.patients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(88)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patients.DefaultCellStyle = dataGridViewCellStyle1;
            this.patients.Location = new System.Drawing.Point(353, 75);
            this.patients.Name = "patients";
            this.patients.ReadOnly = true;
            this.patients.Size = new System.Drawing.Size(755, 313);
            this.patients.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(528, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 49);
            this.label1.TabIndex = 48;
            this.label1.Text = "Перелік всіх пацієнтів";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button6.Location = new System.Drawing.Point(671, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 60);
            this.button6.TabIndex = 46;
            this.button6.Text = "Головне меню";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(16)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.button5.Location = new System.Drawing.Point(904, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 60);
            this.button5.TabIndex = 45;
            this.button5.Text = "Вихід";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(88)))), ((int)(((byte)(238)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(36, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 60);
            this.button3.TabIndex = 39;
            this.button3.Text = "Інформація про хворих";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // DoctorIsPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 494);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorIsPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інформація про хворих";
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyclinicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patients;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private PolyclinicDataSet1 polyclinicDataSet1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private PolyclinicDataSet1TableAdapters.PatientTableAdapter patientTableAdapter;
        private PolyclinicDataSet polyclinicDataSet;
        private PolyclinicDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private PolyclinicDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PolyclinicDataSet2 polyclinicDataSet2;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PolyclinicDataSet2TableAdapters.DoctorTableAdapter doctorTableAdapter1;
    }
}