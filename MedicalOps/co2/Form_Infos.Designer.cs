﻿namespace co2
{
    partial class Form_Infos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Infos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button_sortiepatient = new System.Windows.Forms.Button();
            this.B_arriveepatient = new System.Windows.Forms.Button();
            this.TB_Pathologie = new System.Windows.Forms.TextBox();
            this.NumBadge = new System.Windows.Forms.TextBox();
            this.TB_prenom = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_com = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.Button_sortiepatient);
            this.groupBox1.Controls.Add(this.B_arriveepatient);
            this.groupBox1.Controls.Add(this.TB_Pathologie);
            this.groupBox1.Controls.Add(this.NumBadge);
            this.groupBox1.Controls.Add(this.TB_prenom);
            this.groupBox1.Controls.Add(this.TB_Nom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(17)))));
            this.groupBox1.Location = new System.Drawing.Point(698, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 517);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du patient ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 441);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 50);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Button_sortiepatient
            // 
            this.Button_sortiepatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.Button_sortiepatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_sortiepatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_sortiepatient.Location = new System.Drawing.Point(348, 338);
            this.Button_sortiepatient.Name = "Button_sortiepatient";
            this.Button_sortiepatient.Size = new System.Drawing.Size(90, 78);
            this.Button_sortiepatient.TabIndex = 10;
            this.Button_sortiepatient.Text = "Sortie patient";
            this.Button_sortiepatient.UseVisualStyleBackColor = false;
            this.Button_sortiepatient.Click += new System.EventHandler(this.Button_sortiepatient_Click);
            // 
            // B_arriveepatient
            // 
            this.B_arriveepatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.B_arriveepatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_arriveepatient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B_arriveepatient.Location = new System.Drawing.Point(205, 338);
            this.B_arriveepatient.Name = "B_arriveepatient";
            this.B_arriveepatient.Size = new System.Drawing.Size(125, 78);
            this.B_arriveepatient.TabIndex = 9;
            this.B_arriveepatient.Text = "arrivée patient ";
            this.B_arriveepatient.UseVisualStyleBackColor = false;
            this.B_arriveepatient.Click += new System.EventHandler(this.B_arriveepatient_Click);
            // 
            // TB_Pathologie
            // 
            this.TB_Pathologie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_Pathologie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pathologie.Location = new System.Drawing.Point(205, 190);
            this.TB_Pathologie.Multiline = true;
            this.TB_Pathologie.Name = "TB_Pathologie";
            this.TB_Pathologie.Size = new System.Drawing.Size(210, 124);
            this.TB_Pathologie.TabIndex = 7;
            // 
            // NumBadge
            // 
            this.NumBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.NumBadge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBadge.Location = new System.Drawing.Point(205, 152);
            this.NumBadge.Name = "NumBadge";
            this.NumBadge.Size = new System.Drawing.Size(210, 29);
            this.NumBadge.TabIndex = 6;
            this.NumBadge.TextChanged += new System.EventHandler(this.NumBadge_TextChanged);
            // 
            // TB_prenom
            // 
            this.TB_prenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_prenom.Location = new System.Drawing.Point(205, 96);
            this.TB_prenom.Name = "TB_prenom";
            this.TB_prenom.Size = new System.Drawing.Size(210, 29);
            this.TB_prenom.TabIndex = 5;
            // 
            // TB_Nom
            // 
            this.TB_Nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Nom.Location = new System.Drawing.Point(205, 51);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(210, 29);
            this.TB_Nom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numéro de badge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pathologie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ";
            // 
            // t_com
            // 
            this.t_com.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.t_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_com.FormattingEnabled = true;
            this.t_com.Location = new System.Drawing.Point(963, 565);
            this.t_com.Name = "t_com";
            this.t_com.Size = new System.Drawing.Size(150, 32);
            this.t_com.TabIndex = 3;
            this.t_com.Visible = false;
            this.t_com.SelectedIndexChanged += new System.EventHandler(this.t_com_SelectedIndexChanged);
            // 
            // Form_Infos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(1183, 609);
            this.Controls.Add(this.t_com);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Infos";
            this.Text = "Form_Infos";
            this.Load += new System.EventHandler(this.Form_Infos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_Pathologie;
        private System.Windows.Forms.TextBox NumBadge;
        private System.Windows.Forms.TextBox TB_prenom;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox t_com;
        private System.Windows.Forms.Button Button_sortiepatient;
        private System.Windows.Forms.Button B_arriveepatient;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}