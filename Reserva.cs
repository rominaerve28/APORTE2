using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte2.Clases
{
    public class Reserva
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        private List<Habitacion_Por_Reserva> listaHabitacionporreserva;


        public List<Habitacion_Por_Reserva> ListaHabitacionporreserva
        {
            get { return listaHabitacionporreserva; }
            set { listaHabitacionporreserva = value; }
        }

        private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

    }
}
