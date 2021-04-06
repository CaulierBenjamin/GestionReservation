using System;

namespace GestionReservation.Model
{
    public class Reservation
    {
        private int idCompte;
        private int idSalle;
        private string dateRes;
        private int nombre;
        private DateTime dateCle;

        public Reservation(int idCompte, int idSalle, string dateRes, int nombre , DateTime dateCle)
        {
            this.idCompte = idCompte;
            this.idSalle = idSalle;
            this.dateRes = dateRes;
            this.nombre = nombre;
            this.dateCle = dateCle;
        }

        public int getIdCompte()
        {
            return this.idCompte;
        }

        public int getIdSalle()
        {
            return this.idSalle;
        }

        public string getDateRes()
        {
            return this.dateRes;
        }

        public int getNombre()
        {
            return this.nombre;
        }

        public DateTime getDateCle()
        {
            return this.dateCle;
        }

        public override string ToString()
        {
            return "nombre :" + nombre + "/date : " + dateRes;
        }
    }
}