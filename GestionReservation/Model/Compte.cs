namespace GestionReservation.Model
{
    public class Compte
    {
        private int id;
        private string nom;
        private string prenom;
        private string mail;
        private string telephone;
        private string adresseRue;
        private string adresseVille;
        private string adresseCp;

        public Compte(int id, string nom, string prenom, string mail, string telephone, string adresseRue, string adresseVille, string adresseCp)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.telephone = telephone;
            this.adresseRue = adresseRue;
            this.adresseVille = adresseVille;
            this.adresseCp = adresseCp;
        }

        public int getId()
        {
            return this.id;
        }

        public string getNom()
        {
            return this.nom;
        }

        public string getPrenom()
        {
            return this.prenom;
        }

        public string getMail()
        {
            return this.mail;
        }

        public string getTelephone()
        {
            return this.telephone;
        }

        public string getAdresseRue()
        {
            return this.adresseRue;
        }

        public string getAdresseVille()
        {
            return this.adresseVille;
        }

        public string getAdresseCp()
        {
            return this.adresseCp;
        }

        public override string ToString()
        {
            return this.nom +" " + this.prenom;
        }
    }
}