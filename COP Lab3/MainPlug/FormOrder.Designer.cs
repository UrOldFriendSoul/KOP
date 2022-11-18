namespace COP_Lab3.MainPlug
{
    partial class FormOrder
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.inputComponent = new lab1COP.Components.InputComponent();
            this.labelSummary = new System.Windows.Forms.Label();
            this.dropDownListControl = new WindowsFormsControlLibraryKutygin.VisualComponents.DropDownListControl();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(190, 13);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(598, 22);
            this.textBoxFIO.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(190, 98);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(598, 22);
            this.textBoxDescription.TabIndex = 0;
            // 
            // inputComponent
            // 
            this.inputComponent.Location = new System.Drawing.Point(171, 226);
            this.inputComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputComponent.Name = "inputComponent";
            this.inputComponent.Number = null;
            this.inputComponent.Size = new System.Drawing.Size(418, 88);
            this.inputComponent.TabIndex = 1;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(13, 244);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(100, 16);
            this.labelSummary.TabIndex = 2;
            this.labelSummary.Text = "Сумма заказа";
            // 
            // dropDownListControl
            // 
            this.dropDownListControl.ChoosenLine = "";
            this.dropDownListControl.Location = new System.Drawing.Point(190, 159);
            this.dropDownListControl.Name = "dropDownListControl";
            this.dropDownListControl.Size = new System.Drawing.Size(150, 37);
            this.dropDownListControl.TabIndex = 3;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(16, 171);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(103, 16);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Статус заказа";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(19, 98);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(130, 16);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание товаров";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(22, 13);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(111, 16);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "ФИО заказчика";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(323, 365);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(161, 73);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.dropDownListControl);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.inputComponent);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxFIO);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxDescription;
        private lab1COP.Components.InputComponent inputComponent;
        private System.Windows.Forms.Label labelSummary;
        private WindowsFormsControlLibraryKutygin.VisualComponents.DropDownListControl dropDownListControl;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button buttonSave;
    }
}