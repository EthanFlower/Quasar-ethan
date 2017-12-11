namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.die18 = new System.Windows.Forms.Button();
            this.die47 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.mnyNum = new System.Windows.Forms.Label();
            this.mnyLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // die18
            // 
            this.die18.Location = new System.Drawing.Point(12, 407);
            this.die18.Name = "die18";
            this.die18.Size = new System.Drawing.Size(122, 44);
            this.die18.TabIndex = 0;
            this.die18.Text = "1-8";
            this.die18.UseVisualStyleBackColor = true;
            this.die18.Click += new System.EventHandler(this.die18_Click);
            // 
            // die47
            // 
            this.die47.Location = new System.Drawing.Point(277, 407);
            this.die47.Name = "die47";
            this.die47.Size = new System.Drawing.Size(122, 44);
            this.die47.TabIndex = 1;
            this.die47.Text = "4-7";
            this.die47.UseVisualStyleBackColor = true;
            this.die47.Click += new System.EventHandler(this.die47_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fold";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnyNum
            // 
            this.mnyNum.AutoSize = true;
            this.mnyNum.Location = new System.Drawing.Point(274, 54);
            this.mnyNum.Name = "mnyNum";
            this.mnyNum.Size = new System.Drawing.Size(25, 13);
            this.mnyNum.TabIndex = 6;
            this.mnyNum.Text = "500";
            this.mnyNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnyLb
            // 
            this.mnyLb.AutoSize = true;
            this.mnyLb.Location = new System.Drawing.Point(274, 38);
            this.mnyLb.Name = "mnyLb";
            this.mnyLb.Size = new System.Drawing.Size(39, 13);
            this.mnyLb.TabIndex = 7;
            this.mnyLb.Text = "Money";
            this.mnyLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 463);
            this.Controls.Add(this.mnyLb);
            this.Controls.Add(this.mnyNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.die47);
            this.Controls.Add(this.die18);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button die18;
        private System.Windows.Forms.Button die47;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mnyNum;
        private System.Windows.Forms.Label mnyLb;
    }
}

