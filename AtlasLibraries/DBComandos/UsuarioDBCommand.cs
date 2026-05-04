using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.DBComandos
{
    public class UsuarioDBCommand
    {
        private string _connectionString;

        public DataTable sa_usuarios(string param)
        {
            SqlCommand cmd = new SqlCommand("sa_usuarios");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@param", param);

            if (ExecuteReader(cmd, out DataTable dt, out string error))
                return dt;
            else
                throw new Exception(error);

        }

        private bool ExecuteReader(SqlCommand cmd, out DataTable dt, out string error)
        {
            dt = new DataTable();
            error = "";
            string SqlConnection = "Areli;Database=dbPostres;User Id=ARELI;Password=123456;";


            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    Console.WriteLine("Conexion exitosa");
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexion no exitosa");
                error = ex.Message;
                return false;
            }
        }
    }
}


    
