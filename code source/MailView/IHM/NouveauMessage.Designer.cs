namespace MailView
{
    partial class NouveauMessage
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
            this.labelErreur = new System.Windows.Forms.Label();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.textObjet = new System.Windows.Forms.TextBox();
            this.textContenu = new System.Windows.Forms.TextBox();
            this.labelObjet = new System.Windows.Forms.Label();
            this.labelTexte = new System.Windows.Forms.Label();
            this.labelEnvoyer = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErreur
            // 
            this.labelErreur.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreur.Location = new System.Drawing.Point(68, 9);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(515, 25);
            this.labelErreur.TabIndex = 16;
            this.labelErreur.Click += new System.EventHandler(this.labelErreur_Click);
            // 
            // textAdresse
            // 
            this.textAdresse.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdresse.Location = new System.Drawing.Point(68, 47);
            this.textAdresse.Multiline = true;
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(515, 30);
            this.textAdresse.TabIndex = 9;
            this.textAdresse.Leave += new System.EventHandler(this.textAdresse_Leave);
            // 
            // textObjet
            // 
            this.textObjet.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textObjet.Location = new System.Drawing.Point(68, 97);
            this.textObjet.Multiline = true;
            this.textObjet.Name = "textObjet";
            this.textObjet.Size = new System.Drawing.Size(515, 28);
            this.textObjet.TabIndex = 10;
            this.textObjet.Leave += new System.EventHandler(this.textObjet_Leave);
            // 
            // textContenu
            // 
            this.textContenu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContenu.Location = new System.Drawing.Point(68, 140);
            this.textContenu.Multiline = true;
            this.textContenu.Name = "textContenu";
            this.textContenu.Size = new System.Drawing.Size(515, 178);
            this.textContenu.TabIndex = 11;
            this.textContenu.Leave += new System.EventHandler(this.textContenu_Leave);
            // 
            // labelObjet
            // 
            this.labelObjet.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjet.Location = new System.Drawing.Point(-1, 97);
            this.labelObjet.Name = "labelObjet";
            this.labelObjet.Size = new System.Drawing.Size(63, 28);
            this.labelObjet.TabIndex = 13;
            this.labelObjet.Text = "Objet : ";
            // 
            // labelTexte
            // 
            this.labelTexte.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexte.Location = new System.Drawing.Point(7, 140);
            this.labelTexte.Name = "labelTexte";
            this.labelTexte.Size = new System.Drawing.Size(59, 28);
            this.labelTexte.TabIndex = 14;
            this.labelTexte.Text = "Texte : ";
            // 
            // labelEnvoyer
            // 
            this.labelEnvoyer.BackColor = System.Drawing.Color.AliceBlue;
            this.labelEnvoyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEnvoyer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnvoyer.ForeColor = System.Drawing.Color.Blue;
            this.labelEnvoyer.Location = new System.Drawing.Point(258, 334);
            this.labelEnvoyer.Name = "labelEnvoyer";
            this.labelEnvoyer.Size = new System.Drawing.Size(88, 28);
            this.labelEnvoyer.TabIndex = 15;
            this.labelEnvoyer.Text = "Envoyer";
            this.labelEnvoyer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEnvoyer.Click += new System.EventHandler(this.labelEnvoyer_Click);
            // 
            // labelA
            // 
            this.labelA.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(32, 49);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(30, 28);
            this.labelA.TabIndex = 12;
            this.labelA.Text = "À : ";
            // 
            // NouveauMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 376);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.textAdresse);
            this.Controls.Add(this.textObjet);
            this.Controls.Add(this.textContenu);
            this.Controls.Add(this.labelObjet);
            this.Controls.Add(this.labelTexte);
            this.Controls.Add(this.labelEnvoyer);
            this.Controls.Add(this.labelA);
            this.Name = "NouveauMessage";
            this.Text = "NouveauMessage";
            this.Load += new System.EventHandler(this.NouveauMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.TextBox textObjet;
        private System.Windows.Forms.TextBox textContenu;
        private System.Windows.Forms.Label labelObjet;
        private System.Windows.Forms.Label labelTexte;
        private System.Windows.Forms.Label labelEnvoyer;
        private System.Windows.Forms.Label labelA;
    }
}