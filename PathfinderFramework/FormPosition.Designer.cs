namespace PathfinderFramework
{
    partial class FormPosition
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateProfessions = new System.Windows.Forms.Button();
            this.buttonDeleteProfession = new System.Windows.Forms.Button();
            this.buttonAddProfession = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.ProfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdateProfessions);
            this.groupBox1.Controls.Add(this.buttonDeleteProfession);
            this.groupBox1.Controls.Add(this.buttonAddProfession);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Профессии";
            // 
            // buttonUpdateProfessions
            // 
            this.buttonUpdateProfessions.Location = new System.Drawing.Point(362, 145);
            this.buttonUpdateProfessions.Name = "buttonUpdateProfessions";
            this.buttonUpdateProfessions.Size = new System.Drawing.Size(75, 57);
            this.buttonUpdateProfessions.TabIndex = 1;
            this.buttonUpdateProfessions.Text = "Обновить таблицу";
            this.buttonUpdateProfessions.UseVisualStyleBackColor = true;
            this.buttonUpdateProfessions.Click += new System.EventHandler(this.buttonUpdateProfessions_Click);
            // 
            // buttonDeleteProfession
            // 
            this.buttonDeleteProfession.Location = new System.Drawing.Point(362, 82);
            this.buttonDeleteProfession.Name = "buttonDeleteProfession";
            this.buttonDeleteProfession.Size = new System.Drawing.Size(75, 57);
            this.buttonDeleteProfession.TabIndex = 1;
            this.buttonDeleteProfession.Text = "Удалить профессию";
            this.buttonDeleteProfession.UseVisualStyleBackColor = true;
            this.buttonDeleteProfession.Click += new System.EventHandler(this.buttonDeleteProfession_Click);
            // 
            // buttonAddProfession
            // 
            this.buttonAddProfession.Location = new System.Drawing.Point(362, 19);
            this.buttonAddProfession.Name = "buttonAddProfession";
            this.buttonAddProfession.Size = new System.Drawing.Size(75, 57);
            this.buttonAddProfession.TabIndex = 1;
            this.buttonAddProfession.Text = "Добавить профессию";
            this.buttonAddProfession.UseVisualStyleBackColor = true;
            this.buttonAddProfession.Click += new System.EventHandler(this.buttonAddProfession_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfId,
            this.ProfName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(350, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxExperience);
            this.groupBox2.Controls.Add(this.comboBoxGender);
            this.groupBox2.Controls.Add(this.comboBoxEducation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(463, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Требования для должности";
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(87, 70);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(195, 20);
            this.textBoxExperience.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(87, 43);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(195, 21);
            this.comboBoxGender.TabIndex = 1;
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(87, 16);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(195, 21);
            this.comboBoxEducation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Опыт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пол";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Образование";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(682, 435);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(601, 435);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(75, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(382, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // ProfId
            // 
            this.ProfId.HeaderText = "ProfId";
            this.ProfId.Name = "ProfId";
            this.ProfId.ReadOnly = true;
            this.ProfId.Visible = false;
            // 
            // ProfName
            // 
            this.ProfName.HeaderText = "Название";
            this.ProfName.Name = "ProfName";
            this.ProfName.ReadOnly = true;
            // 
            // FormPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 466);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPosition";
            this.Text = "Должность";
            this.Load += new System.EventHandler(this.FormPosition_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdateProfessions;
        private System.Windows.Forms.Button buttonDeleteProfession;
        private System.Windows.Forms.Button buttonAddProfession;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfName;
    }
}