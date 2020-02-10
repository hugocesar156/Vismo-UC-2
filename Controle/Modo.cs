using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Controle
{
    public class Modo
    {
        private int tipo;

        public Usuario usuario;

        public int Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        public Modo()
        {
            usuario = new Usuario();
        }

        public void Inicia()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "INSERT INTO Modo VALUES ('1', @codigoUsuario)";
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public void AlteraModo()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "UPDATE Modo SET tipo = @tipo WHERE codigoUsuario = @codigoUsuario";
                cn.Parameters.Add("tipo", SqlDbType.Int).Value = tipo;
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                cn.ExecuteNonQuery();
            }
        }

        public void BuscaModo()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;

                con.Open();
                cn.CommandText = "SELECT tipo FROM Modo WHERE codigoUsuario = @codigoUsuario";
                cn.Parameters.Add("codigoUsuario", SqlDbType.Int).Value = usuario.Codigo;
                cn.Connection = con;

                SqlDataReader reader = cn.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tipo = reader.GetInt32(0);
                    }
                }
            }
        }
    }
}
