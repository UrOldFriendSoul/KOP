namespace COP_Lab1_New.Components
{
    partial class EmailInputComponent
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.toolTipExamle = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AccessibleDescription = "example@gmail.com";
            this.textBox.Location = new System.Drawing.Point(3, 45);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(250, 22);
            this.textBox.TabIndex = 0;
            // 
            // EmailInputComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox);
            this.Name = "EmailInputComponent";
            this.Size = new System.Drawing.Size(256, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolTip toolTipExamle;
    }
}
