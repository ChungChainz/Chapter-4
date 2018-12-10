namespace RockPaperScissors.cs
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
            this.lblTitleP1 = new System.Windows.Forms.Label();
            this.lblTitleP2 = new System.Windows.Forms.Label();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.txtChoice2 = new System.Windows.Forms.TextBox();
            this.lblEnter1 = new System.Windows.Forms.Label();
            this.btnShoot = new System.Windows.Forms.Button();
            this.lblWinOrLose = new System.Windows.Forms.Label();
            this.lblWinOrLose2 = new System.Windows.Forms.Label();
            this.picPichachu1 = new System.Windows.Forms.PictureBox();
            this.lblPokemon = new System.Windows.Forms.Label();
            this.picGolem1 = new System.Windows.Forms.PictureBox();
            this.picScizor1 = new System.Windows.Forms.PictureBox();
            this.picScizor2 = new System.Windows.Forms.PictureBox();
            this.picGolem2 = new System.Windows.Forms.PictureBox();
            this.picPichachu2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPichachu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGolem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScizor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScizor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGolem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPichachu2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleP1
            // 
            this.lblTitleP1.AutoSize = true;
            this.lblTitleP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleP1.Location = new System.Drawing.Point(95, 85);
            this.lblTitleP1.Name = "lblTitleP1";
            this.lblTitleP1.Size = new System.Drawing.Size(77, 24);
            this.lblTitleP1.TabIndex = 0;
            this.lblTitleP1.Text = "Player 1";
            // 
            // lblTitleP2
            // 
            this.lblTitleP2.AutoSize = true;
            this.lblTitleP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleP2.Location = new System.Drawing.Point(614, 85);
            this.lblTitleP2.Name = "lblTitleP2";
            this.lblTitleP2.Size = new System.Drawing.Size(93, 24);
            this.lblTitleP2.TabIndex = 1;
            this.lblTitleP2.Text = "Computer";
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(84, 62);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(100, 20);
            this.txtChoice.TabIndex = 2;
            // 
            // txtChoice2
            // 
            this.txtChoice2.Location = new System.Drawing.Point(607, 62);
            this.txtChoice2.Name = "txtChoice2";
            this.txtChoice2.Size = new System.Drawing.Size(100, 20);
            this.txtChoice2.TabIndex = 3;
            // 
            // lblEnter1
            // 
            this.lblEnter1.AutoSize = true;
            this.lblEnter1.Location = new System.Drawing.Point(26, 34);
            this.lblEnter1.Name = "lblEnter1";
            this.lblEnter1.Size = new System.Drawing.Size(224, 13);
            this.lblEnter1.TabIndex = 6;
            this.lblEnter1.Text = "Enter r (Rock), p (Paper), or s (Scissors) below";
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(326, 61);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(122, 77);
            this.btnShoot.TabIndex = 7;
            this.btnShoot.Text = "Press to Start the Battle!";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // lblWinOrLose
            // 
            this.lblWinOrLose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinOrLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinOrLose.Location = new System.Drawing.Point(46, 359);
            this.lblWinOrLose.Name = "lblWinOrLose";
            this.lblWinOrLose.Size = new System.Drawing.Size(204, 23);
            this.lblWinOrLose.TabIndex = 8;
            // 
            // lblWinOrLose2
            // 
            this.lblWinOrLose2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinOrLose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinOrLose2.Location = new System.Drawing.Point(568, 359);
            this.lblWinOrLose2.Name = "lblWinOrLose2";
            this.lblWinOrLose2.Size = new System.Drawing.Size(204, 23);
            this.lblWinOrLose2.TabIndex = 9;
            // 
            // picPichachu1
            // 
            this.picPichachu1.Image = ((System.Drawing.Image)(resources.GetObject("picPichachu1.Image")));
            this.picPichachu1.Location = new System.Drawing.Point(46, 164);
            this.picPichachu1.Name = "picPichachu1";
            this.picPichachu1.Size = new System.Drawing.Size(204, 156);
            this.picPichachu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPichachu1.TabIndex = 10;
            this.picPichachu1.TabStop = false;
            this.picPichachu1.Visible = false;
            // 
            // lblPokemon
            // 
            this.lblPokemon.AutoSize = true;
            this.lblPokemon.Location = new System.Drawing.Point(310, 34);
            this.lblPokemon.Name = "lblPokemon";
            this.lblPokemon.Size = new System.Drawing.Size(163, 13);
            this.lblPokemon.TabIndex = 11;
            this.lblPokemon.Text = "Pokemon Rock, Paper, Scissors!";
            // 
            // picGolem1
            // 
            this.picGolem1.Image = ((System.Drawing.Image)(resources.GetObject("picGolem1.Image")));
            this.picGolem1.Location = new System.Drawing.Point(46, 164);
            this.picGolem1.Name = "picGolem1";
            this.picGolem1.Size = new System.Drawing.Size(201, 156);
            this.picGolem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGolem1.TabIndex = 12;
            this.picGolem1.TabStop = false;
            this.picGolem1.Visible = false;
            // 
            // picScizor1
            // 
            this.picScizor1.Image = ((System.Drawing.Image)(resources.GetObject("picScizor1.Image")));
            this.picScizor1.Location = new System.Drawing.Point(43, 164);
            this.picScizor1.Name = "picScizor1";
            this.picScizor1.Size = new System.Drawing.Size(204, 156);
            this.picScizor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScizor1.TabIndex = 16;
            this.picScizor1.TabStop = false;
            this.picScizor1.Visible = false;
            // 
            // picScizor2
            // 
            this.picScizor2.Image = ((System.Drawing.Image)(resources.GetObject("picScizor2.Image")));
            this.picScizor2.Location = new System.Drawing.Point(568, 153);
            this.picScizor2.Name = "picScizor2";
            this.picScizor2.Size = new System.Drawing.Size(204, 156);
            this.picScizor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScizor2.TabIndex = 17;
            this.picScizor2.TabStop = false;
            this.picScizor2.Visible = false;
            // 
            // picGolem2
            // 
            this.picGolem2.Image = ((System.Drawing.Image)(resources.GetObject("picGolem2.Image")));
            this.picGolem2.Location = new System.Drawing.Point(568, 153);
            this.picGolem2.Name = "picGolem2";
            this.picGolem2.Size = new System.Drawing.Size(201, 156);
            this.picGolem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGolem2.TabIndex = 18;
            this.picGolem2.TabStop = false;
            this.picGolem2.Visible = false;
            // 
            // picPichachu2
            // 
            this.picPichachu2.Image = ((System.Drawing.Image)(resources.GetObject("picPichachu2.Image")));
            this.picPichachu2.Location = new System.Drawing.Point(568, 153);
            this.picPichachu2.Name = "picPichachu2";
            this.picPichachu2.Size = new System.Drawing.Size(204, 156);
            this.picPichachu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPichachu2.TabIndex = 19;
            this.picPichachu2.TabStop = false;
            this.picPichachu2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picScizor2);
            this.Controls.Add(this.picGolem2);
            this.Controls.Add(this.picScizor1);
            this.Controls.Add(this.picGolem1);
            this.Controls.Add(this.lblPokemon);
            this.Controls.Add(this.picPichachu1);
            this.Controls.Add(this.lblWinOrLose2);
            this.Controls.Add(this.lblWinOrLose);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.lblEnter1);
            this.Controls.Add(this.txtChoice2);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.lblTitleP2);
            this.Controls.Add(this.lblTitleP1);
            this.Controls.Add(this.picPichachu2);
            this.Name = "Form1";
            this.Text = "Rock, Paper, or Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picPichachu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGolem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScizor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScizor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGolem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPichachu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleP1;
        private System.Windows.Forms.Label lblTitleP2;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.TextBox txtChoice2;
        private System.Windows.Forms.Label lblEnter1;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Label lblWinOrLose;
        private System.Windows.Forms.Label lblWinOrLose2;
        private System.Windows.Forms.PictureBox picPichachu1;
        private System.Windows.Forms.Label lblPokemon;
        private System.Windows.Forms.PictureBox picGolem1;
        private System.Windows.Forms.PictureBox picScizor1;
        private System.Windows.Forms.PictureBox picScizor2;
        private System.Windows.Forms.PictureBox picGolem2;
        private System.Windows.Forms.PictureBox picPichachu2;
    }
}

