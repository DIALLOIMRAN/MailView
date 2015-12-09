namespace MailView.IHM
{
    partial class Inscription
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
            this.components = new System.ComponentModel.Container();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textPwdConfirm = new System.Windows.Forms.TextBox();
            this.labelPasswordErreur = new System.Windows.Forms.Label();
            this.labelPasswordConfirmErreur = new System.Windows.Forms.Label();
            this.labelAdresseErreur = new System.Windows.Forms.Label();
            this.labelPasswordConfirm = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelPrenomErreur = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNomErreur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.ForeColor = System.Drawing.Color.Blue;
            this.buttonAnnuler.Location = new System.Drawing.Point(190, 247);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(128, 43);
            this.buttonAnnuler.TabIndex = 8;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmer.ForeColor = System.Drawing.Color.Blue;
            this.buttonConfirmer.Location = new System.Drawing.Point(384, 247);
            this.buttonConfirmer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(133, 43);
            this.buttonConfirmer.TabIndex = 7;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(3, 21);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 17);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom :";
            // 
            // textNom
            // 
            this.textNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNom.Location = new System.Drawing.Point(190, 21);
            this.textNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(328, 23);
            this.textNom.TabIndex = 1;
            this.textNom.Leave += new System.EventHandler(this.textNom_Leave);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(189, 174);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(328, 23);
            this.textPassword.TabIndex = 5;
            this.textPassword.Leave += new System.EventHandler(this.textPassword_Leave);
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textEmail.Location = new System.Drawing.Point(190, 103);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(328, 23);
            this.textEmail.TabIndex = 3;
            this.textEmail.Text = "votreTexte@mailview.ma";
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textPrenom
            // 
            this.textPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrenom.Location = new System.Drawing.Point(190, 60);
            this.textPrenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(328, 23);
            this.textPrenom.TabIndex = 2;
            this.textPrenom.Leave += new System.EventHandler(this.textPrenom_Leave);
            // 
            // textPwdConfirm
            // 
            this.textPwdConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPwdConfirm.Location = new System.Drawing.Point(190, 212);
            this.textPwdConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPwdConfirm.Name = "textPwdConfirm";
            this.textPwdConfirm.PasswordChar = '*';
            this.textPwdConfirm.Size = new System.Drawing.Size(328, 23);
            this.textPwdConfirm.TabIndex = 6;
            this.textPwdConfirm.Leave += new System.EventHandler(this.textPwdConfirm_Leave);
            // 
            // labelPasswordErreur
            // 
            this.labelPasswordErreur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordErreur.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordErreur.Location = new System.Drawing.Point(519, 212);
            this.labelPasswordErreur.Name = "labelPasswordErreur";
            this.labelPasswordErreur.Size = new System.Drawing.Size(23, 23);
            this.labelPasswordErreur.TabIndex = 14;
            // 
            // labelPasswordConfirmErreur
            // 
            this.labelPasswordConfirmErreur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirmErreur.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordConfirmErreur.Location = new System.Drawing.Point(519, 173);
            this.labelPasswordConfirmErreur.Name = "labelPasswordConfirmErreur";
            this.labelPasswordConfirmErreur.Size = new System.Drawing.Size(23, 24);
            this.labelPasswordConfirmErreur.TabIndex = 15;
            // 
            // labelAdresseErreur
            // 
            this.labelAdresseErreur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresseErreur.ForeColor = System.Drawing.Color.Red;
            this.labelAdresseErreur.Location = new System.Drawing.Point(519, 103);
            this.labelAdresseErreur.Name = "labelAdresseErreur";
            this.labelAdresseErreur.Size = new System.Drawing.Size(23, 20);
            this.labelAdresseErreur.TabIndex = 16;
            // 
            // labelPasswordConfirm
            // 
            this.labelPasswordConfirm.AutoSize = true;
            this.labelPasswordConfirm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirm.Location = new System.Drawing.Point(3, 218);
            this.labelPasswordConfirm.Name = "labelPasswordConfirm";
            this.labelPasswordConfirm.Size = new System.Drawing.Size(172, 17);
            this.labelPasswordConfirm.TabIndex = 12;
            this.labelPasswordConfirm.Text = "Confirmer le mot de passe  :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(3, 110);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(141, 17);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Adresse éléctronique :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(3, 184);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 17);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Mot de passe :";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(3, 67);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(59, 17);
            this.labelPrenom.TabIndex = 8;
            this.labelPrenom.Text = "Prénom :";
            // 
            // labelPrenomErreur
            // 
            this.labelPrenomErreur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenomErreur.ForeColor = System.Drawing.Color.Red;
            this.labelPrenomErreur.Location = new System.Drawing.Point(519, 59);
            this.labelPrenomErreur.Name = "labelPrenomErreur";
            this.labelPrenomErreur.Size = new System.Drawing.Size(23, 24);
            this.labelPrenomErreur.TabIndex = 18;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // labelNomErreur
            // 
            this.labelNomErreur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomErreur.ForeColor = System.Drawing.Color.Red;
            this.labelNomErreur.Location = new System.Drawing.Point(519, 21);
            this.labelNomErreur.Name = "labelNomErreur";
            this.labelNomErreur.Size = new System.Drawing.Size(23, 23);
            this.labelNomErreur.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "N° de téléphone";
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textPhone.Location = new System.Drawing.Point(190, 134);
            this.textPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(328, 23);
            this.textPhone.TabIndex = 4;
            this.textPhone.Text = "xx-xx-xx-xx-xx";
            this.textPhone.Enter += new System.EventHandler(this.textPhone_Enter);
            this.textPhone.Leave += new System.EventHandler(this.textPhone_Leave);
            // 
            // labelPhone
            // 
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.Transparent;
            this.labelPhone.Location = new System.Drawing.Point(519, 137);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(23, 20);
            this.labelPhone.TabIndex = 23;
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 317);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNomErreur);
            this.Controls.Add(this.labelPrenomErreur);
            this.Controls.Add(this.labelAdresseErreur);
            this.Controls.Add(this.labelPasswordConfirmErreur);
            this.Controls.Add(this.labelPasswordErreur);
            this.Controls.Add(this.labelPasswordConfirm);
            this.Controls.Add(this.textPwdConfirm);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonConfirmer);
            this.Controls.Add(this.buttonAnnuler);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(581, 577);
            this.Name = "Inscription";
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textPwdConfirm;
        private System.Windows.Forms.Label labelPasswordErreur;
        private System.Windows.Forms.Label labelPasswordConfirmErreur;
        private System.Windows.Forms.Label labelAdresseErreur;
        private System.Windows.Forms.Label labelPasswordConfirm;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelPrenomErreur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label labelNomErreur;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPhone;
    }
}