namespace PathfinderFramework
{
    partial class FormCertificate
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
            this.checkBoxIsForTrainingCourse = new System.Windows.Forms.CheckBox();
            this.comboBoxTrainingCourse = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChooseCertificateImagePath = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сертификат по курсу";
            // 
            // checkBoxIsForTrainingCourse
            // 
            this.checkBoxIsForTrainingCourse.AutoSize = true;
            this.checkBoxIsForTrainingCourse.Location = new System.Drawing.Point(132, 8);
            this.checkBoxIsForTrainingCourse.Name = "checkBoxIsForTrainingCourse";
            this.checkBoxIsForTrainingCourse.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsForTrainingCourse.TabIndex = 1;
            this.checkBoxIsForTrainingCourse.UseVisualStyleBackColor = true;
            this.checkBoxIsForTrainingCourse.CheckedChanged += new System.EventHandler(this.checkBoxIsForTrainingCourse_CheckedChanged);
            // 
            // comboBoxTrainingCourse
            // 
            this.comboBoxTrainingCourse.Enabled = false;
            this.comboBoxTrainingCourse.FormattingEnabled = true;
            this.comboBoxTrainingCourse.Location = new System.Drawing.Point(153, 6);
            this.comboBoxTrainingCourse.Name = "comboBoxTrainingCourse";
            this.comboBoxTrainingCourse.Size = new System.Drawing.Size(180, 21);
            this.comboBoxTrainingCourse.TabIndex = 2;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(132, 33);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(201, 21);
            this.comboBoxEmployee.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сотрудник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(132, 60);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(201, 20);
            this.textBoxCode.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(71, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonChooseCertificateImagePath
            // 
            this.buttonChooseCertificateImagePath.Location = new System.Drawing.Point(121, 112);
            this.buttonChooseCertificateImagePath.Name = "buttonChooseCertificateImagePath";
            this.buttonChooseCertificateImagePath.Size = new System.Drawing.Size(120, 74);
            this.buttonChooseCertificateImagePath.TabIndex = 7;
            this.buttonChooseCertificateImagePath.Text = "Выбрать фото сертификата";
            this.buttonChooseCertificateImagePath.UseVisualStyleBackColor = true;
            this.buttonChooseCertificateImagePath.Click += new System.EventHandler(this.buttonChooseCertificateImagePath_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(202, 449);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(121, 449);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
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
            this.label4.Location = new System.Drawing.Point(93, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(132, 86);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(201, 20);
            this.textBoxDate.TabIndex = 5;
            // 
            // FormCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 481);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonChooseCertificateImagePath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxTrainingCourse);
            this.Controls.Add(this.checkBoxIsForTrainingCourse);
            this.Controls.Add(this.label1);
            this.Name = "FormCertificate";
            this.Text = "Сертификат";
            this.Load += new System.EventHandler(this.FormCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxIsForTrainingCourse;
        private System.Windows.Forms.ComboBox comboBoxTrainingCourse;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChooseCertificateImagePath;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}