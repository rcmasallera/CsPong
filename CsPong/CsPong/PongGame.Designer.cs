﻿namespace CsPong
{
    partial class PongGame
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
            this.bp = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bp
            // 
            this.bp.BackgroundImage = global::CsPong.Properties.Resources.ball;
            this.bp.Location = new System.Drawing.Point(339, 332);
            this.bp.MaximumSize = new System.Drawing.Size(15, 15);
            this.bp.MinimumSize = new System.Drawing.Size(15, 15);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(15, 15);
            this.bp.TabIndex = 0;
            // 
            // PongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 739);
            this.Controls.Add(this.bp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PongGame";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bp;
    }
}