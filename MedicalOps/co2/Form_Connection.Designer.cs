﻿namespace co2
{
    partial class Form_Connection
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
            this.TB_Motdepasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_connexion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Connexion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(133, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la salle";
            // 
            // TB_Motdepasse
            // 
            this.TB_Motdepasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_Motdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Motdepasse.Location = new System.Drawing.Point(316, 220);
            this.TB_Motdepasse.Name = "TB_Motdepasse";
            this.TB_Motdepasse.PasswordChar = '*';
            this.TB_Motdepasse.Size = new System.Drawing.Size(355, 31);
            this.TB_Motdepasse.TabIndex = 3;
            this.TB_Motdepasse.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(133, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // B_connexion
            // 
            this.B_connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.B_connexion.Location = new System.Drawing.Point(353, 314);
            this.B_connexion.Name = "B_connexion";
            this.B_connexion.Size = new System.Drawing.Size(168, 82);
            this.B_connexion.TabIndex = 4;
            this.B_connexion.Text = "Se connecter ";
            this.B_connexion.UseVisualStyleBackColor = false;
            this.B_connexion.Click += new System.EventHandler(this.B_connexion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(229, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bienvenue sur MédicalOps";
            // 
            // TB_Connexion
            // 
            this.TB_Connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_Connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Connexion.FormattingEnabled = true;
            this.TB_Connexion.Items.AddRange(new object[] {
            "sallop1",
            "sallop2",
            "sallereveil",
            "salleanesthesie",
            "sallereanimation",
            "",
            ""});
            this.TB_Connexion.Location = new System.Drawing.Point(316, 136);
            this.TB_Connexion.Name = "TB_Connexion";
            this.TB_Connexion.Size = new System.Drawing.Size(355, 32);
            this.TB_Connexion.TabIndex = 6;
            // 
            // Form_Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(868, 466);
            this.Controls.Add(this.TB_Connexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_connexion);
            this.Controls.Add(this.TB_Motdepasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Connection";
            this.Text = "      ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Motdepasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_connexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TB_Connexion;
    }
}