﻿namespace co2
{
    partial class Form_brancardiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_brancardiers));
            this.b_sendalert = new System.Windows.Forms.Button();
            this.cb_nom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumBadge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_com = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_sendalert
            // 
            this.b_sendalert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.b_sendalert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sendalert.Location = new System.Drawing.Point(466, 100);
            this.b_sendalert.Name = "b_sendalert";
            this.b_sendalert.Size = new System.Drawing.Size(197, 63);
            this.b_sendalert.TabIndex = 0;
            this.b_sendalert.Text = "Envoyer l\'alerte ";
            this.b_sendalert.UseVisualStyleBackColor = false;
            this.b_sendalert.Click += new System.EventHandler(this.b_sendalert_Click);
            // 
            // cb_nom
            // 
            this.cb_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.cb_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nom.FormattingEnabled = true;
            this.cb_nom.Location = new System.Drawing.Point(62, 69);
            this.cb_nom.Name = "cb_nom";
            this.cb_nom.Size = new System.Drawing.Size(304, 32);
            this.cb_nom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "sélection du brancardier ";
            // 
            // NumBadge
            // 
            this.NumBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.NumBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBadge.Location = new System.Drawing.Point(62, 182);
            this.NumBadge.Name = "NumBadge";
            this.NumBadge.Size = new System.Drawing.Size(304, 29);
            this.NumBadge.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(70, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "numéro de badge du patient  ";
            // 
            // t_com
            // 
            this.t_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.t_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_com.FormattingEnabled = true;
            this.t_com.Location = new System.Drawing.Point(705, 21);
            this.t_com.Name = "t_com";
            this.t_com.Size = new System.Drawing.Size(121, 32);
            this.t_com.TabIndex = 1;
            this.t_com.Visible = false;
            this.t_com.SelectedIndexChanged += new System.EventHandler(this.t_com_SelectedIndexChanged);
            // 
            // Form_brancardiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(838, 250);
            this.Controls.Add(this.t_com);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumBadge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_nom);
            this.Controls.Add(this.b_sendalert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_brancardiers";
            this.Text = "Form_brancardiers";
            this.Load += new System.EventHandler(this.Form_brancardiers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_sendalert;
        private System.Windows.Forms.ComboBox cb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumBadge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox t_com;
    }
}