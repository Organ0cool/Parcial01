using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Logica
{
    public class UsuariosDAO : ConexBD
    {
        public UsuariosDAO(string bd) : base(bd)
        {

        }
        //Aqui iran los metodos de mantenimiento de la tabla Usuarios y otros
        public bool validarUsuario(string usu, string cla, string niv)
        {
            sql = "Select * from usuarios where usuario=@usu and clave=@cla and nivel=@niv";
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usu", usu);
                cmd.Parameters.AddWithValue("@cla", cla);
                cmd.Parameters.AddWithValue("@niv", niv);

                drd = cmd.ExecuteReader();
                if (drd.Read())
                {
                    drd.Close();
                    return true;
                }
                else
                {
                    drd.Close();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR validarUsuario: " + ex.Message);
                return false;
            }

        }
    }
}
