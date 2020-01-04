namespace TraningDiary
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
            this.label1 = new System.Windows.Forms.Label();
            this.fbwOpen = new System.Windows.Forms.Button();
            this.splitOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.setTraning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(194, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE YOUR TRAINING MODE";
            // 
            // fbwOpen
            // 
            this.fbwOpen.Location = new System.Drawing.Point(155, 93);
            this.fbwOpen.Name = "fbwOpen";
            this.fbwOpen.Size = new System.Drawing.Size(202, 40);
            this.fbwOpen.TabIndex = 1;
            this.fbwOpen.Text = "GENERATE FBW (FULL BODY WORKOUT TRAINING) ";
            this.fbwOpen.UseVisualStyleBackColor = true;
            this.fbwOpen.Click += new System.EventHandler(this.fbwOpen_Click);
            // 
            // splitOpen
            // 
            this.splitOpen.Location = new System.Drawing.Point(433, 93);
            this.splitOpen.Name = "splitOpen";
            this.splitOpen.Size = new System.Drawing.Size(202, 40);
            this.splitOpen.TabIndex = 2;
            this.splitOpen.Text = "SPLIT";
            this.splitOpen.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(731, 222);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // setTraning
            // 
            this.setTraning.Location = new System.Drawing.Point(180, 153);
            this.setTraning.Name = "setTraning";
            this.setTraning.Size = new System.Drawing.Size(136, 46);
            this.setTraning.TabIndex = 4;
            this.setTraning.Text = "Set Traning";
            this.setTraning.UseVisualStyleBackColor = true;
            this.setTraning.Click += new System.EventHandler(this.setTraning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.setTraning);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitOpen);
            this.Controls.Add(this.fbwOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fbwOpen;
        private System.Windows.Forms.Button splitOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button setTraning;
    }
}

