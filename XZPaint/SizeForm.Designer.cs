namespace XZPaint
{
    partial class SizeForm
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
            this.WidthNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthNumericUpDown1
            // 
            this.WidthNumericUpDown1.Location = new System.Drawing.Point(53, 18);
            this.WidthNumericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.WidthNumericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumericUpDown1.Name = "WidthNumericUpDown1";
            this.WidthNumericUpDown1.Size = new System.Drawing.Size(107, 20);
            this.WidthNumericUpDown1.TabIndex = 0;
            this.WidthNumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // HeightNumericUpDown2
            // 
            this.HeightNumericUpDown2.Location = new System.Drawing.Point(53, 45);
            this.HeightNumericUpDown2.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.HeightNumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumericUpDown2.Name = "HeightNumericUpDown2";
            this.HeightNumericUpDown2.Size = new System.Drawing.Size(107, 20);
            this.HeightNumericUpDown2.TabIndex = 2;
            this.HeightNumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(44, 81);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // SizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 116);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeightNumericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthNumericUpDown1);
            this.MaximumSize = new System.Drawing.Size(192, 155);
            this.MinimumSize = new System.Drawing.Size(192, 155);
            this.Name = "SizeForm";
            this.Text = "SizeForm";
            this.Shown += new System.EventHandler(this.SizeForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown WidthNumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonApply;
    }
}