namespace co2
{
    partial class Form_EntrerBadge
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
            this.labeldata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.b_connexion = new System.Windows.Forms.Button();
            this.t_com = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labeldata
            // 
            this.labeldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldata.Location = new System.Drawing.Point(206, 165);
            this.labeldata.Multiline = true;
            this.labeldata.Name = "labeldata";
            this.labeldata.Size = new System.Drawing.Size(349, 52);
            this.labeldata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro de Badge";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sauvegarder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // b_connexion
            // 
            this.b_connexion.Location = new System.Drawing.Point(565, 33);
            this.b_connexion.Name = "b_connexion";
            this.b_connexion.Size = new System.Drawing.Size(143, 82);
            this.b_connexion.TabIndex = 4;
            this.b_connexion.Text = "Connexion";
            this.b_connexion.UseVisualStyleBackColor = true;
            // 
            // t_com
            // 
            this.t_com.FormattingEnabled = true;
            this.t_com.Location = new System.Drawing.Point(361, 65);
            this.t_com.Name = "t_com";
            this.t_com.Size = new System.Drawing.Size(121, 21);
            this.t_com.TabIndex = 5;
            // 
            // Form_EntrerBadge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 291);
            this.Controls.Add(this.t_com);
            this.Controls.Add(this.b_connexion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeldata);
            this.Name = "Form_EntrerBadge";
            this.Text = "Entrer ou éditer un badge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox labeldata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button b_connexion;
        private System.Windows.Forms.ComboBox t_com;
    }
}