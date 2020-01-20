﻿namespace TraningDiary
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
            this.createFolder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openTraning = new System.Windows.Forms.Button();
            this.savePdf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // createFolder
            // 
            this.createFolder.Location = new System.Drawing.Point(298, 90);
            this.createFolder.Name = "createFolder";
            this.createFolder.Size = new System.Drawing.Size(202, 40);
            this.createFolder.TabIndex = 1;
            this.createFolder.Text = "CREATE FOLDER \"TRAINING\"";
            this.createFolder.UseVisualStyleBackColor = true;
            this.createFolder.Click += new System.EventHandler(this.CreateFolder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openTraning
            // 
            this.openTraning.Location = new System.Drawing.Point(319, 154);
            this.openTraning.Name = "openTraning";
            this.openTraning.Size = new System.Drawing.Size(136, 46);
            this.openTraning.TabIndex = 4;
            this.openTraning.Text = "Open Your Training";
            this.openTraning.UseVisualStyleBackColor = true;
            this.openTraning.Click += new System.EventHandler(this.openTraning_Click);
            // 
            // savePdf
            // 
            this.savePdf.Location = new System.Drawing.Point(298, 439);
            this.savePdf.Name = "savePdf";
            this.savePdf.Size = new System.Drawing.Size(143, 66);
            this.savePdf.TabIndex = 6;
            this.savePdf.Text = "SAVE TO PDF";
            this.savePdf.UseVisualStyleBackColor = true;
            this.savePdf.Click += new System.EventHandler(this.savePdf_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 229);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 177);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.savePdf);
            this.Controls.Add(this.openTraning);
            this.Controls.Add(this.createFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openTraning;
        private System.Windows.Forms.Button savePdf;
        private System.Windows.Forms.TextBox textBox1;
    }
}

