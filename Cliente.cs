using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte2.Clases
{
   public class Cliente
    {
        public Cliente(string identificacion, string nombre, List<Reserva> listareserva)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Listareserva = listareserva;
        }
        public void MostrarReserva()
        {



        }


        private String identificacion;

        public String Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<Reserva> listareserva;

      

        public List<Reserva> Listareserva
        {
            get { return listareserva; }
            set { listareserva = value; }
        }




    }
}
