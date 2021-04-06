using System.ComponentModel;

namespace GestionReservation.Vue
{
    partial class ViewCompte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ListCompte = new System.Windows.Forms.ListBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelAdresseVille = new System.Windows.Forms.Label();
            this.textBoxAdresseVille = new System.Windows.Forms.TextBox();
            this.labelAdresseRue = new System.Windows.Forms.Label();
            this.textBoxAdresseRue = new System.Windows.Forms.TextBox();
            this.labelAdresseCp = new System.Windows.Forms.Label();
            this.textBoxAdresseCp = new System.Windows.Forms.TextBox();
            this.btnNouveauCompte = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListCompte
            // 
            this.ListCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ListCompte.FormattingEnabled = true;
            this.ListCompte.ItemHeight = 25;
            this.ListCompte.Location = new System.Drawing.Point(32, 42);
            this.ListCompte.Name = "ListCompte";
            this.ListCompte.Size = new System.Drawing.Size(219, 579);
            this.ListCompte.TabIndex = 0;
            this.ListCompte.SelectedIndexChanged += new System.EventHandler(this.ListCompte_SelectedIndexChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(323, 139);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(153, 20);
            this.textBoxNom.TabIndex = 2;
            // 
            // labelNom
            // 
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNom.Location = new System.Drawing.Point(323, 110);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(152, 18);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPrenom.Location = new System.Drawing.Point(322, 194);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(152, 18);
            this.labelPrenom.TabIndex = 5;
            this.labelPrenom.Text = "Prenom";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(322, 223);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(153, 20);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // labelTelephone
            // 
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelTelephone.Location = new System.Drawing.Point(323, 359);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(152, 18);
            this.labelTelephone.TabIndex = 9;
            this.labelTelephone.Text = "telephone";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(323, 388);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(153, 20);
            this.textBoxTelephone.TabIndex = 8;
            // 
            // labelMail
            // 
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelMail.Location = new System.Drawing.Point(324, 275);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(152, 18);
            this.labelMail.TabIndex = 7;
            this.labelMail.Text = "Mail";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(324, 304);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(153, 20);
            this.textBoxMail.TabIndex = 6;
            // 
            // labelAdresseVille
            // 
            this.labelAdresseVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelAdresseVille.Location = new System.Drawing.Point(576, 194);
            this.labelAdresseVille.Name = "labelAdresseVille";
            this.labelAdresseVille.Size = new System.Drawing.Size(152, 18);
            this.labelAdresseVille.TabIndex = 13;
            this.labelAdresseVille.Text = "Ville";
            // 
            // textBoxAdresseVille
            // 
            this.textBoxAdresseVille.Location = new System.Drawing.Point(576, 223);
            this.textBoxAdresseVille.Name = "textBoxAdresseVille";
            this.textBoxAdresseVille.Size = new System.Drawing.Size(153, 20);
            this.textBoxAdresseVille.TabIndex = 12;
            // 
            // labelAdresseRue
            // 
            this.labelAdresseRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelAdresseRue.Location = new System.Drawing.Point(577, 110);
            this.labelAdresseRue.Name = "labelAdresseRue";
            this.labelAdresseRue.Size = new System.Drawing.Size(152, 18);
            this.labelAdresseRue.TabIndex = 11;
            this.labelAdresseRue.Text = "Adresse rue";
            // 
            // textBoxAdresseRue
            // 
            this.textBoxAdresseRue.Location = new System.Drawing.Point(577, 139);
            this.textBoxAdresseRue.Name = "textBoxAdresseRue";
            this.textBoxAdresseRue.Size = new System.Drawing.Size(153, 20);
            this.textBoxAdresseRue.TabIndex = 10;
            // 
            // labelAdresseCp
            // 
            this.labelAdresseCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelAdresseCp.Location = new System.Drawing.Point(578, 275);
            this.labelAdresseCp.Name = "labelAdresseCp";
            this.labelAdresseCp.Size = new System.Drawing.Size(152, 18);
            this.labelAdresseCp.TabIndex = 15;
            this.labelAdresseCp.Text = "Code postal";
            // 
            // textBoxAdresseCp
            // 
            this.textBoxAdresseCp.Location = new System.Drawing.Point(578, 304);
            this.textBoxAdresseCp.Name = "textBoxAdresseCp";
            this.textBoxAdresseCp.Size = new System.Drawing.Size(153, 20);
            this.textBoxAdresseCp.TabIndex = 14;
            // 
            // btnNouveauCompte
            // 
            this.btnNouveauCompte.AccessibleDescription = "";
            this.btnNouveauCompte.Location = new System.Drawing.Point(322, 42);
            this.btnNouveauCompte.Name = "btnNouveauCompte";
            this.btnNouveauCompte.Size = new System.Drawing.Size(197, 23);
            this.btnNouveauCompte.TabIndex = 0;
            this.btnNouveauCompte.Text = "Nouveau Compte";
            this.btnNouveauCompte.Click += new System.EventHandler(this.btnNouveauCompte_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(323, 461);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(301, 63);
            this.btnCreer.TabIndex = 16;
            this.btnCreer.Text = "Creer un compte";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(323, 461);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(134, 63);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Visible = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(490, 461);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(134, 63);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Visible = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(661, 463);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(126, 60);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ViewCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 640);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnNouveauCompte);
            this.Controls.Add(this.labelAdresseCp);
            this.Controls.Add(this.textBoxAdresseCp);
            this.Controls.Add(this.labelAdresseVille);
            this.Controls.Add(this.textBoxAdresseVille);
            this.Controls.Add(this.labelAdresseRue);
            this.Controls.Add(this.textBoxAdresseRue);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.ListCompte);
            this.Name = "ViewCompte";
            this.Text = "Compte";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSelect;

        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;

        private System.Windows.Forms.Button btnNouveauCompte;

        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelAdresseVille;
        private System.Windows.Forms.Label labelAdresseRue;
        private System.Windows.Forms.Label labelAdresseCp;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxAdresseVille;
        private System.Windows.Forms.TextBox textBoxAdresseRue;
        private System.Windows.Forms.TextBox textBoxAdresseCp;

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxNom;

        private System.Windows.Forms.ListBox ListCompte;

        #endregion
    }
}