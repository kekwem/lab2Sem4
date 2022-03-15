
namespace delegaty
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
            this.liczbaTextBox = new System.Windows.Forms.TextBox();
            this.kwadratButton = new System.Windows.Forms.Button();
            this.pierwiastekButton = new System.Windows.Forms.Button();
            this.odwrotnoscButton = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.zmiannaTlaButton = new System.Windows.Forms.Button();
            this.zmianaKoloruButton = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.zmianaRozmiaru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liczbaTextBox
            // 
            this.liczbaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.liczbaTextBox.Location = new System.Drawing.Point(12, 12);
            this.liczbaTextBox.Multiline = true;
            this.liczbaTextBox.Name = "liczbaTextBox";
            this.liczbaTextBox.Size = new System.Drawing.Size(236, 119);
            this.liczbaTextBox.TabIndex = 0;
            // 
            // kwadratButton
            // 
            this.kwadratButton.Location = new System.Drawing.Point(318, 12);
            this.kwadratButton.Name = "kwadratButton";
            this.kwadratButton.Size = new System.Drawing.Size(75, 23);
            this.kwadratButton.TabIndex = 2;
            this.kwadratButton.Text = "Kwadrat";
            this.kwadratButton.UseVisualStyleBackColor = true;
            this.kwadratButton.Click += new System.EventHandler(this.kwadratButton_Click);
            // 
            // pierwiastekButton
            // 
            this.pierwiastekButton.Location = new System.Drawing.Point(399, 11);
            this.pierwiastekButton.Name = "pierwiastekButton";
            this.pierwiastekButton.Size = new System.Drawing.Size(93, 23);
            this.pierwiastekButton.TabIndex = 3;
            this.pierwiastekButton.Text = "Pierwiastek";
            this.pierwiastekButton.UseVisualStyleBackColor = true;
            this.pierwiastekButton.Click += new System.EventHandler(this.pierwiastekButton_Click);
            // 
            // odwrotnoscButton
            // 
            this.odwrotnoscButton.Location = new System.Drawing.Point(498, 11);
            this.odwrotnoscButton.Name = "odwrotnoscButton";
            this.odwrotnoscButton.Size = new System.Drawing.Size(93, 23);
            this.odwrotnoscButton.TabIndex = 4;
            this.odwrotnoscButton.Text = "Odwrotnosc";
            this.odwrotnoscButton.UseVisualStyleBackColor = true;
            this.odwrotnoscButton.Click += new System.EventHandler(this.odwrotnoscButton_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(657, 12);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(93, 23);
            this.buttonFirst.TabIndex = 5;
            this.buttonFirst.Text = "Button";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // zmiannaTlaButton
            // 
            this.zmiannaTlaButton.Location = new System.Drawing.Point(318, 108);
            this.zmiannaTlaButton.Name = "zmiannaTlaButton";
            this.zmiannaTlaButton.Size = new System.Drawing.Size(75, 23);
            this.zmiannaTlaButton.TabIndex = 6;
            this.zmiannaTlaButton.Text = "Zm. tla";
            this.zmiannaTlaButton.UseVisualStyleBackColor = true;
            this.zmiannaTlaButton.Click += new System.EventHandler(this.zmiannaTlaButton_Click);
            // 
            // zmianaKoloruButton
            // 
            this.zmianaKoloruButton.Location = new System.Drawing.Point(399, 108);
            this.zmianaKoloruButton.Name = "zmianaKoloruButton";
            this.zmianaKoloruButton.Size = new System.Drawing.Size(140, 23);
            this.zmianaKoloruButton.TabIndex = 7;
            this.zmianaKoloruButton.Text = "Zm. koloru teksta";
            this.zmianaKoloruButton.UseVisualStyleBackColor = true;
            this.zmianaKoloruButton.Click += new System.EventHandler(this.zmianaKoloruButton_Click);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(657, 108);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(93, 23);
            this.buttonSecond.TabIndex = 8;
            this.buttonSecond.Text = "Button";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // zmianaRozmiaru
            // 
            this.zmianaRozmiaru.Location = new System.Drawing.Point(545, 108);
            this.zmianaRozmiaru.Name = "zmianaRozmiaru";
            this.zmianaRozmiaru.Size = new System.Drawing.Size(106, 23);
            this.zmianaRozmiaru.TabIndex = 9;
            this.zmianaRozmiaru.Text = "Zm. rozmiaru";
            this.zmianaRozmiaru.UseVisualStyleBackColor = true;
            this.zmianaRozmiaru.Click += new System.EventHandler(this.zmianaRozmiaru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 443);
            this.Controls.Add(this.zmianaRozmiaru);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.zmianaKoloruButton);
            this.Controls.Add(this.zmiannaTlaButton);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.odwrotnoscButton);
            this.Controls.Add(this.pierwiastekButton);
            this.Controls.Add(this.kwadratButton);
            this.Controls.Add(this.liczbaTextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Delegaty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox liczbaTextBox;
        private System.Windows.Forms.Button kwadratButton;
        private System.Windows.Forms.Button pierwiastekButton;
        private System.Windows.Forms.Button odwrotnoscButton;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button zmiannaTlaButton;
        private System.Windows.Forms.Button zmianaKoloruButton;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button zmianaRozmiaru;
    }
}

