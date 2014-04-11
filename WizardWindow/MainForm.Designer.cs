using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace WizardWindow
{
    partial class MainForm
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
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVideo
            // 
            this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgVideo.Location = new System.Drawing.Point(0, 0);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(904, 623);
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 22);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgVideo);
            this.Name = "MainForm";
            this.Text = "WinForm C# WebCam";
            this.Load += new System.EventHandler(this.mainWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVideo;
        private Button button1;
    }
}

