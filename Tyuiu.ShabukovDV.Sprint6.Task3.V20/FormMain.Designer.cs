
namespace Tyuiu.ShabukovDV.Sprint6.Task3.V20
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_KRM = new System.Windows.Forms.Button();
            this.buttonHelp_KRM = new System.Windows.Forms.Button();
            this.groupBoxResult_KRM = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixResult_KRM = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_KRM = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_KRM = new System.Windows.Forms.DataGridView();
            this.textBoxTask_KRM = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KRM)).BeginInit();
            this.groupBoxTask_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRM)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_KRM
            // 
            this.buttonDone_KRM.Location = new System.Drawing.Point(512, 370);
            this.buttonDone_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_KRM.Name = "buttonDone_KRM";
            this.buttonDone_KRM.Size = new System.Drawing.Size(160, 64);
            this.buttonDone_KRM.TabIndex = 2;
            this.buttonDone_KRM.Text = "Выполнить";
            this.buttonDone_KRM.UseVisualStyleBackColor = true;
            this.buttonDone_KRM.Click += new System.EventHandler(this.buttonDone_KRM_Click);
            // 
            // buttonHelp_KRM
            // 
            this.buttonHelp_KRM.Location = new System.Drawing.Point(431, 370);
            this.buttonHelp_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_KRM.Name = "buttonHelp_KRM";
            this.buttonHelp_KRM.Size = new System.Drawing.Size(64, 64);
            this.buttonHelp_KRM.TabIndex = 6;
            this.buttonHelp_KRM.Text = "?";
            this.buttonHelp_KRM.UseVisualStyleBackColor = true;
            this.buttonHelp_KRM.Click += new System.EventHandler(this.buttonHelp_KRM_Click);
            // 
            // groupBoxResult_KRM
            // 
            this.groupBoxResult_KRM.Controls.Add(this.dataGridViewMatrixResult_KRM);
            this.groupBoxResult_KRM.Location = new System.Drawing.Point(512, 16);
            this.groupBoxResult_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_KRM.Name = "groupBoxResult_KRM";
            this.groupBoxResult_KRM.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_KRM.Size = new System.Drawing.Size(390, 330);
            this.groupBoxResult_KRM.TabIndex = 4;
            this.groupBoxResult_KRM.TabStop = false;
            this.groupBoxResult_KRM.Text = "Вывод данных";
            // 
            // dataGridViewMatrixResult_KRM
            // 
            this.dataGridViewMatrixResult_KRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixResult_KRM.Location = new System.Drawing.Point(4, 17);
            this.dataGridViewMatrixResult_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMatrixResult_KRM.Name = "dataGridViewMatrixResult_KRM";
            this.dataGridViewMatrixResult_KRM.RowHeadersWidth = 51;
            this.dataGridViewMatrixResult_KRM.RowTemplate.Height = 24;
            this.dataGridViewMatrixResult_KRM.Size = new System.Drawing.Size(294, 164);
            this.dataGridViewMatrixResult_KRM.TabIndex = 0;
            // 
            // groupBoxTask_KRM
            // 
            this.groupBoxTask_KRM.Controls.Add(this.dataGridViewMatrix_KRM);
            this.groupBoxTask_KRM.Controls.Add(this.textBoxTask_KRM);
            this.groupBoxTask_KRM.Location = new System.Drawing.Point(8, 16);
            this.groupBoxTask_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_KRM.Name = "groupBoxTask_KRM";
            this.groupBoxTask_KRM.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_KRM.Size = new System.Drawing.Size(500, 330);
            this.groupBoxTask_KRM.TabIndex = 3;
            this.groupBoxTask_KRM.TabStop = false;
            this.groupBoxTask_KRM.Text = "Условие";
            // 
            // dataGridViewMatrix_KRM
            // 
            this.dataGridViewMatrix_KRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KRM.Location = new System.Drawing.Point(202, 17);
            this.dataGridViewMatrix_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMatrix_KRM.Name = "dataGridViewMatrix_KRM";
            this.dataGridViewMatrix_KRM.RowHeadersWidth = 51;
            this.dataGridViewMatrix_KRM.RowTemplate.Height = 24;
            this.dataGridViewMatrix_KRM.Size = new System.Drawing.Size(294, 164);
            this.dataGridViewMatrix_KRM.TabIndex = 1;
            // 
            // textBoxTask_KRM
            // 
            this.textBoxTask_KRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_KRM.Location = new System.Drawing.Point(4, 17);
            this.textBoxTask_KRM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_KRM.Multiline = true;
            this.textBoxTask_KRM.Name = "textBoxTask_KRM";
            this.textBoxTask_KRM.ReadOnly = true;
            this.textBoxTask_KRM.Size = new System.Drawing.Size(167, 117);
            this.textBoxTask_KRM.TabIndex = 0;
            this.textBoxTask_KRM.Text = resources.GetString("textBoxTask_KRM.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.buttonDone_KRM);
            this.Controls.Add(this.buttonHelp_KRM);
            this.Controls.Add(this.groupBoxResult_KRM);
            this.Controls.Add(this.groupBoxTask_KRM);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 20 | Шабуков Д. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResult_KRM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixResult_KRM)).EndInit();
            this.groupBoxTask_KRM.ResumeLayout(false);
            this.groupBoxTask_KRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KRM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_KRM;
        private System.Windows.Forms.Button buttonHelp_KRM;
        private System.Windows.Forms.GroupBox groupBoxResult_KRM;
        private System.Windows.Forms.DataGridView dataGridViewMatrixResult_KRM;
        private System.Windows.Forms.GroupBox groupBoxTask_KRM;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KRM;
        private System.Windows.Forms.TextBox textBoxTask_KRM;
    }
}

