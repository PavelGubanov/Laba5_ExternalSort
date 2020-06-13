namespace Laba5_ExternalSort
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCandyBoxes = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.buttonAddInfo = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandyBoxes)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCandyBoxes
            // 
            this.dgvCandyBoxes.AllowUserToAddRows = false;
            this.dgvCandyBoxes.AllowUserToDeleteRows = false;
            this.dgvCandyBoxes.AllowUserToResizeRows = false;
            this.dgvCandyBoxes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCandyBoxes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCandyBoxes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCandyBoxes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCandyBoxes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCandyBoxes.Location = new System.Drawing.Point(219, 12);
            this.dgvCandyBoxes.Name = "dgvCandyBoxes";
            this.dgvCandyBoxes.ReadOnly = true;
            this.dgvCandyBoxes.RowHeadersVisible = false;
            this.dgvCandyBoxes.Size = new System.Drawing.Size(709, 414);
            this.dgvCandyBoxes.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "bin";
            this.openFileDialog.Filter = "Bin files (*.bin)|*.bin";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bin";
            this.saveFileDialog.Filter = "Bin files (*.bin)|*.bin";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileAddress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(940, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileAddress
            // 
            this.fileAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileAddress.Name = "fileAddress";
            this.fileAddress.Size = new System.Drawing.Size(123, 21);
            this.fileAddress.Text = "<Адрес файла>";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(34, 48);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(158, 36);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateFile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateFile.Location = new System.Drawing.Point(34, 101);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(158, 36);
            this.buttonCreateFile.TabIndex = 3;
            this.buttonCreateFile.Text = "Создать файл";
            this.buttonCreateFile.UseVisualStyleBackColor = false;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // buttonAddInfo
            // 
            this.buttonAddInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAddInfo.Enabled = false;
            this.buttonAddInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddInfo.Location = new System.Drawing.Point(34, 193);
            this.buttonAddInfo.Name = "buttonAddInfo";
            this.buttonAddInfo.Size = new System.Drawing.Size(158, 36);
            this.buttonAddInfo.TabIndex = 4;
            this.buttonAddInfo.Text = "Добавить ";
            this.buttonAddInfo.UseVisualStyleBackColor = false;
            this.buttonAddInfo.Click += new System.EventHandler(this.buttonAddInfo_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSort.Enabled = false;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.Location = new System.Drawing.Point(34, 245);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(158, 59);
            this.buttonSort.TabIndex = 5;
            this.buttonSort.Text = "Выполнить сортировку";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 470);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddInfo);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvCandyBoxes);
            this.Name = "FormMain";
            this.Text = "Частное предприятие \"Петров и К.\"";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandyBoxes)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandyBoxes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileAddress;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Button buttonAddInfo;
        private System.Windows.Forms.Button buttonSort;
    }
}

