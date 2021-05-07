namespace co2
{
    partial class Form_Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Acceuil));
            this.button_ModifierBase = new System.Windows.Forms.Button();
            this.button_connexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ModifierBase
            // 
            this.button_ModifierBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.button_ModifierBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ModifierBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModifierBase.Location = new System.Drawing.Point(161, 130);
            this.button_ModifierBase.Name = "button_ModifierBase";
            this.button_ModifierBase.Size = new System.Drawing.Size(206, 91);
            this.button_ModifierBase.TabIndex = 0;
            this.button_ModifierBase.Text = "Modifier l\'adresse de la base ";
            this.button_ModifierBase.UseVisualStyleBackColor = false;
            this.button_ModifierBase.Click += new System.EventHandler(this.button_ModifierBase_Click);
            // 
            // button_connexion
            // 
            this.button_connexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.button_connexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connexion.Location = new System.Drawing.Point(161, 27);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(206, 76);
            this.button_connexion.TabIndex = 2;
            this.button_connexion.Text = "Se connecter ";
            this.button_connexion.UseVisualStyleBackColor = false;
            this.button_connexion.Click += new System.EventHandler(this.button_Connexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "MedicalTrack";
            // 
            // Form_Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(65)))), ((int)(((byte)(114)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(442, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_connexion);
            this.Controls.Add(this.button_ModifierBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Acceuil";
            this.Text = "Page d\'acceuil";
            this.Load += new System.EventHandler(this.Form_Acceuil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ModifierBase;
        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.Label label1;
    }
}

