namespace MailView.IHM
{
    partial class Conversation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversation));
            this.labelBoiteReception = new System.Windows.Forms.Label();
            this.labelListeAmis = new System.Windows.Forms.Label();
            this.labelMessageEnvoyes = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.listBox1 = new MailView.IHM.exListBox();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNomPrenom = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.panelProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBoiteReception
            // 
            this.labelBoiteReception.BackColor = System.Drawing.Color.LightCyan;
            this.labelBoiteReception.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBoiteReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoiteReception.Location = new System.Drawing.Point(7, 164);
            this.labelBoiteReception.Name = "labelBoiteReception";
            this.labelBoiteReception.Size = new System.Drawing.Size(180, 37);
            this.labelBoiteReception.TabIndex = 16;
            this.labelBoiteReception.Text = "Boîte de réception";
            this.labelBoiteReception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBoiteReception.Click += new System.EventHandler(this.labelBoiteReception_Click);
            // 
            // labelListeAmis
            // 
            this.labelListeAmis.BackColor = System.Drawing.Color.LightCyan;
            this.labelListeAmis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelListeAmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeAmis.Location = new System.Drawing.Point(12, 268);
            this.labelListeAmis.Name = "labelListeAmis";
            this.labelListeAmis.Size = new System.Drawing.Size(180, 31);
            this.labelListeAmis.TabIndex = 17;
            this.labelListeAmis.Text = "Liste des amis";
            this.labelListeAmis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessageEnvoyes
            // 
            this.labelMessageEnvoyes.BackColor = System.Drawing.Color.LightCyan;
            this.labelMessageEnvoyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMessageEnvoyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageEnvoyes.Location = new System.Drawing.Point(7, 216);
            this.labelMessageEnvoyes.Name = "labelMessageEnvoyes";
            this.labelMessageEnvoyes.Size = new System.Drawing.Size(180, 37);
            this.labelMessageEnvoyes.TabIndex = 18;
            this.labelMessageEnvoyes.Text = "Messages envoyés";
            this.labelMessageEnvoyes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogo
            // 
            this.labelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Image = ((System.Drawing.Image)(resources.GetObject("labelLogo.Image")));
            this.labelLogo.Location = new System.Drawing.Point(12, 13);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(157, 97);
            this.labelLogo.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.CausesValidation = false;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 66;
            this.listBox1.Location = new System.Drawing.Point(245, 164);
            this.listBox1.MaximumSize = new System.Drawing.Size(700, 400);
            this.listBox1.MinimumSize = new System.Drawing.Size(500, 300);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(700, 400);
            this.listBox1.TabIndex = 0;
            // 
            // panelProfil
            // 
            this.panelProfil.Controls.Add(this.label7);
            this.panelProfil.Controls.Add(this.label5);
            this.panelProfil.Controls.Add(this.labelNomPrenom);
            this.panelProfil.Location = new System.Drawing.Point(690, 13);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(147, 99);
            this.panelProfil.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "aller au profil";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(9, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Déconnexion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNomPrenom
            // 
            this.labelNomPrenom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomPrenom.Location = new System.Drawing.Point(3, 0);
            this.labelNomPrenom.Name = "labelNomPrenom";
            this.labelNomPrenom.Size = new System.Drawing.Size(141, 32);
            this.labelNomPrenom.TabIndex = 16;
            this.labelNomPrenom.Text = "Nom et prenom";
            this.labelNomPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhoto
            // 
            this.labelPhoto.BackColor = System.Drawing.Color.Maroon;
            this.labelPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelPhoto.Location = new System.Drawing.Point(843, 13);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(111, 97);
            this.labelPhoto.TabIndex = 19;
            this.labelPhoto.Text = "Photo";
            // 
            // Conversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.panelProfil);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelMessageEnvoyes);
            this.Controls.Add(this.labelListeAmis);
            this.Controls.Add(this.labelBoiteReception);
            this.Controls.Add(this.labelLogo);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Conversation";
            this.Text = "Conversation";
            this.Load += new System.EventHandler(this.Conversation_Load);
            this.panelProfil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBoiteReception;
        private System.Windows.Forms.Label labelListeAmis;
        private System.Windows.Forms.Label labelMessageEnvoyes;
        private System.Windows.Forms.Label labelLogo;
        private MailView.IHM.exListBox listBox1;
        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNomPrenom;
        private System.Windows.Forms.Label labelPhoto;

    }
}