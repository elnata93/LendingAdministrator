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
    public class ClientesTests
    {
        [TestMethod()]
        public void ClientesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientesTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = "nata";
            cliente.Apellidos = "Peres";
            cliente.Apodos = "el nata";
            cliente.Sexo = 1;
            cliente.Cedula = "05700123458";
            cliente.Direccion = "afyoafyhoifa";
            cliente.Referencia = "iwfgouasho";
            cliente.Telefono = "87585876897";
            cliente.Celular = "809789675";
            Assert.IsTrue(cliente.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            Clientes cliente = new Clientes();
            cliente.Nombres = "nata";
            cliente.Apellidos = "Peres";
            cliente.Apodos = "el nata";
            cliente.Sexo = 1;
            cliente.Cedula = "05700123458";
            cliente.Direccion = "afyoafyhoifa";
            cliente.Referencia = "iwfgouasho";
            cliente.Telefono = "87585876897";
            cliente.Celular = "809789675";
            cliente.ClienteId = 1;
            Assert.IsTrue(cliente.Editar());
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
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
    }
}