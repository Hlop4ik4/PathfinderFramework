namespace PathfinderFramework
{
    partial class FormPositionChangeView
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
            this.textBoxNewPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerChangeDate = new System.Windows.Forms.DateTimePicker();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxPrevPosition = new System.Windows.Forms.TextBox();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сотрудник";
            // 
            // textBoxNewPosition
            // 
            this.textBoxNewPosition.Location = new System.Drawing.Point(149, 65);
            this.textBoxNewPosition.Name = "textBoxNewPosition";
            this.textBoxNewPosition.ReadOnly = true;
            this.textBoxNewPosition.Size = new System.Drawing.Size(203, 20);
            this.textBoxNewPosition.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Предыдущая должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Новая должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата";
            // 
            // dateTimePickerChangeDate
            // 
            this.dateTimePickerChangeDate.Enabled = false;
            this.dateTimePickerChangeDate.Location = new System.Drawing.Point(149, 91);
            this.dateTimePickerChangeDate.Name = "dateTimePickerChangeDate";
            this.dateTimePickerChangeDate.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerChangeDate.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(277, 117);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxPrevPosition
            // 
            this.textBoxPrevPosition.Location = new System.Drawing.Point(149, 39);
            this.textBoxPrevPosition.Name = "textBoxPrevPosition";
            this.textBoxPrevPosition.ReadOnly = true;
            this.textBoxPrevPosition.Size = new System.Drawing.Size(203, 20);
            this.textBoxPrevPosition.TabIndex = 2;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Location = new System.Drawing.Point(149, 13);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.ReadOnly = true;
            this.textBoxEmployee.Size = new System.Drawing.Size(203, 20);
            this.textBoxEmployee.TabIndex = 2;
            // 
            // FormPositionChangeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 153);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dateTimePickerChangeDate);
            this.Controls.Add(this.textBoxEmployee);
            this.Controls.Add(this.textBoxPrevPosition);
            this.Controls.Add(this.textBoxNewPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPositionChangeView";
            this.Text = "Смена должности";
            this.Load += new System.EventHandler(this.FormPositionChangeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerChangeDate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxPrevPosition;
        private System.Windows.Forms.TextBox textBoxEmployee;
    }
}