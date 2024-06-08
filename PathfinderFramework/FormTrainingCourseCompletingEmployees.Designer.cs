namespace PathfinderFramework
{
    partial class FormTrainingCourseCompletingEmployees
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
            this.dataGridViewFullEmployees = new System.Windows.Forms.DataGridView();
            this.buttonChooseEmployees = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSelectedEmployees = new System.Windows.Forms.DataGridView();
            this.buttonDeleteSelectedEmployees = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonClearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFullEmployees
            // 
            this.dataGridViewFullEmployees.AllowUserToAddRows = false;
            this.dataGridViewFullEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewFullEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFullEmployees.Location = new System.Drawing.Point(6, 74);
            this.dataGridViewFullEmployees.Name = "dataGridViewFullEmployees";
            this.dataGridViewFullEmployees.ReadOnly = true;
            this.dataGridViewFullEmployees.Size = new System.Drawing.Size(198, 309);
            this.dataGridViewFullEmployees.TabIndex = 0;
            // 
            // buttonChooseEmployees
            // 
            this.buttonChooseEmployees.Location = new System.Drawing.Point(210, 74);
            this.buttonChooseEmployees.Name = "buttonChooseEmployees";
            this.buttonChooseEmployees.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseEmployees.TabIndex = 1;
            this.buttonChooseEmployees.Text = "Выбрать";
            this.buttonChooseEmployees.UseVisualStyleBackColor = true;
            this.buttonChooseEmployees.Click += new System.EventHandler(this.buttonChooseEmployees_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(435, 407);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonClearFilter);
            this.groupBox1.Controls.Add(this.buttonFilter);
            this.groupBox1.Controls.Add(this.dataGridViewFullEmployees);
            this.groupBox1.Controls.Add(this.buttonChooseEmployees);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 389);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список сотрудников";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSelectedEmployees);
            this.groupBox2.Controls.Add(this.buttonDeleteSelectedEmployees);
            this.groupBox2.Location = new System.Drawing.Point(306, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 389);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбранные сотрудники";
            // 
            // dataGridViewSelectedEmployees
            // 
            this.dataGridViewSelectedEmployees.AllowUserToAddRows = false;
            this.dataGridViewSelectedEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewSelectedEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeFullName});
            this.dataGridViewSelectedEmployees.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewSelectedEmployees.Name = "dataGridViewSelectedEmployees";
            this.dataGridViewSelectedEmployees.ReadOnly = true;
            this.dataGridViewSelectedEmployees.Size = new System.Drawing.Size(198, 364);
            this.dataGridViewSelectedEmployees.TabIndex = 0;
            // 
            // buttonDeleteSelectedEmployees
            // 
            this.buttonDeleteSelectedEmployees.Location = new System.Drawing.Point(207, 19);
            this.buttonDeleteSelectedEmployees.Name = "buttonDeleteSelectedEmployees";
            this.buttonDeleteSelectedEmployees.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSelectedEmployees.TabIndex = 1;
            this.buttonDeleteSelectedEmployees.Text = "Удалить";
            this.buttonDeleteSelectedEmployees.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedEmployees.Click += new System.EventHandler(this.buttonDeleteSelectedEmployees_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(519, 407);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.EmployeeFullName.HeaderText = "Полное имя";
            this.EmployeeFullName.Name = "EmployeeFullName";
            this.EmployeeFullName.ReadOnly = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(207, 45);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(41, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(241, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // buttonClearFilter
            // 
            this.buttonClearFilter.Location = new System.Drawing.Point(84, 45);
            this.buttonClearFilter.Name = "buttonClearFilter";
            this.buttonClearFilter.Size = new System.Drawing.Size(117, 23);
            this.buttonClearFilter.TabIndex = 2;
            this.buttonClearFilter.Text = "Очистить фильтр";
            this.buttonClearFilter.UseVisualStyleBackColor = true;
            this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
            // 
            // FormTrainingCourseCompletingEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 442);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormTrainingCourseCompletingEmployees";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormTrainingCourseEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFullEmployees;
        private System.Windows.Forms.Button buttonChooseEmployees;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewSelectedEmployees;
        private System.Windows.Forms.Button buttonDeleteSelectedEmployees;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFullName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClearFilter;
        private System.Windows.Forms.Button buttonFilter;
    }
}