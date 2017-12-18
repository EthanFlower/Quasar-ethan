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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.die18 = new System.Windows.Forms.Button();
            this.die47 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.betUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.mnyNum = new System.Windows.Forms.Label();
            this.mnyLb = new System.Windows.Forms.Label();
            this.rollNum = new System.Windows.Forms.Label();
            this.wentOver = new System.Windows.Forms.Label();
            this.betButt = new System.Windows.Forms.Button();
            this.profitLb = new System.Windows.Forms.Label();
            this.buttInstruct = new System.Windows.Forms.Button();
            this.lbRound = new System.Windows.Forms.Label();
            this.buttReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // die18
            // 
            this.die18.Location = new System.Drawing.Point(12, 118);
            this.die18.Name = "die18";
            this.die18.Size = new System.Drawing.Size(122, 44);
            this.die18.TabIndex = 0;
            this.die18.Text = "1-8";
            this.die18.UseVisualStyleBackColor = true;
            this.die18.Click += new System.EventHandler(this.die18_Click);
            // 
            // die47
            // 
            this.die47.Location = new System.Drawing.Point(277, 118);
            this.die47.Name = "die47";
            this.die47.Size = new System.Drawing.Size(122, 44);
            this.die47.TabIndex = 1;
            this.die47.Text = "4-7";
            this.die47.UseVisualStyleBackColor = true;
            this.die47.Click += new System.EventHandler(this.die47_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Fold";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "This is the amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // betUpDown
            // 
            this.betUpDown.Location = new System.Drawing.Point(145, 65);
            this.betUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.betUpDown.Minimum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.betUpDown.Name = "betUpDown";
            this.betUpDown.Size = new System.Drawing.Size(120, 20);
            this.betUpDown.TabIndex = 4;
            this.betUpDown.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnyNum
            // 
            this.mnyNum.AutoSize = true;
            this.mnyNum.Location = new System.Drawing.Point(12, 28);
            this.mnyNum.Name = "mnyNum";
            this.mnyNum.Size = new System.Drawing.Size(25, 13);
            this.mnyNum.TabIndex = 6;
            this.mnyNum.Text = "500";
            this.mnyNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnyLb
            // 
            this.mnyLb.AutoSize = true;
            this.mnyLb.Location = new System.Drawing.Point(12, 12);
            this.mnyLb.Name = "mnyLb";
            this.mnyLb.Size = new System.Drawing.Size(36, 13);
            this.mnyLb.TabIndex = 7;
            this.mnyLb.Text = "Points";
            this.mnyLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rollNum
            // 
            this.rollNum.AutoSize = true;
            this.rollNum.Location = new System.Drawing.Point(274, 25);
            this.rollNum.Name = "rollNum";
            this.rollNum.Size = new System.Drawing.Size(111, 13);
            this.rollNum.TabIndex = 8;
            this.rollNum.Text = "This is what you rolled";
            this.rollNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wentOver
            // 
            this.wentOver.AutoSize = true;
            this.wentOver.Location = new System.Drawing.Point(274, 38);
            this.wentOver.Name = "wentOver";
            this.wentOver.Size = new System.Drawing.Size(159, 13);
            this.wentOver.TabIndex = 9;
            this.wentOver.Text = "This tells you that you went over";
            this.wentOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // betButt
            // 
            this.betButt.Location = new System.Drawing.Point(173, 91);
            this.betButt.Name = "betButt";
            this.betButt.Size = new System.Drawing.Size(65, 23);
            this.betButt.TabIndex = 10;
            this.betButt.Text = "Bet";
            this.betButt.UseVisualStyleBackColor = true;
            this.betButt.Click += new System.EventHandler(this.betButt_Click);
            // 
            // profitLb
            // 
            this.profitLb.AutoSize = true;
            this.profitLb.Location = new System.Drawing.Point(12, 41);
            this.profitLb.Name = "profitLb";
            this.profitLb.Size = new System.Drawing.Size(106, 13);
            this.profitLb.TabIndex = 11;
            this.profitLb.Text = "This is what you won";
            this.profitLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttInstruct
            // 
            this.buttInstruct.Location = new System.Drawing.Point(152, 13);
            this.buttInstruct.Name = "buttInstruct";
            this.buttInstruct.Size = new System.Drawing.Size(107, 25);
            this.buttInstruct.TabIndex = 12;
            this.buttInstruct.Text = "Instructions";
            this.buttInstruct.UseVisualStyleBackColor = true;
            this.buttInstruct.Click += new System.EventHandler(this.buttInstruct_Click);
            // 
            // lbRound
            // 
            this.lbRound.AutoSize = true;
            this.lbRound.Location = new System.Drawing.Point(274, 72);
            this.lbRound.Name = "lbRound";
            this.lbRound.Size = new System.Drawing.Size(85, 13);
            this.lbRound.TabIndex = 13;
            this.lbRound.Text = "This is the round";
            this.lbRound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttReset
            // 
            this.buttReset.Location = new System.Drawing.Point(277, 88);
            this.buttReset.Name = "buttReset";
            this.buttReset.Size = new System.Drawing.Size(107, 25);
            this.buttReset.TabIndex = 14;
            this.buttReset.Text = "Restart?";
            this.buttReset.UseVisualStyleBackColor = true;
            this.buttReset.Click += new System.EventHandler(this.buttReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Fold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(412, 169);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttReset);
            this.Controls.Add(this.lbRound);
            this.Controls.Add(this.buttInstruct);
            this.Controls.Add(this.profitLb);
            this.Controls.Add(this.betButt);
            this.Controls.Add(this.wentOver);
            this.Controls.Add(this.rollNum);
            this.Controls.Add(this.mnyLb);
            this.Controls.Add(this.mnyNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.die47);
            this.Controls.Add(this.die18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.betUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button die18;
        private System.Windows.Forms.Button die47;
        private System.Windows.Forms.NumericUpDown betUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mnyNum;
        private System.Windows.Forms.Label mnyLb;
        private System.Windows.Forms.Button betButt;
        private System.Windows.Forms.Label profitLb;
        public System.Windows.Forms.Label rollNum;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label wentOver;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttInstruct;
        public System.Windows.Forms.Label lbRound;
        public System.Windows.Forms.Button buttReset;
        public System.Windows.Forms.Button button1;
    }
}

