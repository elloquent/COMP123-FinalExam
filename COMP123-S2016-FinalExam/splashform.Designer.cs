﻿namespace COMP123_M2020_FinalExam
{
    partial class splashform
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
            this.components = new System.ComponentModel.Container();
            this.splashtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // splashtimer
            // 
            this.splashtimer.Enabled = true;
            this.splashtimer.Interval = 3000;
            this.splashtimer.Tick += new System.EventHandler(this.splashtimer_Tick);
            // 
            // splashform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::COMP123_M2020_FinalExam.Properties.Resources.splashSceen;
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "splashform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashform";
            this.Load += new System.EventHandler(this.splashform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer splashtimer;
    }
}