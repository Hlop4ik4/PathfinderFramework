namespace PathfinderFramework
{
    partial class FormCourseReport
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
            this.buttonCreateDoc = new System.Windows.Forms.Button();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxOrganizer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.buttonChooseCourse = new System.Windows.Forms.Button();
            this.textBoxSkillLevel = new System.Windows.Forms.TextBox();
            this.textBoxCourseType = new System.Windows.Forms.TextBox();
            this.textBoxTrainingType = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxAmountOfHours = new System.Windows.Forms.TextBox();
            this.textBoxBeginHourse = new System.Windows.Forms.TextBox();
            this.textBoxEndHours = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxBeginDate = new System.Windows.Forms.TextBox();
            this.textBoxEndDate = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курс";
            // 
            // buttonCreateDoc
            // 
            this.buttonCreateDoc.Location = new System.Drawing.Point(241, 10);
            this.buttonCreateDoc.Name = "buttonCreateDoc";
            this.buttonCreateDoc.Size = new System.Drawing.Size(148, 23);
            this.buttonCreateDoc.TabIndex = 2;
            this.buttonCreateDoc.Text = "Создать документ";
            this.buttonCreateDoc.UseVisualStyleBackColor = true;
            this.buttonCreateDoc.Click += new System.EventHandler(this.buttonCreateDoc_Click);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(325, 67);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(121, 20);
            this.textBoxLocation.TabIndex = 20;
            // 
            // textBoxOrganizer
            // 
            this.textBoxOrganizer.Location = new System.Drawing.Point(88, 147);
            this.textBoxOrganizer.Name = "textBoxOrganizer";
            this.textBoxOrganizer.ReadOnly = true;
            this.textBoxOrganizer.Size = new System.Drawing.Size(121, 20);
            this.textBoxOrganizer.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "по";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Время занятий: с";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Место проведения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Организатор";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Уровень навыка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Количество часов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вид";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Год";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(49, 12);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.ReadOnly = true;
            this.textBoxCourseName.Size = new System.Drawing.Size(186, 20);
            this.textBoxCourseName.TabIndex = 24;
            // 
            // buttonChooseCourse
            // 
            this.buttonChooseCourse.Location = new System.Drawing.Point(160, 38);
            this.buttonChooseCourse.Name = "buttonChooseCourse";
            this.buttonChooseCourse.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseCourse.TabIndex = 25;
            this.buttonChooseCourse.Text = "Выбрать курс";
            this.buttonChooseCourse.UseVisualStyleBackColor = true;
            this.buttonChooseCourse.Click += new System.EventHandler(this.buttonChooseCourse_Click);
            // 
            // textBoxSkillLevel
            // 
            this.textBoxSkillLevel.Location = new System.Drawing.Point(326, 173);
            this.textBoxSkillLevel.Name = "textBoxSkillLevel";
            this.textBoxSkillLevel.ReadOnly = true;
            this.textBoxSkillLevel.Size = new System.Drawing.Size(121, 20);
            this.textBoxSkillLevel.TabIndex = 20;
            // 
            // textBoxCourseType
            // 
            this.textBoxCourseType.Location = new System.Drawing.Point(88, 67);
            this.textBoxCourseType.Name = "textBoxCourseType";
            this.textBoxCourseType.ReadOnly = true;
            this.textBoxCourseType.Size = new System.Drawing.Size(121, 20);
            this.textBoxCourseType.TabIndex = 18;
            // 
            // textBoxTrainingType
            // 
            this.textBoxTrainingType.Location = new System.Drawing.Point(88, 93);
            this.textBoxTrainingType.Name = "textBoxTrainingType";
            this.textBoxTrainingType.ReadOnly = true;
            this.textBoxTrainingType.Size = new System.Drawing.Size(121, 20);
            this.textBoxTrainingType.TabIndex = 18;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(87, 120);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.ReadOnly = true;
            this.textBoxYear.Size = new System.Drawing.Size(121, 20);
            this.textBoxYear.TabIndex = 18;
            // 
            // textBoxAmountOfHours
            // 
            this.textBoxAmountOfHours.Location = new System.Drawing.Point(326, 147);
            this.textBoxAmountOfHours.Name = "textBoxAmountOfHours";
            this.textBoxAmountOfHours.ReadOnly = true;
            this.textBoxAmountOfHours.Size = new System.Drawing.Size(121, 20);
            this.textBoxAmountOfHours.TabIndex = 20;
            // 
            // textBoxBeginHourse
            // 
            this.textBoxBeginHourse.Location = new System.Drawing.Point(324, 93);
            this.textBoxBeginHourse.Name = "textBoxBeginHourse";
            this.textBoxBeginHourse.ReadOnly = true;
            this.textBoxBeginHourse.Size = new System.Drawing.Size(121, 20);
            this.textBoxBeginHourse.TabIndex = 20;
            // 
            // textBoxEndHours
            // 
            this.textBoxEndHours.Location = new System.Drawing.Point(478, 93);
            this.textBoxEndHours.Name = "textBoxEndHours";
            this.textBoxEndHours.ReadOnly = true;
            this.textBoxEndHours.Size = new System.Drawing.Size(121, 20);
            this.textBoxEndHours.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 194);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeFullName,
            this.RegistrationDate,
            this.IsCompleted,
            this.DocumentCode});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(575, 169);
            this.dataGridView1.TabIndex = 0;
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.Visible = false;
            // 
            // EmployeeFullName
            // 
            this.EmployeeFullName.HeaderText = "Сотрудник";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // RegistrationDate
            // 
            this.RegistrationDate.HeaderText = "Дата регистрации";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            // 
            // IsCompleted
            // 
            this.IsCompleted.HeaderText = "Курс завершен";
            this.IsCompleted.Name = "IsCompleted";
            this.IsCompleted.ReadOnly = true;
            // 
            // DocumentCode
            // 
            this.DocumentCode.HeaderText = "Код документа";
            this.DocumentCode.Name = "DocumentCode";
            this.DocumentCode.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Дата занятий: с";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(453, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "по";
            // 
            // textBoxBeginDate
            // 
            this.textBoxBeginDate.Location = new System.Drawing.Point(324, 120);
            this.textBoxBeginDate.Name = "textBoxBeginDate";
            this.textBoxBeginDate.ReadOnly = true;
            this.textBoxBeginDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxBeginDate.TabIndex = 20;
            // 
            // textBoxEndDate
            // 
            this.textBoxEndDate.Location = new System.Drawing.Point(478, 120);
            this.textBoxEndDate.Name = "textBoxEndDate";
            this.textBoxEndDate.ReadOnly = true;
            this.textBoxEndDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxEndDate.TabIndex = 20;
            // 
            // FormCourseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonChooseCourse);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxEndDate);
            this.Controls.Add(this.textBoxEndHours);
            this.Controls.Add(this.textBoxBeginDate);
            this.Controls.Add(this.textBoxBeginHourse);
            this.Controls.Add(this.textBoxAmountOfHours);
            this.Controls.Add(this.textBoxSkillLevel);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxOrganizer);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxTrainingType);
            this.Controls.Add(this.textBoxCourseType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCreateDoc);
            this.Controls.Add(this.label1);
            this.Name = "FormCourseReport";
            this.Text = "Отчет по курсу";
            this.Load += new System.EventHandler(this.FormCourseReport_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateDoc;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxOrganizer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Button buttonChooseCourse;
        private System.Windows.Forms.TextBox textBoxSkillLevel;
        private System.Windows.Forms.TextBox textBoxCourseType;
        private System.Windows.Forms.TextBox textBoxTrainingType;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxAmountOfHours;
        private System.Windows.Forms.TextBox textBoxBeginHourse;
        private System.Windows.Forms.TextBox textBoxEndHours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxBeginDate;
        private System.Windows.Forms.TextBox textBoxEndDate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}