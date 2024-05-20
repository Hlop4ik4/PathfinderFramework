namespace PathfinderFramework
{
    partial class FormTrainingCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCourseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTrainingType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOrganizer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxTrainingHoursFrom = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxTrainingHoursTo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxAmountHours = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxSkillLevel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonChangeEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeTrainingCourseIsComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCertificateImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // maskedTextBoxYear
            // 
            this.maskedTextBoxYear.Location = new System.Drawing.Point(86, 86);
            this.maskedTextBoxYear.Mask = "0000";
            this.maskedTextBoxYear.Name = "maskedTextBoxYear";
            this.maskedTextBoxYear.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxYear.TabIndex = 1;
            this.maskedTextBoxYear.ValidatingType = typeof(int);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(87, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вид";
            // 
            // comboBoxCourseType
            // 
            this.comboBoxCourseType.FormattingEnabled = true;
            this.comboBoxCourseType.Items.AddRange(new object[] {
            "Повышение квалификации",
            "Получение образования",
            "Переквалификация"});
            this.comboBoxCourseType.Location = new System.Drawing.Point(87, 32);
            this.comboBoxCourseType.Name = "comboBoxCourseType";
            this.comboBoxCourseType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCourseType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип";
            // 
            // comboBoxTrainingType
            // 
            this.comboBoxTrainingType.FormattingEnabled = true;
            this.comboBoxTrainingType.Items.AddRange(new object[] {
            "Очная",
            "Заочная"});
            this.comboBoxTrainingType.Location = new System.Drawing.Point(87, 59);
            this.comboBoxTrainingType.Name = "comboBoxTrainingType";
            this.comboBoxTrainingType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrainingType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Организатор";
            // 
            // textBoxOrganizer
            // 
            this.textBoxOrganizer.Location = new System.Drawing.Point(87, 112);
            this.textBoxOrganizer.Name = "textBoxOrganizer";
            this.textBoxOrganizer.Size = new System.Drawing.Size(121, 20);
            this.textBoxOrganizer.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Место проведения";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(322, 6);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(121, 20);
            this.textBoxLocation.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Время занятий: с";
            // 
            // maskedTextBoxTrainingHoursFrom
            // 
            this.maskedTextBoxTrainingHoursFrom.Location = new System.Drawing.Point(321, 32);
            this.maskedTextBoxTrainingHoursFrom.Mask = "00:00";
            this.maskedTextBoxTrainingHoursFrom.Name = "maskedTextBoxTrainingHoursFrom";
            this.maskedTextBoxTrainingHoursFrom.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxTrainingHoursFrom.TabIndex = 1;
            this.maskedTextBoxTrainingHoursFrom.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "по";
            // 
            // maskedTextBoxTrainingHoursTo
            // 
            this.maskedTextBoxTrainingHoursTo.Location = new System.Drawing.Point(475, 32);
            this.maskedTextBoxTrainingHoursTo.Mask = "00:00";
            this.maskedTextBoxTrainingHoursTo.Name = "maskedTextBoxTrainingHoursTo";
            this.maskedTextBoxTrainingHoursTo.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxTrainingHoursTo.TabIndex = 1;
            this.maskedTextBoxTrainingHoursTo.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Количество часов";
            // 
            // maskedTextBoxAmountHours
            // 
            this.maskedTextBoxAmountHours.Location = new System.Drawing.Point(322, 58);
            this.maskedTextBoxAmountHours.Mask = "00000";
            this.maskedTextBoxAmountHours.Name = "maskedTextBoxAmountHours";
            this.maskedTextBoxAmountHours.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxAmountHours.TabIndex = 1;
            this.maskedTextBoxAmountHours.ValidatingType = typeof(decimal);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Уровень навыка";
            // 
            // comboBoxSkillLevel
            // 
            this.comboBoxSkillLevel.FormattingEnabled = true;
            this.comboBoxSkillLevel.Location = new System.Drawing.Point(321, 85);
            this.comboBoxSkillLevel.Name = "comboBoxSkillLevel";
            this.comboBoxSkillLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSkillLevel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonChangeEmployee);
            this.groupBox1.Controls.Add(this.buttonDeleteEmployee);
            this.groupBox1.Controls.Add(this.buttonAddEmployee);
            this.groupBox1.Controls.Add(this.dataGridViewEmployees);
            this.groupBox1.Location = new System.Drawing.Point(11, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // buttonChangeEmployee
            // 
            this.buttonChangeEmployee.Location = new System.Drawing.Point(505, 77);
            this.buttonChangeEmployee.Name = "buttonChangeEmployee";
            this.buttonChangeEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeEmployee.TabIndex = 8;
            this.buttonChangeEmployee.Text = "Изменить";
            this.buttonChangeEmployee.UseVisualStyleBackColor = true;
            this.buttonChangeEmployee.Click += new System.EventHandler(this.buttonChangeEmployee_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(505, 48);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteEmployee.TabIndex = 8;
            this.buttonDeleteEmployee.Text = "Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(505, 19);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmployee.TabIndex = 8;
            this.buttonAddEmployee.Text = "Выбрать";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeFullName,
            this.EmployeeTrainingCourseIsComplete,
            this.EmployeeCertificateImagePath});
            this.dataGridViewEmployees.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(493, 174);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(525, 352);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(444, 352);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.HeaderText = "Полное имя";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // EmployeeTrainingCourseIsComplete
            // 
            this.EmployeeTrainingCourseIsComplete.HeaderText = "Курс завершен";
            this.EmployeeTrainingCourseIsComplete.Name = "EmployeeTrainingCourseIsComplete";
            this.EmployeeTrainingCourseIsComplete.ReadOnly = true;
            // 
            // EmployeeCertificateImagePath
            // 
            this.EmployeeCertificateImagePath.HeaderText = "CertificateImagePath";
            this.EmployeeCertificateImagePath.Name = "EmployeeCertificateImagePath";
            this.EmployeeCertificateImagePath.ReadOnly = true;
            this.EmployeeCertificateImagePath.Visible = false;
            // 
            // FormTrainingCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxTrainingType);
            this.Controls.Add(this.comboBoxSkillLevel);
            this.Controls.Add(this.comboBoxCourseType);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxOrganizer);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.maskedTextBoxTrainingHoursTo);
            this.Controls.Add(this.maskedTextBoxTrainingHoursFrom);
            this.Controls.Add(this.maskedTextBoxAmountHours);
            this.Controls.Add(this.maskedTextBoxYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormTrainingCourse";
            this.Text = "Курс";
            this.Load += new System.EventHandler(this.FormTrainingCourse_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYear;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCourseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTrainingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOrganizer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTrainingHoursFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTrainingHoursTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAmountHours;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxSkillLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChangeEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeTrainingCourseIsComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCertificateImagePath;
    }
}