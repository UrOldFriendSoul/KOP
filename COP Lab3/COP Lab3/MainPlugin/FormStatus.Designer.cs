namespace COP_Lab3.MainPlugin
{
    partial class FormStatus
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
            this.dataGridViewStatus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatus
            // 
            this.dataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus.Location = new System.Drawing.Point(1, 2);
            this.dataGridViewStatus.Name = "dataGridViewStatus";
            this.dataGridViewStatus.RowHeadersWidth = 51;
            this.dataGridViewStatus.RowTemplate.Height = 24;
            this.dataGridViewStatus.Size = new System.Drawing.Size(799, 447);
            this.dataGridViewStatus.TabIndex = 0;
            this.dataGridViewStatus.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStatus_CellEndEdit);
            this.dataGridViewStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewStatus_KeyDown);
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStatus);
            this.Name = "FormStatus";
            this.Text = "Статус";
            this.Load += new System.EventHandler(this.FormStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatus;
    }
}