namespace GestionReservation.Model
{
    public class Salle
    {
        private int id;
        private int nbrPersonne;
        

        public Salle(int id, int nbrPersonne)
        {
            this.id = id;
            this.nbrPersonne = nbrPersonne;
            
        }

        public int getId()
        {
            return this.id;
        }
        
        public int getNbrPersonne()
        {
            return this.nbrPersonne;
        }
        
    }

}