using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class UsuariosTests
    {
        [TestMethod()]
        public void UsuariosTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UsuariosTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EditarTest()
        {
            Usuarios user = new Usuarios();
            user.Nombres = "ada";
            user.Apellidos = "ahfk";
            user.NombreUsuario = "juan";
            user.Contrasena = "1234";
            user.TipoUsuario = "empleado";
            user.UsuarioId = 1;
            Assert.IsTrue(user.Editar());
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListadoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ListadoDtTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccesoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarAdministradorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ComprobarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTest()
        {
            Assert.Fail();
        }
    }
}