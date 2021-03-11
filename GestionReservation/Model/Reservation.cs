using System;

namespace GestionReservation.Model
{
    public class Reservation
    {
        private int idCompte;
        private int idSalle;
        private DateTime dateRes;
        private int nombre;

        public Reservation(int idCompte, int idSalle, DateTime dateRes, int nombre)
        {
            this.idCompte = idCompte;
            this.idSalle = idSalle;
            this.dateRes = dateRes;
            this.nombre = nombre;
        }

        public int getIdCompte()
        {
            return this.idCompte;
        }

        public int getIdSalle()
        {
            return this.idSalle;
        }

        public DateTime getDateRes()
        {
            return this.dateRes;
        }

        public int getNombre()
        {
            return this.nombre;
        }
    }
}