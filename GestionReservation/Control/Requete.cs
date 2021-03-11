using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GestionReservation.Model;


using System.Data.SqlClient;

namespace GestionReservation.Control

{
    
    public class Requete
    {
        private static string ip = "localhost";
        private static string bdd = "EastMaster";
        private static string id = "sa";
        private static string password = "#benjamin0";

        public static SqlConnection Connexion()
        {
            try
            {
                SqlConnection connection1 = new SqlConnection(@"Data Source="+ip+";Initial Catalog="+bdd+";User ID="+id+";Password="+password);
                connection1.Open();
                return connection1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Connexion impossible au serveur");
                throw;
            }
        }
        
        public static List<Compte> ListeDesComptes()
        {
            SqlConnection connection1 = Connexion();

            SqlCommand readerselect = new SqlCommand("VueCompteSalle", connection1);
            SqlDataReader reader = readerselect.ExecuteReader();
           
            List<Compte> liste = new List<Compte>();
            while(reader.Read())
            {
                Compte compte1 = new Compte(Int16.Parse(reader["id"].ToString()), reader["nom"].ToString(),
                    reader["prenom"].ToString(), reader["mail"].ToString(), reader["telephone"].ToString(),
                    reader["adresserue"].ToString(), reader["adresseville"].ToString(), reader["adressecp"].ToString());
                liste.Add(compte1);
            }
            return liste;
        }

        public static void SupprimerCompte(Compte item)
        {
            SqlConnection connection1 = Connexion();
            
            SqlCommand cmd = new SqlCommand("SupprimmerCompteSalle", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@prmId", SqlDbType.Int).Value = item.getId();
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("La requete ne c'est pas bien passé");
            }
        }

        public static void ModifierCompte(Compte item)
        {
            SqlConnection connection1 = Connexion();
            
            SqlCommand cmd = new SqlCommand("ModifierCompteSalle", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@prmId", SqlDbType.Int).Value = item.getId();
            cmd.Parameters.Add("@prmNom", SqlDbType.NVarChar).Value = item.getNom();
            cmd.Parameters.Add("@prmPrenom", SqlDbType.NVarChar).Value = item.getPrenom();
            cmd.Parameters.Add("@prmMail", SqlDbType.NVarChar).Value = item.getMail();
            cmd.Parameters.Add("@prmTelelphone", SqlDbType.NVarChar).Value = item.getTelephone();
            cmd.Parameters.Add("@prmAdresserue", SqlDbType.NVarChar).Value = item.getAdresseRue();
            cmd.Parameters.Add("@prmAdresseVille", SqlDbType.NVarChar).Value = item.getAdresseVille();
            cmd.Parameters.Add("@prmAdresseCp", SqlDbType.NVarChar).Value = item.getAdresseCp();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("La requete ne c'est pas bien passé");
            }
            
        }

        public static void AjouterCompte(Compte item)
        {
            SqlConnection connection1 = Connexion();

            SqlCommand cmd = new SqlCommand("AjoutCompteSalle", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@prmNom", SqlDbType.NVarChar).Value = item.getNom();
            cmd.Parameters.Add("@prmPrenom", SqlDbType.NVarChar).Value = item.getPrenom();
            cmd.Parameters.Add("@prmMail", SqlDbType.NVarChar).Value = item.getMail();
            cmd.Parameters.Add("@prmTelelphone", SqlDbType.NVarChar).Value = item.getTelephone();
            cmd.Parameters.Add("@prmAdresserue", SqlDbType.NVarChar).Value = item.getAdresseRue();
            cmd.Parameters.Add("@prmAdresseVille", SqlDbType.NVarChar).Value = item.getAdresseVille();
            cmd.Parameters.Add("@prmAdressecp", SqlDbType.NVarChar).Value = item.getAdresseCp();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("La requete ne c'est pas bien passé");
            }
        }

        public static List<Reunion> SelectSalleReunion(string prmDate , int nombrePersonne)
        {
            SqlConnection conn = Connexion();

            SqlCommand cmd = new SqlCommand("SelectReservation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prmType", SqlDbType.NVarChar).Value = "reunion";
            cmd.Parameters.Add("@prmDate", SqlDbType.NVarChar).Value = prmDate ;
            cmd.Parameters.Add("@prmNombre", SqlDbType.Int).Value = nombrePersonne ;
            
            SqlDataReader reader = cmd.ExecuteReader();
           
            List<Reunion> liste = new List<Reunion>();
            while(reader.Read())
            {
                Reunion reunion = new Reunion(Int16.Parse(reader["id"].ToString()), 
                    Int16.Parse(reader["nbrpersonne"].ToString()),Int16.Parse(reader["superficie"].ToString()));
                liste.Add(reunion);
            }
            return liste;
        }
        
        public static List<Mariage> SelectSalleMariage(string prmDate , int nombrePersonne)
        {
            SqlConnection conn = Connexion();

            SqlCommand cmd = new SqlCommand("SelectReservation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prmType", SqlDbType.NVarChar).Value = "mariage";
            cmd.Parameters.Add("@prmDate", SqlDbType.NVarChar).Value = prmDate ;
            cmd.Parameters.Add("@prmNombre", SqlDbType.Int).Value = nombrePersonne ;
            
            SqlDataReader reader = cmd.ExecuteReader();
           
            List<Mariage> liste = new List<Mariage>();
            while(reader.Read())
            {
                Mariage mariage = new Mariage(Int16.Parse(reader["id"].ToString()), 
                    Int16.Parse(reader["nbrpersonne"].ToString()),reader["nom"].ToString());
                liste.Add(mariage);
            }
            return liste;
        }

        public static void AjouterReservationMariage(int prmIdSalle , int prmIdCompte , string prmDate , int prmNombre)
        {
            SqlConnection connection1 = Connexion();

            SqlCommand cmd = new SqlCommand("AjoutReservation", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@prmIdSalle", SqlDbType.Int).Value = prmIdSalle;
            cmd.Parameters.Add("@prmIdCompte", SqlDbType.Int).Value = prmIdCompte;
            cmd.Parameters.Add("@prmDate", SqlDbType.NVarChar).Value = prmDate;
            cmd.Parameters.Add("@prmNombre", SqlDbType.Int).Value = prmNombre;
                
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.ToString());
                MessageBox.Show("La requete ne c'est pas bien passé");
            }
        }
        
        public static void AjouterReservationReunion(List<Reunion>liste, int prmIdCompte , string prmDate , int prmNombre)
        {
            SqlConnection connection1 = Connexion();
            foreach (Reunion item in liste)
            {
                SqlCommand cmd = new SqlCommand("AjoutReservation", connection1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@prmIdSalle", SqlDbType.Int).Value = item.getId();
                cmd.Parameters.Add("@prmIdCompte", SqlDbType.Int).Value = prmIdCompte;
                cmd.Parameters.Add("@prmDate", SqlDbType.NVarChar).Value = prmDate;
                cmd.Parameters.Add("@prmNombre", SqlDbType.Int).Value = prmNombre;
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (InvalidCastException e)
                {
                    MessageBox.Show(e.ToString());
                    MessageBox.Show("La requete ne c'est pas bien passé");
                }
            }
            
        }
        
        
        
    }
}