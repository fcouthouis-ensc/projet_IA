﻿namespace Ex1_Questionnaire
{
    partial class Resultat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultat));
            this.score_lb = new System.Windows.Forms.Label();
            this.scoreReel_lb = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            this.accueil_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.BackColor = System.Drawing.Color.Transparent;
            this.score_lb.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.score_lb.Location = new System.Drawing.Point(16, 70);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(667, 60);
            this.score_lb.TabIndex = 0;
            this.score_lb.Text = "Vous avez obtenu la note";
            this.score_lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // scoreReel_lb
            // 
            this.scoreReel_lb.AutoSize = true;
            this.scoreReel_lb.BackColor = System.Drawing.Color.Transparent;
            this.scoreReel_lb.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreReel_lb.ForeColor = System.Drawing.Color.Red;
            this.scoreReel_lb.Location = new System.Drawing.Point(237, 205);
            this.scoreReel_lb.Name = "scoreReel_lb";
            this.scoreReel_lb.Size = new System.Drawing.Size(248, 79);
            this.scoreReel_lb.TabIndex = 2;
            this.scoreReel_lb.Text = "XX / 20";
            this.scoreReel_lb.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.scoreReel_lb.Click += new System.EventHandler(this.scoreReel_lb_Click);
            // 
            // restart_btn
            // 
            this.restart_btn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_btn.Location = new System.Drawing.Point(158, 317);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(142, 32);
            this.restart_btn.TabIndex = 3;
            this.restart_btn.Text = "Recommencer";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // accueil_btn
            // 
            this.accueil_btn.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueil_btn.Location = new System.Drawing.Point(454, 317);
            this.accueil_btn.Name = "accueil_btn";
            this.accueil_btn.Size = new System.Drawing.Size(103, 32);
            this.accueil_btn.TabIndex = 4;
            this.accueil_btn.Text = "Accueil";
            this.accueil_btn.UseVisualStyleBackColor = true;
            this.accueil_btn.Click += new System.EventHandler(this.accueil_btn_Click);
            // 
            // Resultat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 367);
            this.Controls.Add(this.accueil_btn);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.scoreReel_lb);
            this.Controls.Add(this.score_lb);
            this.Name = "Resultat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label scoreReel_lb;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Button accueil_btn;
    }
}