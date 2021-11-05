using System;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using ServiciosPublicos;

namespace PruebaUnitaria
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        string[] nombresServicios = new string[] { "Energía", "Internet" };

        [Test]
        public void TestBuscaMaximoConsumo()
        {
            //VALORES INICIALES
            Servicio[] servicios = new Servicio[4];
            servicios[0] = new Servicio("Energía", 10000);
            servicios[1] = new Servicio("Energía", 18000);
            servicios[2] = new Servicio("Internet", 12000);
            servicios[3] = new Servicio("Internet", 16000);

            float[] maximoConsumoServicios = ServiciosPublicos.Program.BuscaMaximoConsumo(servicios, nombresServicios);

            //RESULTADO ESPERADO
            float[] resultadoEsperado = new float[2];
            resultadoEsperado[0] = 18000;
            resultadoEsperado[1] = 16000;

            //COMPARACION
            Assert.AreEqual(resultadoEsperado, maximoConsumoServicios);
        }

        [Test]
        public void testCalcularPromedios()
        {
            //VALORES INICIALES
            Servicio[] servicios = new Servicio[4];
            servicios[0] = new Servicio("Energía", 10000);
            servicios[1] = new Servicio("Energía", 18000);
            servicios[2] = new Servicio("Internet", 12000);
            servicios[3] = new Servicio("Internet", 18000);

            float[] promediosServicios = ServiciosPublicos.Program.CalculaPromedios(servicios, nombresServicios);

            //RESULTADO ESPERADO
            float[] resultadoEsperado = new float[2];
            resultadoEsperado[0] = 14000;
            resultadoEsperado[1] = 15000;

            //COMPARACION
            Assert.AreEqual(resultadoEsperado, promediosServicios);
        }

        [Test]
        public void testCalcularTotales()
        {
            //VALORES INICIALES
            Servicio[] servicios = new Servicio[5];
            servicios[0] = new Servicio("Energía", 10000);
            servicios[1] = new Servicio("Energía", 18000);
            servicios[2] = new Servicio("Internet", 12000);
            servicios[3] = new Servicio("Internet", 18000);
            servicios[4] = new Servicio("Internet", 18000);

            int[] totalServicios = ServiciosPublicos.Program.CalculaTotales(servicios, nombresServicios);

            //RESULTADO ESPERADO
            float[] resultadoEsperado = new float[2];
            resultadoEsperado[0] = 2;
            resultadoEsperado[1] = 3;

            //COMPARACION
            Assert.AreEqual(resultadoEsperado, totalServicios);
        }

    }


}