﻿namespace EditareAudioVideo1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.histo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gamma = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(109, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 194);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // histo
            // 
            this.histo.Location = new System.Drawing.Point(685, 264);
            this.histo.Name = "histo";
            this.histo.Size = new System.Drawing.Size(126, 51);
            this.histo.TabIndex = 0;
            this.histo.Text = "histo";
            this.histo.Click += new System.EventHandler(this.histo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(685, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "brightness";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(687, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "ImageFilter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // gamma
            // 
            this.gamma.Location = new System.Drawing.Point(517, 447);
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(132, 22);
            this.gamma.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(687, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 67);
            this.button5.TabIndex = 7;
            this.button5.Text = "rotate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(684, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 75);
            this.button6.TabIndex = 8;
            this.button6.Text = "resize";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 522);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.gamma);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.histo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button histo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox gamma;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

