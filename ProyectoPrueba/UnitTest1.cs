using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoViajes.Controls;
using System;
using System.Data;

namespace ProyectoPrueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            ControladorUsuariosAdmin controlador = new ControladorUsuariosAdmin(); 
            DataTable result;

            // Act
            result = controlador.obtenerUsuarios(controlador.construirCadenaConexionPruebas());

            // Assert
            Assert.IsNotNull(result); // Verifica que el resultado no sea nulo
            Assert.IsTrue(result.Rows.Count > 0); // Verifica que la tabla de usuarios no esté vacía
        }
    }
}
