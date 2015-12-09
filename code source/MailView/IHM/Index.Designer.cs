namespace MailView.IHM
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelBeneficiez = new System.Windows.Forms.Label();
            this.labelBienvenue = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.labelInscription = new System.Windows.Forms.Label();
            this.labelPasswordOublie = new System.Windows.Forms.Label();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textAdresseEmail = new System.Windows.Forms.TextBox();
            this.labelAdresseEmail = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Image = global::MailView.Properties.Resources.logo;
            this.labelLogo.Location = new System.Drawing.Point(33, 4);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(200, 122);
            this.labelLogo.TabIndex = 0;
            // 
            // labelBeneficiez
            // 
            this.labelBeneficiez.BackColor = System.Drawing.Color.Transparent;
            this.labelBeneficiez.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeneficiez.Location = new System.Drawing.Point(533, 67);
            this.labelBeneficiez.Name = "labelBeneficiez";
            this.labelBeneficiez.Size = new System.Drawing.Size(416, 23);
            this.labelBeneficiez.TabIndex = 1;
            this.labelBeneficiez.Text = "Bénéficiez de la simplicité de communication";
            // 
            // labelBienvenue
            // 
            this.labelBienvenue.BackColor = System.Drawing.Color.Transparent;
            this.labelBienvenue.Font = new System.Drawing.Font("Century Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenue.ForeColor = System.Drawing.Color.Blue;
            this.labelBienvenue.Location = new System.Drawing.Point(603, 27);
            this.labelBienvenue.Name = "labelBienvenue";
            this.labelBienvenue.Size = new System.Drawing.Size(257, 30);
            this.labelBienvenue.TabIndex = 2;
            this.labelBienvenue.Text = "Bienvenue sur MailView";
            // 
            // labelImage
            // 
            this.labelImage.BackColor = System.Drawing.Color.Transparent;
            this.labelImage.Image = ((System.Drawing.Image)(resources.GetObject("labelImage.Image")));
            this.labelImage.Location = new System.Drawing.Point(12, 126);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(515, 316);
            this.labelImage.TabIndex = 3;
            // 
            // panelConnexion
            // 
            this.panelConnexion.BackColor = System.Drawing.Color.LightBlue;
            this.panelConnexion.Controls.Add(this.labelInscription);
            this.panelConnexion.Controls.Add(this.labelPasswordOublie);
            this.panelConnexion.Controls.Add(this.labelConnexion);
            this.panelConnexion.Controls.Add(this.labelPassword);
            this.panelConnexion.Controls.Add(this.textPassword);
            this.panelConnexion.Controls.Add(this.textAdresseEmail);
            this.panelConnexion.Controls.Add(this.labelAdresseEmail);
            this.panelConnexion.Location = new System.Drawing.Point(607, 148);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(342, 266);
            this.panelConnexion.TabIndex = 4;
            // 
            // labelInscription
            // 
            this.labelInscription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInscription.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelInscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelInscription.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscription.ForeColor = System.Drawing.Color.Blue;
            this.labelInscription.Location = new System.Drawing.Point(106, 212);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(117, 27);
            this.labelInscription.TabIndex = 5;
            this.labelInscription.Text = "Inscription";
            this.labelInscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInscription.Click += new System.EventHandler(this.labelInscription_Click);
            // 
            // labelPasswordOublie
            // 
            this.labelPasswordOublie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPasswordOublie.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordOublie.ForeColor = System.Drawing.Color.Blue;
            this.labelPasswordOublie.Location = new System.Drawing.Point(43, 165);
            this.labelPasswordOublie.Name = "labelPasswordOublie";
            this.labelPasswordOublie.Size = new System.Drawing.Size(158, 29);
            this.labelPasswordOublie.TabIndex = 4;
            this.labelPasswordOublie.Text = "Mot de passe oublié";
            this.labelPasswordOublie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPasswordOublie.Click += new System.EventHandler(this.labelPasswordOublie_Click);
            this.labelPasswordOublie.MouseEnter += new System.EventHandler(this.labelPasswordOublie_MouseEnter);
            this.labelPasswordOublie.MouseLeave += new System.EventHandler(this.labelPasswordOublie_MouseLeave);
            // 
            // labelConnexion
            // 
            this.labelConnexion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelConnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelConnexion.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.ForeColor = System.Drawing.Color.Black;
            this.labelConnexion.Location = new System.Drawing.Point(212, 165);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(103, 29);
            this.labelConnexion.TabIndex = 3;
            this.labelConnexion.Text = "Connexion";
            this.labelConnexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConnexion.Click += new System.EventHandler(this.labelConnexion_Click);
            this.labelConnexion.MouseEnter += new System.EventHandler(this.labelConnexion_MouseEnter);
            this.labelConnexion.MouseLeave += new System.EventHandler(this.labelConnexion_MouseLeave);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(50, 83);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 21);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Mot de passe";
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(47, 107);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(268, 28);
            this.textPassword.TabIndex = 2;
            // 
            // textAdresseEmail
            // 
            this.textAdresseEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdresseEmail.Location = new System.Drawing.Point(47, 38);
            this.textAdresseEmail.Multiline = true;
            this.textAdresseEmail.Name = "textAdresseEmail";
            this.textAdresseEmail.Size = new System.Drawing.Size(268, 28);
            this.textAdresseEmail.TabIndex = 1;
            this.textAdresseEmail.MouseLeave += new System.EventHandler(this.textAdresseEmail_MouseLeave);
            // 
            // labelAdresseEmail
            // 
            this.labelAdresseEmail.AutoSize = true;
            this.labelAdresseEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresseEmail.Location = new System.Drawing.Point(43, 14);
            this.labelAdresseEmail.Name = "labelAdresseEmail";
            this.labelAdresseEmail.Size = new System.Drawing.Size(122, 21);
            this.labelAdresseEmail.TabIndex = 1;
            this.labelAdresseEmail.Text = "Adresse e-mail";
            // 
            // labelErreur
            // 
            this.labelErreur.BackColor = System.Drawing.Color.Transparent;
            this.labelErreur.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(509, 124);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(440, 21);
            this.labelErreur.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(317, 637);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(399, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Application C# réalisé par : DIALLO IMRANA et BOUDCHARD NAWAL";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panelConnexion);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.labelBienvenue);
            this.Controls.Add(this.labelBeneficiez);
            this.Controls.Add(this.labelLogo);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Index";
            this.Text = "MailView sur MailView";
            this.panelConnexion.ResumeLayout(false);
            this.panelConnexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelBeneficiez;
        private System.Windows.Forms.Label labelBienvenue;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textAdresseEmail;
        private System.Windows.Forms.Label labelAdresseEmail;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Label labelInscription;
        private System.Windows.Forms.Label labelPasswordOublie;
        private System.Windows.Forms.Label label13;

    }
}