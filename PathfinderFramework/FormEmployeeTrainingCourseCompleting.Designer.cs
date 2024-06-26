﻿namespace PathfinderFramework
{
    partial class FormEmployeeTrainingCourseCompleting
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
            this.textBoxEmployeeFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTrainingCourseName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxIsCourseCompleted = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDocumentCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Полное имя сотрудника";
            // 
            // textBoxEmployeeFullName
            // 
            this.textBoxEmployeeFullName.Location = new System.Drawing.Point(147, 6);
            this.textBoxEmployeeFullName.Name = "textBoxEmployeeFullName";
            this.textBoxEmployeeFullName.ReadOnly = true;
            this.textBoxEmployeeFullName.Size = new System.Drawing.Size(203, 20);
            this.textBoxEmployeeFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название курса";
            // 
            // textBoxTrainingCourseName
            // 
            this.textBoxTrainingCourseName.Location = new System.Drawing.Point(147, 32);
            this.textBoxTrainingCourseName.Name = "textBoxTrainingCourseName";
            this.textBoxTrainingCourseName.ReadOnly = true;
            this.textBoxTrainingCourseName.Size = new System.Drawing.Size(203, 20);
            this.textBoxTrainingCourseName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Курс завершен";
            // 
            // checkBoxIsCourseCompleted
            // 
            this.checkBoxIsCourseCompleted.AutoSize = true;
            this.checkBoxIsCourseCompleted.Location = new System.Drawing.Point(147, 58);
            this.checkBoxIsCourseCompleted.Name = "checkBoxIsCourseCompleted";
            this.checkBoxIsCourseCompleted.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsCourseCompleted.TabIndex = 2;
            this.checkBoxIsCourseCompleted.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(275, 103);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(194, 103);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Код документа";
            // 
            // textBoxDocumentCode
            // 
            this.textBoxDocumentCode.Location = new System.Drawing.Point(147, 77);
            this.textBoxDocumentCode.Name = "textBoxDocumentCode";
            this.textBoxDocumentCode.Size = new System.Drawing.Size(203, 20);
            this.textBoxDocumentCode.TabIndex = 1;
            // 
            // FormEmployeeTrainingCourseCompleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 140);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxIsCourseCompleted);
            this.Controls.Add(this.textBoxDocumentCode);
            this.Controls.Add(this.textBoxTrainingCourseName);
            this.Controls.Add(this.textBoxEmployeeFullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployeeTrainingCourseCompleting";
            this.Text = "Прохождение курса сотрудника";
            this.Load += new System.EventHandler(this.FormEmployeeTrainingCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTrainingCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxIsCourseCompleted;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDocumentCode;
    }
}