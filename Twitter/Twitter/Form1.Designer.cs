﻿namespace Twitter
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
            this.txtTwitterMsg = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblPostedMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTwitterMsg
            // 
            this.txtTwitterMsg.Location = new System.Drawing.Point(37, 12);
            this.txtTwitterMsg.Multiline = true;
            this.txtTwitterMsg.Name = "txtTwitterMsg";
            this.txtTwitterMsg.Size = new System.Drawing.Size(168, 106);
            this.txtTwitterMsg.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Location = new System.Drawing.Point(73, 137);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(100, 23);
            this.lblCounter.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPost.Location = new System.Drawing.Point(87, 191);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblPostedMsg
            // 
            this.lblPostedMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostedMsg.Location = new System.Drawing.Point(73, 259);
            this.lblPostedMsg.Name = "lblPostedMsg";
            this.lblPostedMsg.Size = new System.Drawing.Size(100, 23);
            this.lblPostedMsg.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 363);
            this.Controls.Add(this.lblPostedMsg);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtTwitterMsg);
            this.Name = "Form1";
            this.Text = "Twitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTwitterMsg;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblPostedMsg;
    }
}

