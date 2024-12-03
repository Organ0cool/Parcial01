using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Usuarios
    {
        private string _usuario;
        private string _clave;
        private string _nivel;

        //Constructores
        public Usuarios()
        {
        }

        public Usuarios(string usu, string cla, string niv)
        {
            _usuario = usu;
            _clave = cla;
            _nivel = niv;
        }

        //Propiedades
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public string Nivel { get => _nivel; set => _nivel = value; }
    }
}
