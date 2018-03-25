namespace lab3saod
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StrLabir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StolbLab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BeginY = new System.Windows.Forms.TextBox();
            this.BeginX = new System.Windows.Forms.TextBox();
            this.EndY = new System.Windows.Forms.TextBox();
            this.EndX = new System.Windows.Forms.TextBox();
            this.SizeLab = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(268, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // StrLabir
            // 
            this.StrLabir.Location = new System.Drawing.Point(15, 40);
            this.StrLabir.Name = "StrLabir";
            this.StrLabir.Size = new System.Drawing.Size(52, 22);
            this.StrLabir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер лабиринта";
            // 
            // StolbLab
            // 
            this.StolbLab.Location = new System.Drawing.Point(92, 40);
            this.StolbLab.Name = "StolbLab";
            this.StolbLab.Size = new System.Drawing.Size(52, 22);
            this.StolbLab.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Начальные координаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цель";
            // 
            // BeginY
            // 
            this.BeginY.Location = new System.Drawing.Point(92, 138);
            this.BeginY.Name = "BeginY";
            this.BeginY.Size = new System.Drawing.Size(52, 22);
            this.BeginY.TabIndex = 8;
            // 
            // BeginX
            // 
            this.BeginX.Location = new System.Drawing.Point(15, 138);
            this.BeginX.Name = "BeginX";
            this.BeginX.Size = new System.Drawing.Size(52, 22);
            this.BeginX.TabIndex = 7;
            // 
            // EndY
            // 
            this.EndY.Location = new System.Drawing.Point(92, 205);
            this.EndY.Name = "EndY";
            this.EndY.Size = new System.Drawing.Size(52, 22);
            this.EndY.TabIndex = 10;
            // 
            // EndX
            // 
            this.EndX.Location = new System.Drawing.Point(15, 205);
            this.EndX.Name = "EndX";
            this.EndX.Size = new System.Drawing.Size(52, 22);
            this.EndX.TabIndex = 9;
            // 
            // SizeLab
            // 
            this.SizeLab.Location = new System.Drawing.Point(40, 68);
            this.SizeLab.Name = "SizeLab";
            this.SizeLab.Size = new System.Drawing.Size(75, 23);
            this.SizeLab.TabIndex = 11;
            this.SizeLab.Text = "Ввести ";
            this.SizeLab.UseVisualStyleBackColor = true;
            this.SizeLab.Click += new System.EventHandler(this.SizeLab_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Найти выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(188, 249);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(271, 59);
            this.Output.TabIndex = 13;
            this.Output.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ответ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SizeLab);
            this.Controls.Add(this.EndY);
            this.Controls.Add(this.EndX);
            this.Controls.Add(this.BeginY);
            this.Controls.Add(this.BeginX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StolbLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StrLabir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox StrLabir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StolbLab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BeginY;
        private System.Windows.Forms.TextBox BeginX;
        private System.Windows.Forms.TextBox EndY;
        private System.Windows.Forms.TextBox EndX;
        private System.Windows.Forms.Button SizeLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label label5;
    }
}

