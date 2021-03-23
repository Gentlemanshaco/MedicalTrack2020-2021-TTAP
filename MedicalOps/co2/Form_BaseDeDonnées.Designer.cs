namespace co2
{
    partial class Form_BaseDeDonnées
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
            this.TB_adresse = new System.Windows.Forms.TextBox();
            this.TB_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_mdp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_nombase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.B_Sauvegarde = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse de la base ";
            // 
            // TB_adresse
            // 
            this.TB_adresse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_adresse.Location = new System.Drawing.Point(244, 77);
            this.TB_adresse.Name = "TB_adresse";
            this.TB_adresse.Size = new System.Drawing.Size(299, 31);
            this.TB_adresse.TabIndex = 1;
            // 
            // TB_user
            // 
            this.TB_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_user.Location = new System.Drawing.Point(244, 216);
            this.TB_user.Name = "TB_user";
            this.TB_user.Size = new System.Drawing.Size(299, 31);
            this.TB_user.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom d\'utilisateur ";
            // 
            // TB_mdp
            // 
            this.TB_mdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_mdp.Location = new System.Drawing.Point(244, 288);
            this.TB_mdp.Name = "TB_mdp";
            this.TB_mdp.Size = new System.Drawing.Size(299, 31);
            this.TB_mdp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe";
            // 
            // TB_nombase
            // 
            this.TB_nombase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.TB_nombase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nombase.Location = new System.Drawing.Point(244, 145);
            this.TB_nombase.Name = "TB_nombase";
            this.TB_nombase.Size = new System.Drawing.Size(299, 31);
            this.TB_nombase.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom de la base ";
            // 
            // B_Sauvegarde
            // 
            this.B_Sauvegarde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.B_Sauvegarde.Location = new System.Drawing.Point(617, 71);
            this.B_Sauvegarde.Name = "B_Sauvegarde";
            this.B_Sauvegarde.Size = new System.Drawing.Size(148, 64);
            this.B_Sauvegarde.TabIndex = 8;
            this.B_Sauvegarde.Text = "Sauvegarder les changements";
            this.B_Sauvegarde.UseVisualStyleBackColor = false;
            this.B_Sauvegarde.Click += new System.EventHandler(this.B_Sauvegarde_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(325, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(648, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_BaseDeDonnées
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(777, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.B_Sauvegarde);
            this.Controls.Add(this.TB_nombase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_mdp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_adresse);
            this.Controls.Add(this.label1);
            this.Name = "Form_BaseDeDonnées";
            this.Text = "Modification des paramètres de connexion";
            this.Load += new System.EventHandler(this.Form_BaseDeDonnées_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_adresse;
        private System.Windows.Forms.TextBox TB_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_mdp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_nombase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_Sauvegarde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}