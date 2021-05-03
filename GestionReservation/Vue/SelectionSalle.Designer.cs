using System.ComponentModel;

namespace GestionReservation.Vue
{
    partial class SelectionSalle
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
            this.radioBtnReunion = new System.Windows.Forms.RadioButton();
            this.radioBtnMariage = new System.Windows.Forms.RadioButton();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelRue = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelCp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombrePersonnes = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.labelSalle = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.listBoxReservation = new System.Windows.Forms.ListBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.btnRaffraichirReservation = new System.Windows.Forms.Button();
            this.btnSupprimerReservation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtnReunion
            // 
            this.radioBtnReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioBtnReunion.Location = new System.Drawing.Point(12, 116);
            this.radioBtnReunion.Name = "radioBtnReunion";
            this.radioBtnReunion.Size = new System.Drawing.Size(171, 30);
            this.radioBtnReunion.TabIndex = 0;
            this.radioBtnReunion.TabStop = true;
            this.radioBtnReunion.Text = "Salle de reunion";
            this.radioBtnReunion.UseVisualStyleBackColor = true;
            this.radioBtnReunion.CheckedChanged += new System.EventHandler(this.radioBtnReunion_CheckedChanged);
            // 
            // radioBtnMariage
            // 
            this.radioBtnMariage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.radioBtnMariage.Location = new System.Drawing.Point(12, 152);
            this.radioBtnMariage.Name = "radioBtnMariage";
            this.radioBtnMariage.Size = new System.Drawing.Size(171, 30);
            this.radioBtnMariage.TabIndex = 1;
            this.radioBtnMariage.TabStop = true;
            this.radioBtnMariage.Text = "Salle de mariage";
            this.radioBtnMariage.UseVisualStyleBackColor = true;
            this.radioBtnMariage.CheckedChanged += new System.EventHandler(this.radioBtnMariage_CheckedChanged);
            // 
            // labelNom
            // 
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNom.Location = new System.Drawing.Point(132, 9);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(126, 26);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "label1";
            // 
            // labelPrenom
            // 
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPrenom.Location = new System.Drawing.Point(132, 35);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(126, 26);
            this.labelPrenom.TabIndex = 3;
            this.labelPrenom.Text = "label2";
            // 
            // labelMail
            // 
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelMail.Location = new System.Drawing.Point(132, 61);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(126, 26);
            this.labelMail.TabIndex = 4;
            this.labelMail.Text = "label3";
            // 
            // labelTelephone
            // 
            this.labelTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelTelephone.Location = new System.Drawing.Point(132, 87);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(126, 26);
            this.labelTelephone.TabIndex = 5;
            this.labelTelephone.Text = "label4";
            // 
            // labelRue
            // 
            this.labelRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelRue.Location = new System.Drawing.Point(264, 35);
            this.labelRue.Name = "labelRue";
            this.labelRue.Size = new System.Drawing.Size(157, 26);
            this.labelRue.TabIndex = 6;
            this.labelRue.Text = "label5";
            // 
            // labelVille
            // 
            this.labelVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelVille.Location = new System.Drawing.Point(264, 61);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(157, 26);
            this.labelVille.TabIndex = 7;
            this.labelVille.Text = "label6";
            // 
            // labelCp
            // 
            this.labelCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelCp.Location = new System.Drawing.Point(264, 87);
            this.labelCp.Name = "labelCp";
            this.labelCp.Size = new System.Drawing.Size(126, 26);
            this.labelCp.TabIndex = 8;
            this.labelCp.Text = "label7";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telephone :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(264, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(15, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre de personnes :";
            // 
            // textBoxNombrePersonnes
            // 
            this.textBoxNombrePersonnes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxNombrePersonnes.Location = new System.Drawing.Point(15, 227);
            this.textBoxNombrePersonnes.Name = "textBoxNombrePersonnes";
            this.textBoxNombrePersonnes.Size = new System.Drawing.Size(183, 29);
            this.textBoxNombrePersonnes.TabIndex = 15;
            this.textBoxNombrePersonnes.Text = "0";
            this.textBoxNombrePersonnes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombrePersonnes_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(15, 302);
            this.dateTimePicker.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(276, 29);
            this.dateTimePicker.TabIndex = 16;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(15, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date :";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(16, 442);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(396, 148);
            this.listBox.TabIndex = 18;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(16, 373);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(181, 27);
            this.btnRecherche.TabIndex = 19;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // labelSalle
            // 
            this.labelSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSalle.Location = new System.Drawing.Point(16, 409);
            this.labelSalle.Name = "labelSalle";
            this.labelSalle.Size = new System.Drawing.Size(152, 30);
            this.labelSalle.TabIndex = 20;
            this.labelSalle.Text = "Salle";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(17, 602);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(184, 31);
            this.btnValider.TabIndex = 21;
            this.btnValider.Text = "Valider la reservation";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // listBoxReservation
            // 
            this.listBoxReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listBoxReservation.FormattingEnabled = true;
            this.listBoxReservation.ItemHeight = 24;
            this.listBoxReservation.Location = new System.Drawing.Point(455, 44);
            this.listBoxReservation.Name = "listBoxReservation";
            this.listBoxReservation.Size = new System.Drawing.Size(377, 148);
            this.listBoxReservation.TabIndex = 22;
            // 
            // labelRes
            // 
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelRes.Location = new System.Drawing.Point(455, 9);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(106, 26);
            this.labelRes.TabIndex = 23;
            this.labelRes.Text = "Reservation :";
            // 
            // btnRaffraichirReservation
            // 
            this.btnRaffraichirReservation.Location = new System.Drawing.Point(456, 206);
            this.btnRaffraichirReservation.Name = "btnRaffraichirReservation";
            this.btnRaffraichirReservation.Size = new System.Drawing.Size(125, 30);
            this.btnRaffraichirReservation.TabIndex = 24;
            this.btnRaffraichirReservation.Text = "Raffraichir";
            this.btnRaffraichirReservation.UseVisualStyleBackColor = true;
            this.btnRaffraichirReservation.Click += new System.EventHandler(this.btnRaffraichirReservation_Click);
            // 
            // btnSupprimerReservation
            // 
            this.btnSupprimerReservation.Location = new System.Drawing.Point(602, 206);
            this.btnSupprimerReservation.Name = "btnSupprimerReservation";
            this.btnSupprimerReservation.Size = new System.Drawing.Size(125, 30);
            this.btnSupprimerReservation.TabIndex = 25;
            this.btnSupprimerReservation.Text = "Supprimer";
            this.btnSupprimerReservation.UseVisualStyleBackColor = true;
            this.btnSupprimerReservation.Click += new System.EventHandler(this.btnSupprimerReservation_Click);
            // 
            // SelectionSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 637);
            this.Controls.Add(this.btnSupprimerReservation);
            this.Controls.Add(this.btnRaffraichirReservation);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.listBoxReservation);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.labelSalle);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxNombrePersonnes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCp);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelRue);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.radioBtnMariage);
            this.Controls.Add(this.radioBtnReunion);
            this.Name = "SelectionSalle";
            this.Text = "SelectionSalle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnRaffraichirReservation;
        private System.Windows.Forms.Button btnSupprimerReservation;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.ListBox listBoxReservation;

        private System.Windows.Forms.Button btnValider;

        private System.Windows.Forms.Label labelSalle;

        private System.Windows.Forms.Button btnRecherche;

        private System.Windows.Forms.ListBox listBox;


        private System.Windows.Forms.Label label7;

        
        private System.Windows.Forms.DateTimePicker dateTimePicker;

        private System.Windows.Forms.TextBox textBoxNombrePersonnes;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label labelCp;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelRue;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelVille;

        private System.Windows.Forms.RadioButton radioBtnReunion;
        private System.Windows.Forms.RadioButton radioBtnMariage;

        #endregion
    }
}