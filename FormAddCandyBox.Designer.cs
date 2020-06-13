namespace Laba5_ExternalSort
{
    partial class FormAddCandyBox
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
            this.textBoxNameCandyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCostCandyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProducerCandyBox = new System.Windows.Forms.TextBox();
            this.pickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.numericShelfTimeCandyBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericShelfTimeCandyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameCandyBox
            // 
            this.textBoxNameCandyBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameCandyBox.Location = new System.Drawing.Point(29, 64);
            this.textBoxNameCandyBox.Name = "textBoxNameCandyBox";
            this.textBoxNameCandyBox.Size = new System.Drawing.Size(223, 29);
            this.textBoxNameCandyBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес упаковки в граммах";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeight.Location = new System.Drawing.Point(29, 128);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(223, 29);
            this.textBoxWeight.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена упаковки в рублях";
            // 
            // textBoxCostCandyBox
            // 
            this.textBoxCostCandyBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCostCandyBox.Location = new System.Drawing.Point(29, 198);
            this.textBoxCostCandyBox.Name = "textBoxCostCandyBox";
            this.textBoxCostCandyBox.Size = new System.Drawing.Size(223, 29);
            this.textBoxCostCandyBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Производитель";
            // 
            // textBoxProducerCandyBox
            // 
            this.textBoxProducerCandyBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxProducerCandyBox.Location = new System.Drawing.Point(29, 268);
            this.textBoxProducerCandyBox.Name = "textBoxProducerCandyBox";
            this.textBoxProducerCandyBox.Size = new System.Drawing.Size(223, 29);
            this.textBoxProducerCandyBox.TabIndex = 6;
            // 
            // pickerIssueDate
            // 
            this.pickerIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickerIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerIssueDate.Location = new System.Drawing.Point(29, 340);
            this.pickerIssueDate.MaxDate = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            this.pickerIssueDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.pickerIssueDate.Name = "pickerIssueDate";
            this.pickerIssueDate.Size = new System.Drawing.Size(223, 29);
            this.pickerIssueDate.TabIndex = 9;
            this.pickerIssueDate.Value = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата изготовления";
            // 
            // numericShelfTimeCandyBox
            // 
            this.numericShelfTimeCandyBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericShelfTimeCandyBox.Location = new System.Drawing.Point(29, 409);
            this.numericShelfTimeCandyBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericShelfTimeCandyBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericShelfTimeCandyBox.Name = "numericShelfTimeCandyBox";
            this.numericShelfTimeCandyBox.Size = new System.Drawing.Size(223, 29);
            this.numericShelfTimeCandyBox.TabIndex = 11;
            this.numericShelfTimeCandyBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Срок хранения";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(81, 457);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 36);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddCandyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 505);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericShelfTimeCandyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pickerIssueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxProducerCandyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCostCandyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameCandyBox);
            this.Name = "FormAddCandyBox";
            this.Text = "Добавить коробку конфет";
            ((System.ComponentModel.ISupportInitialize)(this.numericShelfTimeCandyBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameCandyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCostCandyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProducerCandyBox;
        private System.Windows.Forms.DateTimePicker pickerIssueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericShelfTimeCandyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
    }
}