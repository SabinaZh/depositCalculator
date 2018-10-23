namespace Deposit
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncalc = new System.Windows.Forms.Button();
            this.startcount = new System.Windows.Forms.NumericUpDown();
            this.percent = new System.Windows.Forms.NumericUpDown();
            this.years = new System.Windows.Forms.NumericUpDown();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.years)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма вклада :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Процентная ставка(%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок(мес.) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Итого по вкладу :";
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(197, 261);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(120, 40);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "Рассчитать";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // startcount
            // 
            this.startcount.DecimalPlaces = 2;
            this.startcount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startcount.Location = new System.Drawing.Point(206, 59);
            this.startcount.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.startcount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startcount.Name = "startcount";
            this.startcount.Size = new System.Drawing.Size(155, 22);
            this.startcount.TabIndex = 5;
            this.startcount.ThousandsSeparator = true;
            this.startcount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // percent
            // 
            this.percent.DecimalPlaces = 2;
            this.percent.Location = new System.Drawing.Point(206, 105);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(155, 22);
            this.percent.TabIndex = 6;
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(206, 157);
            this.years.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(155, 22);
            this.years.TabIndex = 7;
            this.years.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total.Location = new System.Drawing.Point(206, 379);
            this.total.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(155, 22);
            this.total.TabIndex = 8;
            this.total.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата открытия вклада :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(206, 328);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата окончания вклада :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(581, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total);
            this.Controls.Add(this.years);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.startcount);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Калькулятор вклада";
            ((System.ComponentModel.ISupportInitialize)(this.startcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.years)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.NumericUpDown startcount;
        private System.Windows.Forms.NumericUpDown percent;
        private System.Windows.Forms.NumericUpDown years;
        private System.Windows.Forms.NumericUpDown total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
    }
}

