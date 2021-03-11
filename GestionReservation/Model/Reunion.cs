namespace GestionReservation.Model
{
    public class Reunion : Salle
    {
        private int superficie;

        public Reunion(int id, int nbrPersonne, int superficie) : base(id, nbrPersonne)
        {
            this.superficie = superficie;
        }

        public int getSuperficie()
        {
            return this.superficie;
        }
        public override string ToString()
        {
            return "Nbr max :" + getNbrPersonne() +" / Superficie :  " + this.superficie;
        }
    }
}