namespace TestTaskWithUI
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
            this.button = new System.Windows.Forms.Button();
            this.tBUserText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button.Location = new System.Drawing.Point(0, 239);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(448, 40);
            this.button.TabIndex = 0;
            this.button.Text = "Enter text, then press me";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // tBUserText
            // 
            this.tBUserText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBUserText.Location = new System.Drawing.Point(0, 0);
            this.tBUserText.Multiline = true;
            this.tBUserText.Name = "tBUserText";
            this.tBUserText.Size = new System.Drawing.Size(448, 239);
            this.tBUserText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 279);
            this.Controls.Add(this.tBUserText);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox tBUserText;
    }
}

