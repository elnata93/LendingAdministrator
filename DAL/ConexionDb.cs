﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAL
{
    public class ConexionDb
    {
        private SqlConnection conexion;
        private SqlCommand cmd;

        public ConexionDb() 
        {
            //conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=LendingAdministratorDb;Integrated Security=True");
            cmd = new SqlCommand();
        }

        public bool Ejecutar(String ComandoSql)
        {
            bool retorno = false;

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = ComandoSql;
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        public DataTable ObtenerDatos(String ComandoSql)
        {
            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = ComandoSql;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }

        public object ObtenerValor(String ComandoSql)
        {
            object retorno = null;

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = ComandoSql;
                retorno = cmd.ExecuteScalar();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return retorno;
        }

    }
}
