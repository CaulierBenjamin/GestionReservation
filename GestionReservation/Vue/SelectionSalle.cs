using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GestionReservation.Control;
using GestionReservation.Model;

namespace GestionReservation.Vue
{
    public partial class SelectionSalle : Form
    {
        private Compte _compte;
        public SelectionSalle(Compte item)
        {
            InitializeComponent();
            _compte = item;
            
            labelNom.Text = item.getNom();
            labelPrenom.Text = item.getPrenom();
            labelMail.Text = item.getMail();
            labelTelephone.Text = item.getTelephone();
            labelRue.Text = item.getAdresseRue();
            labelVille.Text = item.getAdresseVille();
            labelCp.Text = item.getAdresseCp();
        }


        private void textBoxNombrePersonnes_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        
        private void Raffraichir()
        {
            
            int nombrePersonne = int.Parse(textBoxNombrePersonnes.Text);
            string date = dateTimePicker.Text;
            
            if (int.Parse(textBoxNombrePersonnes.Text) > 0)
            {
                if (radioBtnReunion.Checked)
                {
                    List<Reunion> liste = new List<Reunion>();
                    liste = Requete.SelectSalleReunion(date , 1);
                
                    listBox.DataSource = liste;
                    listBox.DisplayMember = "";
                    listBox.SelectionMode = SelectionMode.MultiSimple;
                    labelSalle.Text = "Salle Reunion";
                } 
                if (radioBtnMariage.Checked)
                {
                    List<Mariage> liste = new List<Mariage>();
                    liste = Requete.SelectSalleMariage(date , nombrePersonne);
            
                    listBox.DataSource = liste;
                    listBox.DisplayMember = "";
                    listBox.SelectionMode = SelectionMode.One;
                    labelSalle.Text = "Salle Mariage";
                }

                try
                {
                    listBox.SetSelected(0,false);
                }
                catch
                {
                    MessageBox.Show("il n'y a pas de salle pour ces condition");
                }

                
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
            if (radioBtnMariage.Checked && int.Parse(textBoxNombrePersonnes.Text) > 0)
            {
                DialogResult dialogResult = MessageBox.Show("test", "test", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string date = dateTimePicker.Text;
                    Mariage mariage = (Mariage) listBox.SelectedItem;
                    Requete.AjouterReservationMariage(mariage.getId(), _compte.getId(), date,
                        int.Parse(textBoxNombrePersonnes.Text));
                    Raffraichir();
                }
            }

            if (radioBtnReunion.Checked && int.Parse(textBoxNombrePersonnes.Text) > 0)
            {
                string date = dateTimePicker.Text;
                List<Reunion> liste = new List<Reunion>();
                int nombrePersonne = 0;
                foreach (Reunion item in listBox.SelectedItems)
                {
                    nombrePersonne += item.getNbrPersonne();
                    liste.Add(item);
                }

                MessageBox.Show(nombrePersonne.ToString());
                if (nombrePersonne >= int.Parse(textBoxNombrePersonnes.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("test", "test", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    
                        Requete.AjouterReservationReunion(liste , _compte.getId(),date,int.Parse(textBoxNombrePersonnes.Text));
                        Raffraichir();
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y pas assez de place pour le nombre de personne demander");
                }
                
            }
            
        }

        private  void btnRecherche_Click(object sender, EventArgs e)
        {
            Raffraichir();
        }
        
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Raffraichir();
        }
        
        private void radioBtnReunion_CheckedChanged(object sender, EventArgs e)
        {
            Raffraichir();
        }

        private void radioBtnMariage_CheckedChanged(object sender, EventArgs e)
        {
            Raffraichir();
        }
    }
}