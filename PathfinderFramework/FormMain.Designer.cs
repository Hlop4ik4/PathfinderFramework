namespace PathfinderFramework
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmplyeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkillLevelsНавыковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainingCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прохождениеКурсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainingCourseCompletingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CertificatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.прохождениеКурсовToolStripMenuItem,
            this.документыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SkillsToolStripMenuItem,
            this.EmplyeesToolStripMenuItem,
            this.ProfessionsToolStripMenuItem,
            this.SkillLevelsНавыковToolStripMenuItem,
            this.PositionsToolStripMenuItem,
            this.DepartmentsToolStripMenuItem,
            this.TrainingCoursesToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // SkillsToolStripMenuItem
            // 
            this.SkillsToolStripMenuItem.Name = "SkillsToolStripMenuItem";
            this.SkillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SkillsToolStripMenuItem.Text = "Навыки";
            this.SkillsToolStripMenuItem.Click += new System.EventHandler(this.SkillsToolStripMenuItem_Click);
            // 
            // EmplyeesToolStripMenuItem
            // 
            this.EmplyeesToolStripMenuItem.Name = "EmplyeesToolStripMenuItem";
            this.EmplyeesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmplyeesToolStripMenuItem.Text = "Сотрудники";
            this.EmplyeesToolStripMenuItem.Click += new System.EventHandler(this.EmplyeesToolStripMenuItem_Click);
            // 
            // ProfessionsToolStripMenuItem
            // 
            this.ProfessionsToolStripMenuItem.Name = "ProfessionsToolStripMenuItem";
            this.ProfessionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProfessionsToolStripMenuItem.Text = "Профессии";
            this.ProfessionsToolStripMenuItem.Click += new System.EventHandler(this.ProfessionsToolStripMenuItem_Click);
            // 
            // SkillLevelsНавыковToolStripMenuItem
            // 
            this.SkillLevelsНавыковToolStripMenuItem.Name = "SkillLevelsНавыковToolStripMenuItem";
            this.SkillLevelsНавыковToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SkillLevelsНавыковToolStripMenuItem.Text = "Уровни навыков";
            this.SkillLevelsНавыковToolStripMenuItem.Click += new System.EventHandler(this.SkillLevelsНавыковToolStripMenuItem_Click);
            // 
            // PositionsToolStripMenuItem
            // 
            this.PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem";
            this.PositionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PositionsToolStripMenuItem.Text = "Должности";
            this.PositionsToolStripMenuItem.Click += new System.EventHandler(this.PositionsToolStripMenuItem_Click);
            // 
            // DepartmentsToolStripMenuItem
            // 
            this.DepartmentsToolStripMenuItem.Name = "DepartmentsToolStripMenuItem";
            this.DepartmentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DepartmentsToolStripMenuItem.Text = "Отделы";
            this.DepartmentsToolStripMenuItem.Click += new System.EventHandler(this.DepartmentsToolStripMenuItem_Click);
            // 
            // TrainingCoursesToolStripMenuItem
            // 
            this.TrainingCoursesToolStripMenuItem.Name = "TrainingCoursesToolStripMenuItem";
            this.TrainingCoursesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TrainingCoursesToolStripMenuItem.Text = "Курсы";
            this.TrainingCoursesToolStripMenuItem.Click += new System.EventHandler(this.TrainingCoursesToolStripMenuItem_Click);
            // 
            // прохождениеКурсовToolStripMenuItem
            // 
            this.прохождениеКурсовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrainingCourseCompletingsToolStripMenuItem,
            this.CertificatesToolStripMenuItem});
            this.прохождениеКурсовToolStripMenuItem.Name = "прохождениеКурсовToolStripMenuItem";
            this.прохождениеКурсовToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.прохождениеКурсовToolStripMenuItem.Text = "Прохождение курсов";
            // 
            // TrainingCourseCompletingsToolStripMenuItem
            // 
            this.TrainingCourseCompletingsToolStripMenuItem.Name = "TrainingCourseCompletingsToolStripMenuItem";
            this.TrainingCourseCompletingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TrainingCourseCompletingsToolStripMenuItem.Text = "Курсы";
            this.TrainingCourseCompletingsToolStripMenuItem.Click += new System.EventHandler(this.TrainingCourseCompletingsToolStripMenuItem_Click);
            // 
            // CertificatesToolStripMenuItem
            // 
            this.CertificatesToolStripMenuItem.Name = "CertificatesToolStripMenuItem";
            this.CertificatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CertificatesToolStripMenuItem.Text = "Сертификаты";
            this.CertificatesToolStripMenuItem.Click += new System.EventHandler(this.CertificatesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewEmployees);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 393);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(307, 368);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewPositions);
            this.groupBox2.Location = new System.Drawing.Point(522, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 393);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Должности";
            // 
            // dataGridViewPositions
            // 
            this.dataGridViewPositions.AllowUserToAddRows = false;
            this.dataGridViewPositions.AllowUserToDeleteRows = false;
            this.dataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositions.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewPositions.Name = "dataGridViewPositions";
            this.dataGridViewPositions.ReadOnly = true;
            this.dataGridViewPositions.Size = new System.Drawing.Size(307, 368);
            this.dataGridViewPositions.TabIndex = 0;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(337, 45);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(179, 23);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Рассчитать разность";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionChangesToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // positionChangesToolStripMenuItem
            // 
            this.positionChangesToolStripMenuItem.Name = "positionChangesToolStripMenuItem";
            this.positionChangesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.positionChangesToolStripMenuItem.Text = "Документы о смене должности";
            this.positionChangesToolStripMenuItem.Click += new System.EventHandler(this.positionChangesToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmplyeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkillLevelsНавыковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PositionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepartmentsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewPositions;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.ToolStripMenuItem TrainingCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прохождениеКурсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrainingCourseCompletingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CertificatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionChangesToolStripMenuItem;
    }
}