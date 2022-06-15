namespace AnalyzerText
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
            this.inputTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alphabetTB = new System.Windows.Forms.TextBox();
            this.palindromeTB = new System.Windows.Forms.TextBox();
            this.AnalyzerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(12, 25);
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTB.Size = new System.Drawing.Size(303, 346);
            this.inputTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Слова по Алфавиту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Слова палиндром";
            // 
            // alphabetTB
            // 
            this.alphabetTB.Location = new System.Drawing.Point(321, 25);
            this.alphabetTB.Multiline = true;
            this.alphabetTB.Name = "alphabetTB";
            this.alphabetTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alphabetTB.Size = new System.Drawing.Size(364, 181);
            this.alphabetTB.TabIndex = 4;
            // 
            // palindromeTB
            // 
            this.palindromeTB.Location = new System.Drawing.Point(321, 225);
            this.palindromeTB.Multiline = true;
            this.palindromeTB.Name = "palindromeTB";
            this.palindromeTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.palindromeTB.Size = new System.Drawing.Size(364, 181);
            this.palindromeTB.TabIndex = 5;
            // 
            // AnalyzerBtn
            // 
            this.AnalyzerBtn.Location = new System.Drawing.Point(12, 377);
            this.AnalyzerBtn.Name = "AnalyzerBtn";
            this.AnalyzerBtn.Size = new System.Drawing.Size(303, 35);
            this.AnalyzerBtn.TabIndex = 6;
            this.AnalyzerBtn.Text = "Проанализировать";
            this.AnalyzerBtn.UseVisualStyleBackColor = true;
            this.AnalyzerBtn.Click += new System.EventHandler(this.AnalyzerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 417);
            this.Controls.Add(this.AnalyzerBtn);
            this.Controls.Add(this.palindromeTB);
            this.Controls.Add(this.alphabetTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTB);
            this.Name = "Form1";
            this.Text = "Analyzer Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alphabetTB;
        private System.Windows.Forms.TextBox palindromeTB;
        private System.Windows.Forms.Button AnalyzerBtn;
    }
}

