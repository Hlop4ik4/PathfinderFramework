namespace PathfinderFramework
{
    partial class FormEmployee
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSkills = new System.Windows.Forms.DataGridView();
            this.SkillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdateSkills = new System.Windows.Forms.Button();
            this.buttonDeleteSkill = new System.Windows.Forms.Button();
            this.buttonAddSkill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDepartments = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdateDepartment = new System.Windows.Forms.Button();
            this.buttonDeleteDepartment = new System.Windows.Forms.Button();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(870, 511);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSkills);
            this.groupBox2.Controls.Add(this.buttonUpdateSkills);
            this.groupBox2.Controls.Add(this.buttonDeleteSkill);
            this.groupBox2.Controls.Add(this.buttonAddSkill);
            this.groupBox2.Location = new System.Drawing.Point(482, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 393);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Навыки";
            // 
            // dataGridViewSkills
            // 
            this.dataGridViewSkills.AllowUserToAddRows = false;
            this.dataGridViewSkills.AllowUserToDeleteRows = false;
            this.dataGridViewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SkillId,
            this.SkillName,
            this.SkillLevel});
            this.dataGridViewSkills.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewSkills.Name = "dataGridViewSkills";
            this.dataGridViewSkills.ReadOnly = true;
            this.dataGridViewSkills.Size = new System.Drawing.Size(367, 365);
            this.dataGridViewSkills.TabIndex = 2;
            // 
            // SkillId
            // 
            this.SkillId.HeaderText = "SkillId";
            this.SkillId.Name = "SkillId";
            this.SkillId.ReadOnly = true;
            this.SkillId.Visible = false;
            // 
            // SkillName
            // 
            this.SkillName.HeaderText = "Название";
            this.SkillName.Name = "SkillName";
            this.SkillName.ReadOnly = true;
            // 
            // SkillLevel
            // 
            this.SkillLevel.HeaderText = "Уровень";
            this.SkillLevel.Name = "SkillLevel";
            this.SkillLevel.ReadOnly = true;
            // 
            // buttonUpdateSkills
            // 
            this.buttonUpdateSkills.Location = new System.Drawing.Point(379, 138);
            this.buttonUpdateSkills.Name = "buttonUpdateSkills";
            this.buttonUpdateSkills.Size = new System.Drawing.Size(75, 52);
            this.buttonUpdateSkills.TabIndex = 1;
            this.buttonUpdateSkills.Text = "Обновить таблицу";
            this.buttonUpdateSkills.UseVisualStyleBackColor = true;
            this.buttonUpdateSkills.Click += new System.EventHandler(this.buttonUpdateSkills_Click);
            // 
            // buttonDeleteSkill
            // 
            this.buttonDeleteSkill.Location = new System.Drawing.Point(379, 80);
            this.buttonDeleteSkill.Name = "buttonDeleteSkill";
            this.buttonDeleteSkill.Size = new System.Drawing.Size(75, 52);
            this.buttonDeleteSkill.TabIndex = 1;
            this.buttonDeleteSkill.Text = "Удалить навык";
            this.buttonDeleteSkill.UseVisualStyleBackColor = true;
            this.buttonDeleteSkill.Click += new System.EventHandler(this.buttonDeleteSkill_Click);
            // 
            // buttonAddSkill
            // 
            this.buttonAddSkill.Location = new System.Drawing.Point(379, 22);
            this.buttonAddSkill.Name = "buttonAddSkill";
            this.buttonAddSkill.Size = new System.Drawing.Size(75, 52);
            this.buttonAddSkill.TabIndex = 1;
            this.buttonAddSkill.Text = "Добавить навык";
            this.buttonAddSkill.UseVisualStyleBackColor = true;
            this.buttonAddSkill.Click += new System.EventHandler(this.buttonAddSkill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Полное имя";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(104, 6);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFullName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Образование";
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(104, 32);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(200, 21);
            this.comboBoxEducation.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(104, 59);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 9;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2024, 4, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(104, 85);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGender.TabIndex = 10;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(789, 511);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDepartments);
            this.groupBox1.Controls.Add(this.buttonUpdateDepartment);
            this.groupBox1.Controls.Add(this.buttonDeleteDepartment);
            this.groupBox1.Controls.Add(this.buttonAddDepartment);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 393);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отделы";
            // 
            // dataGridViewDepartments
            // 
            this.dataGridViewDepartments.AllowUserToAddRows = false;
            this.dataGridViewDepartments.AllowUserToDeleteRows = false;
            this.dataGridViewDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DepartmentName});
            this.dataGridViewDepartments.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewDepartments.Name = "dataGridViewDepartments";
            this.dataGridViewDepartments.ReadOnly = true;
            this.dataGridViewDepartments.Size = new System.Drawing.Size(367, 365);
            this.dataGridViewDepartments.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DepartmentName
            // 
            this.DepartmentName.HeaderText = "Название";
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.ReadOnly = true;
            // 
            // buttonUpdateDepartment
            // 
            this.buttonUpdateDepartment.Location = new System.Drawing.Point(379, 138);
            this.buttonUpdateDepartment.Name = "buttonUpdateDepartment";
            this.buttonUpdateDepartment.Size = new System.Drawing.Size(75, 52);
            this.buttonUpdateDepartment.TabIndex = 1;
            this.buttonUpdateDepartment.Text = "Обновить таблицу";
            this.buttonUpdateDepartment.UseVisualStyleBackColor = true;
            this.buttonUpdateDepartment.Click += new System.EventHandler(this.buttonUpdateDepartment_Click);
            // 
            // buttonDeleteDepartment
            // 
            this.buttonDeleteDepartment.Location = new System.Drawing.Point(379, 80);
            this.buttonDeleteDepartment.Name = "buttonDeleteDepartment";
            this.buttonDeleteDepartment.Size = new System.Drawing.Size(75, 52);
            this.buttonDeleteDepartment.TabIndex = 1;
            this.buttonDeleteDepartment.Text = "Удалить отдел";
            this.buttonDeleteDepartment.UseVisualStyleBackColor = true;
            this.buttonDeleteDepartment.Click += new System.EventHandler(this.buttonDeleteDepartment_Click);
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Location = new System.Drawing.Point(379, 22);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(75, 52);
            this.buttonAddDepartment.TabIndex = 1;
            this.buttonAddDepartment.Text = "Добавить отдел";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.comboBoxEducation);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormEmployee";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewSkills;
        private System.Windows.Forms.Button buttonUpdateSkills;
        private System.Windows.Forms.Button buttonDeleteSkill;
        private System.Windows.Forms.Button buttonAddSkill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDepartments;
        private System.Windows.Forms.Button buttonUpdateDepartment;
        private System.Windows.Forms.Button buttonDeleteDepartment;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillLevel;
    }
}