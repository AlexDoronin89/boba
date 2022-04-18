namespace ProjectMVP.View
{
    partial class Form2
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
            this.buttonAddWarehouse = new System.Windows.Forms.Button();
            this.textBoxCountShelfs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountRacks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddWarehouse
            // 
            this.buttonAddWarehouse.BackColor = System.Drawing.Color.White;
            this.buttonAddWarehouse.Location = new System.Drawing.Point(62, 100);
            this.buttonAddWarehouse.Name = "buttonAddWarehouse";
            this.buttonAddWarehouse.Size = new System.Drawing.Size(85, 41);
            this.buttonAddWarehouse.TabIndex = 0;
            this.buttonAddWarehouse.Text = "Добавить";
            this.buttonAddWarehouse.UseVisualStyleBackColor = false;
            this.buttonAddWarehouse.Click += new System.EventHandler(this.buttonAddWarehouse_Click);
            // 
            // textBoxCountShelfs
            // 
            this.textBoxCountShelfs.Location = new System.Drawing.Point(118, 12);
            this.textBoxCountShelfs.Name = "textBoxCountShelfs";
            this.textBoxCountShelfs.Size = new System.Drawing.Size(74, 20);
            this.textBoxCountShelfs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол - во полок";
            // 
            // textBoxCountRacks
            // 
            this.textBoxCountRacks.Location = new System.Drawing.Point(118, 44);
            this.textBoxCountRacks.Name = "textBoxCountRacks";
            this.textBoxCountRacks.Size = new System.Drawing.Size(74, 20);
            this.textBoxCountRacks.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Кол - во стелажей";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(208, 163);
            this.Controls.Add(this.textBoxCountRacks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCountShelfs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddWarehouse);
            this.Name = "Form2";
            this.Text = "Редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddWarehouse;
        private System.Windows.Forms.TextBox textBoxCountShelfs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountRacks;
        private System.Windows.Forms.Label label1;
    }
}