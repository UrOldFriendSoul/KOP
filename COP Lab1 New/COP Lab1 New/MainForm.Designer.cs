namespace COP_Lab1_New
{
    partial class MainForm
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
            this.clearComboBox = new System.Windows.Forms.Button();
            this.fillComboBox = new System.Windows.Forms.Button();
            this.fillList = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.clearTemplate = new System.Windows.Forms.Button();
            this.setEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getEmail = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSetToolTip = new System.Windows.Forms.Button();
            this.emailInputComponent1 = new COP_Lab1_New.Components.EmailInputComponent();
            this.listBoxControl = new COP_Lab1_New.Components.ListBoxControl();
            this.dropDownListControl = new COP_Lab1_New.Components.DropDownListControl();
            
            this.SuspendLayout();
            // 
            // clearComboBox
            // 
            this.clearComboBox.Location = new System.Drawing.Point(240, 13);
            this.clearComboBox.Name = "clearComboBox";
            this.clearComboBox.Size = new System.Drawing.Size(75, 23);
            this.clearComboBox.TabIndex = 3;
            this.clearComboBox.Text = "Clear";
            this.clearComboBox.UseVisualStyleBackColor = true;
            this.clearComboBox.Click += new System.EventHandler(this.clearComboBox_Click);
            // 
            // fillComboBox
            // 
            this.fillComboBox.Location = new System.Drawing.Point(149, 13);
            this.fillComboBox.Name = "fillComboBox";
            this.fillComboBox.Size = new System.Drawing.Size(75, 23);
            this.fillComboBox.TabIndex = 4;
            this.fillComboBox.Text = "Fill";
            this.fillComboBox.UseVisualStyleBackColor = true;
            this.fillComboBox.Click += new System.EventHandler(this.fillComboBox_Click_1);
            // 
            // fillList
            // 
            this.fillList.Location = new System.Drawing.Point(372, 167);
            this.fillList.Name = "fillList";
            this.fillList.Size = new System.Drawing.Size(75, 23);
            this.fillList.TabIndex = 5;
            this.fillList.Text = "Fill";
            this.fillList.UseVisualStyleBackColor = true;
            this.fillList.Click += new System.EventHandler(this.fillList_Click);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(463, 167);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(75, 23);
            this.clearList.TabIndex = 6;
            this.clearList.Text = "Take";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(372, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "FillTemp";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // clearTemplate
            // 
            this.clearTemplate.Location = new System.Drawing.Point(463, 363);
            this.clearTemplate.Name = "clearTemplate";
            this.clearTemplate.Size = new System.Drawing.Size(75, 23);
            this.clearTemplate.TabIndex = 8;
            this.clearTemplate.Text = "Clear";
            this.clearTemplate.UseVisualStyleBackColor = true;
            this.clearTemplate.Click += new System.EventHandler(this.clearTemplate_Click);
            // 
            // setEmail
            // 
            this.setEmail.Location = new System.Drawing.Point(274, 99);
            this.setEmail.Name = "setEmail";
            this.setEmail.Size = new System.Drawing.Size(75, 23);
            this.setEmail.TabIndex = 11;
            this.setEmail.Text = "Set";
            this.setEmail.UseVisualStyleBackColor = true;
            this.setEmail.Click += new System.EventHandler(this.setEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "____________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(539, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "____________________________________________________________________________";
            // 
            // getEmail
            // 
            this.getEmail.Location = new System.Drawing.Point(355, 99);
            this.getEmail.Name = "getEmail";
            this.getEmail.Size = new System.Drawing.Size(75, 23);
            this.getEmail.TabIndex = 19;
            this.getEmail.Text = "Get";
            this.getEmail.UseVisualStyleBackColor = true;
            this.getEmail.Click += new System.EventHandler(this.getEmail_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(679, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Word1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(729, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Word2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(811, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Word3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Заголовок:";
            // 
            // buttonSetToolTip
            // 
            this.buttonSetToolTip.Location = new System.Drawing.Point(436, 99);
            this.buttonSetToolTip.Name = "buttonSetToolTip";
            this.buttonSetToolTip.Size = new System.Drawing.Size(107, 23);
            this.buttonSetToolTip.TabIndex = 26;
            this.buttonSetToolTip.Text = "Set ToolTip";
            this.buttonSetToolTip.UseVisualStyleBackColor = true;
            this.buttonSetToolTip.Click += new System.EventHandler(this.buttonSetToolTip_Click);
            // 
            // emailInputComponent1
            // 
            this.emailInputComponent1.Location = new System.Drawing.Point(12, 58);
            this.emailInputComponent1.Name = "emailInputComponent1";
            this.emailInputComponent1.Pattern = "^(?(\")(\"[^\"]+?\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&\'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9" +
    "a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9]{" +
    "2,17}))$";
            this.emailInputComponent1.Size = new System.Drawing.Size(256, 70);
            this.emailInputComponent1.TabIndex = 18;
            // 
            // listBoxControl
            // 
            this.listBoxControl.Location = new System.Drawing.Point(15, 167);
            this.listBoxControl.Name = "listBoxControl";
            this.listBoxControl.SelectedIndex = -1;
            this.listBoxControl.Size = new System.Drawing.Size(342, 279);
            this.listBoxControl.TabIndex = 17;
            // 
            // dropDownListControl
            // 
            this.dropDownListControl.ChoosenLine = "";
            this.dropDownListControl.Location = new System.Drawing.Point(15, 12);
            this.dropDownListControl.Name = "dropDownListControl";
            this.dropDownListControl.Size = new System.Drawing.Size(128, 37);
            this.dropDownListControl.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 471);
            this.Controls.Add(this.buttonSetToolTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getEmail);
            this.Controls.Add(this.emailInputComponent1);
            this.Controls.Add(this.listBoxControl);
            this.Controls.Add(this.dropDownListControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setEmail);
            this.Controls.Add(this.clearTemplate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.fillList);
            this.Controls.Add(this.fillComboBox);
            this.Controls.Add(this.clearComboBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearComboBox;
        private System.Windows.Forms.Button fillComboBox;
        private System.Windows.Forms.Button fillList;
        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button clearTemplate;
        private System.Windows.Forms.Button setEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Components.DropDownListControl dropDownListControl;
        private Components.EmailInputComponent emailInputComponent;
        private Components.ListBoxControl listBoxControl;
        private Components.EmailInputComponent emailInputComponent1;
        private System.Windows.Forms.Button getEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSetToolTip;
    }
}

