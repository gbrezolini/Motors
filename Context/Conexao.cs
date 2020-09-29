using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Motors.Context
{
    public class Conexao
    {
        // server=localhost;user id=root;persistsecurityinfo=True;database=motorsmanager
        public string strConexao = "SERVER=localhost; DATABASE=motorsmanager; UID=root; PWD=bdmanager; PORT=;";
        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(strConexao);
                con.Open();

                // TESTE
                HttpContext.Current.Response.Write("conectado !!!");

            } catch (Exception e)
            {
                HttpContext.Current.Response.Write("Erro ao conectar: " + e);
            }

        }

        public void FecharConexao ()
        {
            try
            {
                con = new MySqlConnection(strConexao);
                con.Close();

            }
            catch (Exception e)
            {
                //throw;
            }
        }

    }
}