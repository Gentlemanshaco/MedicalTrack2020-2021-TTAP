namespace Medical_admin
{
    partial class accueil
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
            this.patient = new System.Windows.Forms.Button();
            this.emprinteNum = new System.Windows.Forms.Button();
            this.PersoHosp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patient
            // 
            this.patient.Location = new System.Drawing.Point(37, 107);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(75, 23);
            this.patient.TabIndex = 0;
            this.patient.Text = "patient";
            this.patient.UseVisualStyleBackColor = true;
            // 
            // emprinteNum
            // 
            this.emprinteNum.Location = new System.Drawing.Point(194, 107);
            this.emprinteNum.Name = "emprinteNum";
            this.emprinteNum.Size = new System.Drawing.Size(75, 23);
            this.emprinteNum.TabIndex = 1;
            this.emprinteNum.Text = "emprinte digitale";
            this.emprinteNum.UseVisualStyleBackColor = true;
            // 
            // PersoHosp
            // 
            this.PersoHosp.Location = new System.Drawing.Point(332, 107);
            this.PersoHosp.Name = "PersoHosp";
            this.PersoHosp.Size = new System.Drawing.Size(75, 23);
            this.PersoHosp.TabIndex = 2;
            this.PersoHosp.Text = "personnel hospitalier";
            this.PersoHosp.UseVisualStyleBackColor = true;
            // 
            // accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 261);
            this.Controls.Add(this.PersoHosp);
            this.Controls.Add(this.emprinteNum);
            this.Controls.Add(this.patient);
            this.Name = "accueil";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button patient;
        private System.Windows.Forms.Button emprinteNum;
        private System.Windows.Forms.Button PersoHosp;
    }
}

