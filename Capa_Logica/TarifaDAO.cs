using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Logica
{
    public class TarifaDAO : ConexBD
    {
        public TarifaDAO(string bd) : base(bd)
        {
        }
        
        public void listar(DataGridView tbl)
        {
            sql = "spl_tarifa";

            try
            {
                adp = new SqlDataAdapter(sql, cnx);
                ds = new DataSet();
                adp.Fill(ds, "tarifa");
                tbl.DataSource = ds;
                tbl.DataMember = "tarifa";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Agregar(Tarifa f)
        {
            sql = "spi_tarifa";
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText=sql;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@idtarifa", f.Idtarifa);
                cmd.Parameters.AddWithValue("@clase", f.Clase);
                cmd.Parameters.AddWithValue("@precio", f.Precio);
                cmd.Parameters.AddWithValue("@impuesto", f.Impuesto);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        public void Eliminar(String idtarifa)
        {
            int resul;
            sql = "spd_tarifa";
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText=sql;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@idtarifa", idtarifa);
                resul = cmd.ExecuteNonQuery();
                if (resul == 1) 
                {
                    MessageBox.Show("Registro Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontró ningún registro");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool buscar(string idtarifa, Tarifa f)
        {
            sql = "spq_tarifa";
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtarifa", idtarifa);

                drd= cmd.ExecuteReader();
                if (drd.Read()) 
                { 
                    f.Idtarifa = int.Parse(drd["idtarifa"].ToString());
                    f.Clase = drd["clase"].ToString();
                    f.Precio = double.Parse(drd["precio"].ToString());
                    f.Impuesto = double.Parse(drd["impuesto"].ToString());

                    drd.Close();
                    return true;
                }
                else
                {
                    drd.Close ();
                    MessageBox.Show("ERROR: Código no Existe");
                    return false;
                }
            }
            catch (SqlException ex)
            {
                drd.Close () ;
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void modificar(int idtarifa, Tarifa f)
        {
            sql = "spm_tarifa";
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sql;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@idtarifa", f.Idtarifa);
                cmd.Parameters.AddWithValue("@clase", f.Clase);
                cmd.Parameters.AddWithValue("@precio", f.Precio);
                cmd.Parameters.AddWithValue("@impuesto", f.Impuesto);
                cmd.ExecuteNonQuery ();
                MessageBox.Show("Ha sido modificado correctamente!!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
