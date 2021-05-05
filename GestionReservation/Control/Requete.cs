using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GestionReservation.Model;


using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace GestionReservation.Control

{
    
    public class Requete
    {
        private static string ip = "192.168.1.15";
        private static string bdd = "eastmaster";
        private static string id = "reservation";
        private static string password = "reser2";

        public static MySqlConnection Connexion()
        {
            try
            {
                MySqlConnection connection1 = new MySqlConnection($"SERVER={ip}; DATABASE={bdd}; UID={id}; PASSWORD={password}");
                connection1.Open();
                return connection1;
            }
            catch ( Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Connexion impossible au serveur" + e.ToString());
                throw;
            }
        }
        /// <summary>
        /// Sort une liste contenant les Compte
        /// </summary>
        /// <returns></returns>
        public static List<Compte> ListeDesComptes()
        {
            try
            {
                MySqlConnection connection1 = Connexion();

                MySqlCommand readerselect = new MySqlCommand("SelectCompteSalle", connection1);
                MySqlDataReader reader = readerselect.ExecuteReader();
           
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public static void SupprimerCompte(Compte item)
        {
            MySqlConnection connection1 = Connexion();
            
            MySqlCommand cmd = new MySqlCommand("SupprimmerCompteSalle", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("prmId", MySqlDbType.Int16).Value = item.getId();
            
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
            MySqlConnection connection1 = Connexion();
            try{
            MySqlCommand cmd = new MySqlCommand("ModifierCompteSalle", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("prmId", MySqlDbType.Int16).Value = item.getId();
            cmd.Parameters.Add("prmNom", MySqlDbType.VarChar).Value = item.getNom();
            cmd.Parameters.Add("prmPrenom", MySqlDbType.VarChar).Value = item.getPrenom();
            cmd.Parameters.Add("prmMail", MySqlDbType.VarChar).Value = item.getMail();
            cmd.Parameters.Add("prmTelelphone", MySqlDbType.VarChar).Value = item.getTelephone();
            cmd.Parameters.Add("prmAdresserue", MySqlDbType.VarChar).Value = item.getAdresseRue();
            cmd.Parameters.Add("prmAdresseVille", MySqlDbType.VarChar).Value = item.getAdresseVille();
            cmd.Parameters.Add("prmAdresseCp", MySqlDbType.VarChar).Value = item.getAdresseCp();

            
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("La requete ne c'est pas bien passé" + e);
            }
            
        }

        public static void AjouterCompte(Compte item)
        {
            MySqlConnection connection1 = Connexion();

            MySqlCommand cmd = new MySqlCommand("AjoutCompteSalle", connection1);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("prmNom", MySqlDbType.VarChar).Value = item.getNom();
            cmd.Parameters.Add("prmPrenom", MySqlDbType.VarChar).Value = item.getPrenom();
            cmd.Parameters.Add("prmMail", MySqlDbType.VarChar).Value = item.getMail();
            cmd.Parameters.Add("prmTelelphone", MySqlDbType.VarChar).Value = item.getTelephone();
            cmd.Parameters.Add("prmAdresserue", MySqlDbType.VarChar).Value = item.getAdresseRue();
            cmd.Parameters.Add("prmAdresseVille", MySqlDbType.VarChar).Value = item.getAdresseVille();
            cmd.Parameters.Add("prmAdressecp", MySqlDbType.VarChar).Value = item.getAdresseCp();

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
            MySqlConnection conn = Connexion();

            MySqlCommand cmd = new MySqlCommand("SelectSalle", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("prmType", MySqlDbType.VarChar).Value = "reunion";
            cmd.Parameters.Add("prmDate", MySqlDbType.VarChar).Value = prmDate ;
            cmd.Parameters.Add("prmNombre", MySqlDbType.Int16).Value = nombrePersonne ;
            
            MySqlDataReader reader = cmd.ExecuteReader();
           
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
            MySqlConnection conn = Connexion();

            MySqlCommand cmd = new MySqlCommand("SelectSalle", conn);
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.Add("prmType", MySqlDbType.VarChar).Value = "mariage";
            cmd.Parameters.Add("prmDate", MySqlDbType.VarChar).Value = prmDate ;
            cmd.Parameters.Add("prmNombre", MySqlDbType.Int16).Value = nombrePersonne ;
            
            MySqlDataReader reader = cmd.ExecuteReader();
            
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
            string datecle = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection connection1 = Connexion();

            MySqlCommand cmd = new MySqlCommand("AjoutReservation", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("prmIdSalle", MySqlDbType.Int16).Value = prmIdSalle;
            cmd.Parameters.Add("prmIdCompte", MySqlDbType.Int16).Value = prmIdCompte;
            cmd.Parameters.Add("prmDate", MySqlDbType.VarChar).Value = prmDate;
            cmd.Parameters.Add("prmNombre", MySqlDbType.Int16).Value = prmNombre;
            cmd.Parameters.Add("prmDateCle", MySqlDbType.VarChar).Value = datecle;
                
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
            string datecle = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection connection1 = Connexion();
            foreach (Reunion item in liste)
            {
                MySqlCommand cmd = new MySqlCommand("AjoutReservation", connection1);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("prmIdSalle", MySqlDbType.Int16).Value = item.getId();
                cmd.Parameters.Add("prmIdCompte", MySqlDbType.Int16).Value = prmIdCompte;
                cmd.Parameters.Add("prmDate", MySqlDbType.VarChar).Value = prmDate;
                cmd.Parameters.Add("prmNombre", MySqlDbType.Int16).Value = prmNombre;
                cmd.Parameters.Add("prmDateCle", MySqlDbType.VarChar).Value = datecle;
                
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

        public static List<Reservation> SelectReservation(int id)
        {
            MySqlConnection conn = Connexion();

            MySqlCommand cmd = new MySqlCommand("SelectReservation", conn);
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.Add("prmId", MySqlDbType.Int16).Value = id;
            
            
            MySqlDataReader reader = cmd.ExecuteReader();
            
            List<Reservation> liste = new List<Reservation>();
            while(reader.Read())
            {
                Reservation reservation = new Reservation(Int16.Parse(reader["idcompte"].ToString()), 
                    Int16.Parse(reader["idsalle"].ToString()),reader["dateRes"].ToString(),
                    Int16.Parse(reader["nombre"].ToString()),DateTime.Parse(reader["dateCle"].ToString()));
                liste.Add(reservation);
                
            }
            return liste;
        }
        public static void SupprimerReservation(Reservation item)
        {
            MySqlConnection connection1 = Connexion();
            
            MySqlCommand cmd = new MySqlCommand("SupprimmerReservation", connection1);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("prmDate", MySqlDbType.VarChar).Value = item.getDateCle().ToString("yyyy-MM-dd HH:mm:ss");
            MessageBox.Show(item.getDateCle().ToString());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("La requete ne c'est pas bien passé");
            }
        }
        
    }
}