namespace GestionReservation.Model
{
    public class Mariage : Salle
    {
        private string nom;

        public Mariage(int id, int nbrPersonne, string nom) : base(id, nbrPersonne)
        {
            this.nom = nom;
        }

        public string getNom()
        {
            return this.nom;
        }
        public override string ToString()
        {
            return "Nbr max :" + getNbrPersonne() +" / Nom :  " + this.nom;
        }
    }
}