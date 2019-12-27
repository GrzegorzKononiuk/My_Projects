namespace CardGame
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
            this.label2 = new System.Windows.Forms.Label();
            this.playerDeck = new System.Windows.Forms.ListBox();
            this.enemyDeck = new System.Windows.Forms.ListBox();
            this.compare = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.moveToTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(132, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Cards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(572, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enemy Cards";
            // 
            // playerDeck
            // 
            this.playerDeck.FormattingEnabled = true;
            this.playerDeck.Location = new System.Drawing.Point(108, 123);
            this.playerDeck.Name = "playerDeck";
            this.playerDeck.Size = new System.Drawing.Size(120, 95);
            this.playerDeck.TabIndex = 4;
            // 
            // enemyDeck
            // 
            this.enemyDeck.FormattingEnabled = true;
            this.enemyDeck.Location = new System.Drawing.Point(551, 123);
            this.enemyDeck.Name = "enemyDeck";
            this.enemyDeck.Size = new System.Drawing.Size(120, 95);
            this.enemyDeck.TabIndex = 5;
            // 
            // compare
            // 
            this.compare.FormattingEnabled = true;
            this.compare.Location = new System.Drawing.Point(346, 123);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(120, 95);
            this.compare.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table";
            // 
            // moveToTable
            // 
            this.moveToTable.Location = new System.Drawing.Point(246, 154);
            this.moveToTable.Name = "moveToTable";
            this.moveToTable.Size = new System.Drawing.Size(75, 23);
            this.moveToTable.TabIndex = 8;
            this.moveToTable.Text = ">>";
            this.moveToTable.UseVisualStyleBackColor = true;
            this.moveToTable.Click += new System.EventHandler(this.moveToTable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(256, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "HIGHER VALUE WINING !";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.textBox1.Location = new System.Drawing.Point(145, 296);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 64);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label5.Location = new System.Drawing.Point(92, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "PLAYER POINTS";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.textBox2.Location = new System.Drawing.Point(585, 296);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 64);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label6.Location = new System.Drawing.Point(538, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "ENEMY POINTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moveToTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.enemyDeck);
            this.Controls.Add(this.playerDeck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playerDeck;
        private System.Windows.Forms.ListBox enemyDeck;
        private System.Windows.Forms.ListBox compare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button moveToTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

