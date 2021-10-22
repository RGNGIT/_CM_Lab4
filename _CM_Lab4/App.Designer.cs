namespace _CM_Lab4
{
    partial class App
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
            this.buttonDoCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDoCalc
            // 
            this.buttonDoCalc.Location = new System.Drawing.Point(713, 415);
            this.buttonDoCalc.Name = "buttonDoCalc";
            this.buttonDoCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonDoCalc.TabIndex = 0;
            this.buttonDoCalc.Text = "button1";
            this.buttonDoCalc.UseVisualStyleBackColor = true;
            this.buttonDoCalc.Click += new System.EventHandler(this.buttonDoCalc_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDoCalc);
            this.Name = "App";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDoCalc;
    }
}

