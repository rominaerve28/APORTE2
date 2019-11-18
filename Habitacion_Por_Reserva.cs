using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte2.Clases
{
    public class Habitacion_Por_Reserva
    {
        private Habitacion habitacion;

        public Habitacion Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }

        private Reserva reserva;

        public Reserva Reserva
        {
            get { return reserva; }
            set { reserva = value; }
        }

        private List<ServicioExtra> listaServicioextra;


        public List<ServicioExtra> ListaServicioextra
        {
            get { return listaServicioextra; }
            set { listaServicioextra = value; }
        }




    }
}
