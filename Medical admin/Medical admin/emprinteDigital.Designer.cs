namespace Medical_admin
{
    partial class emprinteDigital
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
            this.patient = new System.Windows.Forms.ComboBox();
            this.ajoutBracelet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patient
            // 
            this.patient.FormattingEnabled = true;
            this.patient.Location = new System.Drawing.Point(73, 57);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(121, 21);
            this.patient.TabIndex = 0;
            // 
            // ajoutBracelet
            // 
            this.ajoutBracelet.Location = new System.Drawing.Point(367, 137);
            this.ajoutBracelet.Name = "ajoutBracelet";
            this.ajoutBracelet.Size = new System.Drawing.Size(114, 23);
            this.ajoutBracelet.TabIndex = 1;
            this.ajoutBracelet.Text = "ajout bracelet";
            this.ajoutBracelet.UseVisualStyleBackColor = true;
            // 
            // emprinteDigital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 261);
            this.Controls.Add(this.ajoutBracelet);
            this.Controls.Add(this.patient);
            this.Name = "emprinteDigital";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.emprinteDigital_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox patient;
        private System.Windows.Forms.Button ajoutBracelet;
    }
}