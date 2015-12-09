namespace MailView.IHM
{
    partial class PasswordOublie
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
            this.labelPhrase = new System.Windows.Forms.Label();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.buttonVerifier = new System.Windows.Forms.Button();
            this.labelErreur = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelErreur1 = new System.Windows.Forms.Label();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNvPwd = new System.Windows.Forms.TextBox();
            this.buttonMaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPhrase
            // 
            this.labelPhrase.AutoSize = true;
            this.labelPhrase.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhrase.Location = new System.Drawing.Point(57, 27);
            this.labelPhrase.Name = "labelPhrase";
            this.labelPhrase.Size = new System.Drawing.Size(259, 20);
            this.labelPhrase.TabIndex = 0;
            this.labelPhrase.Text = "Entrez votre adresse  éléctronique";
            // 
            // textAdresse
            // 
            this.textAdresse.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAdresse.Location = new System.Drawing.Point(61, 50);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(329, 25);
            this.textAdresse.TabIndex = 1;
            this.textAdresse.Leave += new System.EventHandler(this.textAdresse_Leave);
            // 
            // buttonVerifier
            // 
            this.buttonVerifier.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerifier.Location = new System.Drawing.Point(274, 152);
            this.buttonVerifier.Name = "buttonVerifier";
            this.buttonVerifier.Size = new System.Drawing.Size(116, 33);
            this.buttonVerifier.TabIndex = 2;
            this.buttonVerifier.Text = "Verifier";
            this.buttonVerifier.UseVisualStyleBackColor = true;
            this.buttonVerifier.Click += new System.EventHandler(this.buttonVerifier_Click);
            // 
            // labelErreur
            // 
            this.labelErreur.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreur.ForeColor = System.Drawing.Color.Maroon;
            this.labelErreur.Location = new System.Drawing.Point(12, 188);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(415, 25);
            this.labelErreur.TabIndex = 3;
            this.labelErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(61, 111);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(329, 25);
            this.textPhone.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelErreur);
            this.panel1.Controls.Add(this.textPhone);
            this.panel1.Controls.Add(this.labelPhrase);
            this.panel1.Controls.Add(this.textAdresse);
            this.panel1.Controls.Add(this.buttonVerifier);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 218);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Retaper le mot de passe";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelErreur1);
            this.panel2.Controls.Add(this.textPwd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textNvPwd);
            this.panel2.Controls.Add(this.buttonMaj);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 213);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Retaper le mot de passe";
            // 
            // labelErreur1
            // 
            this.labelErreur1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreur1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelErreur1.Location = new System.Drawing.Point(6, 173);
            this.labelErreur1.Name = "labelErreur1";
            this.labelErreur1.Size = new System.Drawing.Size(391, 25);
            this.labelErreur1.TabIndex = 3;
            this.labelErreur1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPwd
            // 
            this.textPwd.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPwd.Location = new System.Drawing.Point(55, 50);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(326, 25);
            this.textPwd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Entrer un nouveau mot de passe";
            // 
            // textNvPwd
            // 
            this.textNvPwd.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNvPwd.Location = new System.Drawing.Point(55, 111);
            this.textNvPwd.Name = "textNvPwd";
            this.textNvPwd.Size = new System.Drawing.Size(326, 25);
            this.textNvPwd.TabIndex = 1;
            // 
            // buttonMaj
            // 
            this.buttonMaj.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaj.Location = new System.Drawing.Point(265, 149);
            this.buttonMaj.Name = "buttonMaj";
            this.buttonMaj.Size = new System.Drawing.Size(116, 28);
            this.buttonMaj.TabIndex = 2;
            this.buttonMaj.Text = "Mettre à jour";
            this.buttonMaj.UseVisualStyleBackColor = true;
            this.buttonMaj.Click += new System.EventHandler(this.buttonMaj_Click);
            // 
            // PasswordOublie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 219);
            this.Controls.Add(this.panel1);
            this.Name = "PasswordOublie";
            this.Text = "PasswordOublie";
            this.Load += new System.EventHandler(this.PasswordOublie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPhrase;
        private System.Windows.Forms.TextBox textAdresse;
        private System.Windows.Forms.Button buttonVerifier;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelErreur1;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNvPwd;
        private System.Windows.Forms.Button buttonMaj;
        private System.Windows.Forms.Label label1;
    }
}