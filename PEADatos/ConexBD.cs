using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace Capa_Datos
{
    public class ConexBD
    {
        protected SqlConnection cnx;
        protected SqlCommand cmd;
        protected SqlDataAdapter adp;
        protected SqlDataReader drd;
        protected SqlParameter[] prm;
        protected string sql;
        protected DataSet ds;

        //Propiedades
        public SqlConnection Cnx { get => cnx; set => cnx = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataAdapter Adp { get => adp; set => adp = value; }
        public SqlDataReader Drd { get => drd; set => drd = value; }
        public SqlParameter[] Prm { get => prm; set => prm = value; }
        public string Sql { get => sql; set => sql = value; }
        public DataSet Ds { get => ds; set => ds = value; }

        public ConexBD(string bd)
        {
            sql = "Server =.;Database=" + bd + ";Integrated Security=true";
            try
            {
                cnx = new SqlConnection(sql);
                cnx.Open();
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                MessageBox.Show("OK Conexión Establecida ....");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void cerrarConexion()
        {
            cnx.Close();
        }
    }
}
