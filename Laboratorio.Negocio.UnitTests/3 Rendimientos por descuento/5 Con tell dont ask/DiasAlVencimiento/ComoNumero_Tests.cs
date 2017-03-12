using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConTellDontAsk;

namespace Laboratorio.Negocio.UnitTests.RendimientosPorDescuento.ConTellDontAsk.DiasAlVencimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;
        private DatosDelRendimientoPorDescuento losDatos;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 221;

            losDatos = new DatosDelRendimientoPorDescuento();
            losDatos.FechaActual = new DateTime(2016, 3, 3);
            losDatos.FechaDeVencimiento = new DateTime(2016, 10, 10);
            elResultadoObtenido = new DiasAlVencimiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}