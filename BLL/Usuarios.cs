using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }
        public static int Id = 0;

        public Usuarios()
        {
            this.UsuarioId = 0;
            this.Nombres = "";
            this.Apellidos = "";
            this.NombreUsuario = "";
            this.Contrasena = "";
            this.TipoUsuario = "";

        }
        public Usuarios(int usuarioId, string nombres, string apellidos, string nombreUsuario, string contrasena, string tipousuario)
        {
            this.UsuarioId = usuarioId;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.TipoUsuario = tipousuario;
    
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;

            try
            {
                retorno = conexion.Ejecutar(String.Format("insert into Usuarios(Nombres,Apellidos,NombresUsuarios,Contrasena,TiposUsuarios) values('{0}','{1}','{2}','{3}','{4}')",
                    this.Nombres, this.Apellidos, this.NombreUsuario, this.Contrasena, this.TipoUsuario));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("update Usuarios set Nombres='{0}',Apellidos='{1}',NombresUsuarios='{2}',Contrasena='{3}',TiposUsuarios='{4}' where UsuarioId={5} ",
                    this.Nombres, this.Apellidos, this.NombreUsuario, this.Contrasena, this.TipoUsuario, this.UsuarioId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("delete from Usuarios where UsuarioId={0} ", this.UsuarioId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public override bool Buscar(int Buscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuarios where UsuarioId= " + Buscado));
                if (dt.Rows.Count > 0)
                {
                    this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                    this.Nombres = dt.Rows[0]["Nombres"].ToString();
                    this.Apellidos = dt.Rows[0]["Apellidos"].ToString();
                    this.NombreUsuario = dt.Rows[0]["NombresUsuarios"].ToString();
                    this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                    this.TipoUsuario = dt.Rows[0]["TiposUsuarios"].ToString();
                }
                return dt.Rows.Count > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenar = "";
            if (!Orden.Equals(""))
                ordenar = " orden by  " + Orden;
            return conexion.ObtenerDatos(("select " + Campos + " from Usuarios where " + Condicion + Orden));
        }

        public DataTable ListadoDt(string Condicion)
        {
            ConexionDb conexion = new ConexionDb();

            return conexion.ObtenerDatos(string.Format("select *" + " from Usuarios where " + Condicion));

        }

        public bool Acceso()
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            bool retorno = false;
            dt = conexion.ObtenerDatos(string.Format("select * from Usuarios where NombreUsuario = '{0}' and Contrasena = '{1}' ", this.NombreUsuario, this.Contrasena));

            if (dt.Rows.Count > 0)
            {
                Id = (int)dt.Rows[0]["UsuarioId"];
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool BuscarAdministrador(string nombre, string contrasena)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            try
            {
                dt = conexion.ObtenerDatos(string.Format("select * from Usuarios where NombreUsuario= '{0}' AND Contrasena='{1}' AND TipoUsuario='ADMIN'", nombre, contrasena));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt.Rows.Count > 0;

        }

        public bool Comprobar()
        {
            ConexionDb con = new ConexionDb();
            DataTable dt = new DataTable();
            bool retorno = false;
            dt = con.ObtenerDatos(string.Format("select * from Usuarios where NombreUsuario = '{0}' ", this.NombreUsuario));
            if (dt.Rows.Count > 0)
            {
                Id = (int)dt.Rows[0]["UsuarioId"];
                this.TipoUsuario = dt.Rows[0]["TipoUsuario"].ToString();
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }

        public bool Login(string nombre, string contrasena)
        {
            ConexionDb con = new ConexionDb();
            DataTable datatable = new DataTable();
            datatable = con.ObtenerDatos(String.Format("select  NombresUsuarios from Usuarios where NombresUsuarios = '{0}' and  Contrasena = '{1}'", nombre, contrasena));
            if (datatable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
