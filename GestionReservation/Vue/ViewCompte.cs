using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionReservation.Control;
using GestionReservation.Model;

namespace GestionReservation.Vue
{
    public partial class ViewCompte : Form
    {
        private static Compte _itemGl;
        public ViewCompte()
        {
            InitializeComponent();
            
            RaffraichirListe();
        }

        private void ListCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListCompte.SelectedItem != null)
            {
                Compte item = (Compte) ListCompte.SelectedItem;
                _itemGl = item;
                textBoxNom.Text = item.getNom();
                textBoxPrenom.Text = item.getPrenom();
                textBoxMail.Text = item.getMail();
                textBoxTelephone.Text = item.getTelephone();
                textBoxAdresseRue.Text = item.getAdresseRue();
                textBoxAdresseVille.Text = item.getAdresseVille();
                textBoxAdresseCp.Text = item.getAdresseCp();
                btnCreer.Visible = false;
                btnModifier.Visible = true;
                btnSupprimer.Visible = true;
            }
            else
            {
                MessageBox.Show("Aucun élément selection");
            }
        }
        

        private void RaffraichirListe()
        {
            List<Compte> listecompte = new List<Compte>();
            listecompte = Requete.ListeDesComptes();
            
            ListCompte.DataSource = listecompte;
            ListCompte.DisplayMember = "";
            btnCreer.Visible = false;
            btnModifier.Visible = true;
            btnSupprimer.Visible = true;
        }


        private void btnNouveauCompte_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = null;
            textBoxPrenom.Text = null;
            textBoxMail.Text = null;
            textBoxTelephone.Text = null;
            textBoxAdresseRue.Text = null;
            textBoxAdresseVille.Text = null;
            textBoxAdresseCp.Text = null;
            
            btnModifier.Visible = false;
            btnSupprimer.Visible = false;
            btnCreer.Visible = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = _itemGl.getId();
            
            Compte item = new Compte(id, textBoxNom.Text, textBoxPrenom.Text, textBoxMail.Text
                ,textBoxTelephone.Text, textBoxAdresseRue.Text, textBoxAdresseVille.Text, textBoxAdresseCp.Text);
            DialogResult dialogResult = MessageBox.Show("Voulez-vous Modifier ce compte ? "+_itemGl.getNom() + " " 
                                                        + _itemGl.getPrenom(),"Validation Modification", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Requete.ModifierCompte(item);
            }
            RaffraichirListe();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous Supprimer ce compte ? "+_itemGl.getNom() + " "
                                                        + _itemGl.getPrenom(),"Validation Suppresion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Requete.SupprimerCompte(_itemGl);
            }
            RaffraichirListe();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxPrenom.Text != "")
            {
                Compte item = new Compte(999, textBoxNom.Text, textBoxPrenom.Text, textBoxMail.Text
                    , textBoxTelephone.Text, textBoxAdresseRue.Text, textBoxAdresseVille.Text, textBoxAdresseCp.Text);
                DialogResult dialogResult = MessageBox.Show("Voulez-vous Ajouter ce compte ? " + textBoxNom.Text + " "
                                                            + textBoxPrenom.Text, "Validation ajout",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Requete.AjouterCompte(item);
                }

                RaffraichirListe();
            }
            else
            {
                MessageBox.Show("Il faut au minimum le nom et le prénom");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Compte item = (Compte) ListCompte.SelectedItem;
            SelectionSalle form2 = new SelectionSalle(item);
            form2.ShowDialog();
        }

        
    }
}