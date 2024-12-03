using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Tarifa
    {
        private int idtarifa;
        private string clase;
        private double precio;
        private double impuesto;

        public Tarifa()
        {
        }

        public Tarifa(int idtarifa, string clase, double precio, double impuesto)
        {
            this.idtarifa = idtarifa;
            this.clase = clase;
            this.precio = precio;
            this.impuesto = impuesto;
        }

        public int Idtarifa { get => idtarifa; set => idtarifa = value; }
        public string Clase { get => clase; set => clase = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Impuesto { get => impuesto; set => impuesto = value; }
    }



}
